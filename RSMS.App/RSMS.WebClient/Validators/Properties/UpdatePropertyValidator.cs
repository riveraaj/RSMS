namespace RSMS.WebClient.Validators.Properties;
public class UpdatePropertyValidator : AbstractValidator<UpdatePropertyDTO>
{
    public UpdatePropertyValidator()
    {
        RuleFor(DTO => DTO.Id).GreaterThan(0).WithMessage("The Id field is mandatory.");

        RuleFor(DTO => DTO.PropertyTypeId).GreaterThan((byte)0).WithMessage("The Property Type field is mandatory.");

        RuleFor(DTO => DTO.OwnerId).GreaterThan((byte)0).WithMessage("The Owner field is mandatory.");

        RuleFor(DTO => DTO.Number).NotEmpty().WithMessage("The Number field is mandatory.")
                                   .MaximumLength(255).WithMessage("The Number field cannot exceed 255 characters.");

        RuleFor(DTO => DTO.Address).NotEmpty().WithMessage("The Address field is mandatory.")
                                  .MaximumLength(255).WithMessage("The Address field cannot exceed 255 characters.");

        RuleFor(DTO => DTO.Area).GreaterThan(0).WithMessage("The Area field is mandatory.");
    }
}