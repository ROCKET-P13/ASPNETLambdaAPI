namespace ASPNETLambdaAPI.DTOs.Requests;

public class AddBookRequest
{
	public required string Title { get; set; }
	public string ISBN { get; set; } = string.Empty;
	public string CoverPage { get; set; } = string.Empty; 
}