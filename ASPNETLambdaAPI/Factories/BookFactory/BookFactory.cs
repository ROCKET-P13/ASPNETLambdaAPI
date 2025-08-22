using ASPNETLambdaAPI.Entities;
using ASPNETLambdaAPI.Factories.BookFactory.Interfaces;

namespace ASPNETLambdaAPI.Factories.BookFactory;

public class BookFactory : IBookFactory
{
	public Book FromDTO(string title, string isbn, string coverPage)
	{
		var book = new Book
		{
			Id = Guid.NewGuid(),
			Title = title,
			ISBN = isbn,
			CoverPage = coverPage
		};

		return book;
	}
}