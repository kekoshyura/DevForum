using DevForum.Contracts;
using DevForum.Domain.Questions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevForum.Presenters;

[ApiController]
[Route("[controller]")]
public class QuestionsController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateQuestionDTO dto)
    {
        return Ok();
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