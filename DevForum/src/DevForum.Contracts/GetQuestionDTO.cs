namespace DevForum.Contracts;

public record GetQuestionDTO(string Search, Guid[] TagIds, int Page, int PageSize);