using DevForum.Application.Questions;
using DevForum.Contracts;
using DevForum.Contracts.Questions;
using Microsoft.AspNetCore.Mvc;

namespace DevForum.Presenters.Questions;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly IQuestionsService _questionService;

    public QuestionsController(IQuestionsService questionService)
    {
        _questionService = questionService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateQuestionDTO dto, CancellationToken cancellationToken)
    {
        var questionId = await _questionService.Create(dto, cancellationToken);
        return Ok($"Question created with id {questionId}");
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetQuestionDTO dto, CancellationToken cancellationToken)
    {
        return Ok("Questions get");
    }

    [HttpGet("{questionId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question get");
    }

    [HttpPut("{questionId:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid questionId, [FromQuery] UpdateQuestionDTO dto,
        CancellationToken cancellationToken)
    {
        return Ok("Question updated");
    }

    [HttpDelete("{questionId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid questionId, CancellationToken cancellationToken)
    {
        return Ok("Question deleted");
    }


    [HttpPut("{questionId:guid}/solution")]
    public async Task<IActionResult> SelectSolution([FromRoute] Guid questionId, [FromQuery] Guid solutionId, CancellationToken cancellationToken)
    {
        return Ok("Solution selected");
    }
    
    [HttpPost("{questionId:guid}/answers")]
    public async Task<IActionResult> AddAnswer([FromRoute] Guid questionId, [FromBody] AddAnswerDTO dto, CancellationToken cancellationToken)
    {
        return Ok("Answer added");
    }
    
}