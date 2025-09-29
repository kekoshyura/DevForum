using DevForum.Contracts.Questions;
using FluentValidation;

namespace DevForum.Application.Questions;

public class CreateQuestionValidator : AbstractValidator<CreateQuestionDTO>
{
    public CreateQuestionValidator()
    {
        RuleFor(x => x.Title).NotEmpty().MaximumLength(500).WithMessage("Title is not valid");
        
        RuleFor(x => x.Text).NotEmpty().MaximumLength(5000).WithMessage("Text is not valid");

        RuleForEach(x => x.TagIds).NotEmpty();
    }
}