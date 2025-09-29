namespace DevForum.Contracts.Questions;

public record GetQuestionDTO(string Search, Guid[] TagIds, int Page, int PageSize);