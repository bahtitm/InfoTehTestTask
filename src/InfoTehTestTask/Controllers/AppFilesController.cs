using Application.Features.AppFiles.Commands.CreateFolderFile;
using Application.Features.AppFiles.Commands.DeleteAppFile;
using Application.Features.AppFiles.Commands.UpdateAppFile;
using Application.Features.AppFiles.Commands.UpdateName;
using Application.Features.AppFiles.Queries.DownloadFile;
using Application.Features.AppFiles.Queries.GetAll;
using Application.Features.AppFiles.Queries.GetDetail;
using Microsoft.AspNetCore.Mvc;

namespace InfoTehTestTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AppFilesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dataSource = await mediator.Send(new GetAllAppFileQuery());
            return Ok(dataSource.AsQueryable());
        }


        [HttpGet("Download/{id}")]
        public async Task<IActionResult> Download(uint id)
        {
            var result = await mediator.Send(new DownloadFileCommand(id));
            Response.Headers.Add("Access-Control-Expose-Headers", "Content-Disposition");
            return File(result.bytes, "application/*", result.documentName);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(uint id)
        {
            return Ok(await mediator.Send(new GetDetailAppFileQuery(id)));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateAppFileCommand command)
        {
            await mediator.Send(command);
            return NoContent();
        }


        [HttpPut("UpdateName")]
        public async Task<IActionResult> Put([FromBody] UpdateAppFileNameCommand command)
        {
           
            await mediator.Send(command);
            return NoContent();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(uint id, [FromBody] UpdateAppFileCommand command)
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
            await mediator.Send(new DeleteAppFileCommand(id));
            return NoContent();
        }
    }
}
