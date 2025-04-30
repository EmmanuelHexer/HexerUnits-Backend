namespace Entities.Dtos.Response;

public class HealthResponse
{
    public required string Message { get; init; }
    public required DateTime TimeStamp { get; init; }
}