using ASPNETLambdaAPI.Entities;

namespace ASPNETLambdaAPI.Factories.BookFactory.Interfaces;

public interface IBookFactory
{
	public Book FromDTO(string title, string isbn, string coverPage);
}