using OnStyle.Communication.Requests;
using OnStyle.Communication.Response;
using OnStyle.Exception.ExceptionsBase;

namespace OnStyle.Application.UseCases.Revenues.Register;

public class RegisterRevenueUseCase
{
    public ResponseRegisterRevenueJson Execute(RequestRegisterRevenueJson request)
    {
        Validate(request);
        
        return new ResponseRegisterRevenueJson(); 
    }

    private void Validate(RequestRegisterRevenueJson request)
    {
        var validation = new RegisterRevenueValidator();

        var result = validation.Validate(request);

        if (result.IsValid == false) 
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }
    }
}
