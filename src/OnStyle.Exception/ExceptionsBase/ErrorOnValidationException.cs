namespace OnStyle.Exception.ExceptionsBase;

public class ErrorOnValidationException : OnStyleException
{
    public List<string> Errors { get; set; } = [];
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}
