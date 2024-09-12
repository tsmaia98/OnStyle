using OnStyle.Communication.Requests;
using OnStyle.Communication.Response;

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
    }
}
