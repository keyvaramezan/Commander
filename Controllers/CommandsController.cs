namespace Commander.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Route(template: "[controller]")]
    public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public CommandsController(Data.ICommandRepository repository) : base()
        {
           _repository = repository;
        }
        private readonly Data.ICommandRepository  _repository; 

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Command>>> GetAllAsync()
        {
            var result =
                await _repository.GetAllAsync();
            return Ok(result);
        }
        [Microsoft.AspNetCore.Mvc.HttpGet(template: "{id}")]
        public async System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Models.Command>> GetByIdAsync(int id)
        {
            Models.Command result = 
                await _repository.GetByIdAsync(id);
            return Ok(result);
        }

        // [Microsoft.AspNetCore.Mvc.HttpGet(template: "/a/b")]
        // public Microsoft.AspNetCore.Mvc.IActionResult GetString()
        // {
        //     return Content("Hello World!");
        // }
        // [Microsoft.AspNetCore.Mvc.HttpGet]
        // public async System.Threading.Tasks.Task<Models.Command> GetAnObject()
        // {
        //     Models.Command newCommand = null;

        //     await System.Threading.Tasks.Task.Run(() =>
        //     {
        //         newCommand = 
        //             new Models.Command
        //             {
        //                 Id = 1,
        //                 Line = $"Some Line",
        //                 HowTo = $"Some How To",
        //                 Platform = $"Some Platform",
        //             };
        //     });

        //     return newCommand;
        // }
    }
}