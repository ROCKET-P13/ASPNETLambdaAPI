using Microsoft.AspNetCore.Mvc;
using ASPNETLambdaAPI.Entities;
using ASPNETLambdaAPI.Repositories;
using ASPNETLambdaAPI.Repositories.Interfaces;
using ASPNETLambdaAPI.Finders.BookFinder.Interfaces;
using ASPNETLambdaAPI.DTOs.Requests;
using ASPNETLambdaAPI.Factories.BookFactory.Interfaces;

namespace ASPNETLambdaAPI.Controllers;

[Route("api/[controller]")]
[Produces("application/json")]
public class BooksController(
	IBookRepository bookRepository,
	IBookFinder bookFinder,
	IBookFactory bookFactory
	) : ControllerBase
{
	private readonly IBookRepository _bookRepository = bookRepository;
	private readonly IBookFinder _bookFinder = bookFinder;
	private readonly IBookFactory _bookFactory = bookFactory;

	[HttpGet]
	public async Task<ActionResult<List<Book>>> GetAll () {
		var books = await _bookFinder.GetAll();
		return Ok(books);
	}


	[HttpPost]
	public async Task<ActionResult<Book>> Post([FromBody] AddBookRequest request)
	{
		var book = _bookFactory.FromDTO(request.Title, request.ISBN, request.CoverPage);
		if (book == null) return ValidationProblem("Invalid input! Book not informed");

		var result = await _bookRepository.SaveAsync(book);

		if (result != null)
		{
			return result;
		}
		else
		{
			return BadRequest("Fail to persist");
		}
	}
}