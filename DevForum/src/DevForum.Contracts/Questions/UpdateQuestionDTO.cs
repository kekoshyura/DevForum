namespace DevForum.Contracts.Questions;

public record UpdateQuestionDTO(string Title, string Body, Guid[] TagIds);