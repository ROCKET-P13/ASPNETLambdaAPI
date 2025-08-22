using ASPNETLambdaAPI.Data;
using ASPNETLambdaAPI.Entities;
using ASPNETLambdaAPI.Repositories.Interfaces;

namespace ASPNETLambdaAPI.Repositories;

public class BookRepository(AppDatabaseContext databaseContext) : IBookRepository
{
	private readonly AppDatabaseContext _databaseContext = databaseContext;

	public async Task<Book> SaveAsync(Book book)
	{
		_databaseContext.Books.Add(book);

		await _databaseContext.SaveChangesAsync();

		return book;
	}
}