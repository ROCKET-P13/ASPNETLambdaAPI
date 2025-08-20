using ASPNETLambdaAPI.Entities;

namespace ASPNETLambdaAPI.Repositories.Interfaces;

public interface IBookRepository
{
	Task<Book> SaveAsync(Book book);
}