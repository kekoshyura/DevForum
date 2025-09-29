namespace DevForum.Contracts.Questions;

public record CreateQuestionDTO(string Title, string Text, Guid UserId, Guid[] TagIds);