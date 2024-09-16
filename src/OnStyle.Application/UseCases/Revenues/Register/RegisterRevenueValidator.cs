using FluentValidation;
using OnStyle.Communication.Requests;
using OnStyle.Exception;

namespace OnStyle.Application.UseCases.Revenues.Register;

public class RegisterRevenueValidator : AbstractValidator<RequestRegisterRevenueJson>
{
    public RegisterRevenueValidator()
    {
        RuleFor(revenue => revenue.ServiceName).NotNull().NotEmpty().WithMessage(ResourceErrorMessages.SERVICE_NAME_REQUIRED);
        RuleFor(revenue => revenue.ServiceDate).LessThanOrEqualTo(DateTime.UtcNow).WithMessage(ResourceErrorMessages.REVENUE_CANT_FUTURE);
        RuleFor(revenue => revenue.ServicePrice).GreaterThan(0).WithMessage(ResourceErrorMessages.AMOUNT_GREATER_ZERO);
        RuleFor(revenue => revenue.BarberName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(10).WithMessage(ResourceErrorMessages.NAME_REQUIRED);
        RuleFor(revenue => revenue.ClientName).NotNull().NotEmpty().MinimumLength(3).MaximumLength(10).WithMessage(ResourceErrorMessages.NAME_REQUIRED);
        RuleFor(revenue => revenue.PaymentType).IsInEnum().WithMessage(ResourceErrorMessages.PAYMENTYPE_NOT_VALID);
    }
}