namespace DevForum.Contracts;

public record CreateQuestionDTO(string Title, string Body, Guid UserId, Guid[] TagIds);