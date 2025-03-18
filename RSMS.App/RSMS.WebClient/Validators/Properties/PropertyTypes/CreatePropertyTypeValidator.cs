namespace RSMS.WebClient.Validators.Properties.PropertyTypes;
public class CreatePropertyTypeValidator : AbstractValidator<CreatePropertyTypeDTO>
{
    public CreatePropertyTypeValidator()
    {
        RuleFor(DTO => DTO.Description).NotEmpty().WithMessage("The Description field is mandatory.")
                                       .MaximumLength(255).WithMessage("The Description field cannot exceed 255 characters.");
    }
}