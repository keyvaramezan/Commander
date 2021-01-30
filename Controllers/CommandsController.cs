namespace Commander.Controllers
{
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Route(template: "api/[controller]")]
    public class CommandsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public CommandsController(Data.ICommandRepository repository) : base()
        {
           _repository = repository;
        }
        private readonly Data.ICommandRepository  _repository; 

        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IEnumerable<Models.Command>> GetAll()
        {
            var result = _repository.GetAll();
            return Ok(result);
        }
        [Microsoft.AspNetCore.Mvc.HttpGet(template: "{id}")]
        public Microsoft.AspNetCore.Mvc.ActionResult<Models.Command> GetById(int id)
        {
            Models.Command result = _repository.GetById(id);
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