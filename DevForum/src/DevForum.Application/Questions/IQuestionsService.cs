using DevForum.Contracts.Questions;

namespace DevForum.Application.Questions;

public interface IQuestionsService
{
    Task<Guid> Create(CreateQuestionDTO dto, CancellationToken cancellationToken);
}