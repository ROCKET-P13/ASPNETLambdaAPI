using ASPNETLambdaAPI.Entities;

namespace ASPNETLambdaAPI.Finders.BookFinder.Interfaces;

public interface IBookFinder
{
	Task<List<Book>> GetAll();
}