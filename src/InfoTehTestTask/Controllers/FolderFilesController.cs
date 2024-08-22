using Application.Features.FolderFiles.Commands.CreateFolderFile;
using Application.Features.FolderFiles.Commands.DeleteFolderFile;
using Application.Features.FolderFiles.Commands.UpdateFolderFile;
using Application.Features.FolderFiles.Queries.GetAll;
using Application.Features.FolderFiles.Queries.GetDetail;
using Microsoft.AspNetCore.Mvc;

namespace InfoTehTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FolderFilesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataSource = await mediator.Send(new GetAllFolderFileQuery());
            return Ok(dataSource.AsQueryable());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            return Ok(await mediator.Send(new GetDetailFolderFileQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateFolderFileCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, [FromBody] UpdateFolderFileCommand command)
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
            await mediator.Send(new DeleteFolderFileCommand(id));
            return NoContent();
        }
    }
}
