using Application.Features.Folders.Commands.CreateFolder;
using Application.Features.Folders.Commands.DeleteFolder;
using Application.Features.Folders.Commands.UpdateFolder;
using Application.Features.Folders.Queries.GetAll;
using Application.Features.Folders.Queries.GetDetail;
using Microsoft.AspNetCore.Mvc;

namespace InfoTehTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FoldersController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataSource = await mediator.Send(new GetAllFolderQuery());
            return Ok(dataSource.AsQueryable());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            return Ok(await mediator.Send(new GetDetailFolderQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateFolderCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, [FromBody] UpdateFolderCommand command)
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
            await mediator.Send(new DeleteFolderCommand(id));
            return NoContent();
        }
    }
}
