namespace RSMS.WebClient.Validators.Properties.PropertyTypes;
public class UpdatePropertyTypeValidator : AbstractValidator<UpdatePropertyTypeDTO>
{
    public UpdatePropertyTypeValidator()
    {
        RuleFor(DTO => DTO.Id).GreaterThan((byte)0).WithMessage("The Id field is mandatory.");

        RuleFor(DTO => DTO.Description).NotEmpty().WithMessage("The Description field is mandatory.")
                                       .MaximumLength(255).WithMessage("The Description field cannot exceed 255 characters.");
    }
}