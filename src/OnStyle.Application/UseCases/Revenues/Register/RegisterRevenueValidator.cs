using FluentValidation;
using OnStyle.Communication.Requests;

namespace OnStyle.Application.UseCases.Revenues.Register;

public class RegisterRevenueValidator : AbstractValidator<RequestRegisterRevenueJson>
{
    public RegisterRevenueValidator()
    {
        RuleFor(revenue => revenue.ServiceName).NotNull().NotEmpty().WithMessage("The service name is required.");
        RuleFor(revenue => revenue.ServiceDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Revenues cannot be for the futures");
        RuleFor(revenue => revenue.ServicePrice).GreaterThan(0).WithMessage("Price amount must be greater than zero.");
        RuleFor(revenue => revenue.BarberName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(10).WithMessage("Barber must have a name.");
        RuleFor(revenue => revenue.ClientName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(10).WithMessage("Client must have a name.");
        RuleFor(revenue => revenue.PaymentType).IsInEnum();
    }
}