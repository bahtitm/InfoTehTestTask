using Application.Features.FileExtensions.Commands.CreateFileExtension;
using Application.Features.FileExtensions.Commands.DeleteFileExtension;
using Application.Features.FileExtensions.Commands.UpdateFileExtension;
using Application.Features.FileExtensions.Queries.GetAll;
using Application.Features.FileExtensions.Queries.GetDetail;
using Microsoft.AspNetCore.Mvc;

namespace InfoTehTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FileExtensionsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataSource = await mediator.Send(new GetAllFileExtensionQuery());
            return Ok(dataSource.AsQueryable());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            return Ok(await mediator.Send(new GetDetailFileExtensionQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateFileExtensionCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, [FromBody] UpdateFileExtensionCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest($"Check request: {id} not equals {command.Id}");
            }
            await mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(uint id)
        {
            await mediator.Send(new DeleteFileExtensionCommand(id));
            return NoContent();
        }
    }
}
