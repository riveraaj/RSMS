namespace RSMS.WebClient.Validators.Owners;
public class CreateOwnerValidator : AbstractValidator<CreateOwnerDTO>
{
    public CreateOwnerValidator()
    {
        RuleFor(DTO => DTO.Name).NotNull().WithMessage("The Name field is mandatory.")
                                .NotEmpty().WithMessage("The Name field is mandatory.")
                                .MaximumLength(255).WithMessage("The Name field cannot exceed 255 characters.");

        RuleFor(DTO => DTO.Telephone).NotEmpty().WithMessage("The Telephone field is mandatory.")
                                     .MaximumLength(255).WithMessage("The Telephone field cannot exceed 255 characters.");

        RuleFor(DTO => DTO.Email).MaximumLength(255).WithMessage("The Email field cannot exceed 255 characters.");

        RuleFor(DTO => DTO.IdentificationNumber).NotEmpty().WithMessage("The Identification Number field is mandatory.")
                                                .MaximumLength(255).WithMessage("The Identification Number field cannot exceed 255 characters.");

        RuleFor(DTO => DTO.Address).MaximumLength(255).WithMessage("The Email field cannot exceed 255 characters.");
    }
}