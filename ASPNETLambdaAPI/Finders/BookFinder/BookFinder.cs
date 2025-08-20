using ASPNETLambdaAPI.Data;
using ASPNETLambdaAPI.Entities;
using ASPNETLambdaAPI.Finders.BookFinder.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ASPNETLambdaAPI.Finders.BookFinder;

public class BookFinder(AppDatabaseContext databaseContext) : IBookFinder
{
	private readonly AppDatabaseContext _databaseContext = databaseContext;
	
	public async Task<List<Book>> GetAll()
	{
		return await _databaseContext.Books.ToListAsync();
	}
}