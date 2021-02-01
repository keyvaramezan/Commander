namespace Commander.Data
{
    public interface ICommandRepository
    {
        System.Threading.Tasks.Task<Models.Command> GetByIdAsync(int Id);

        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Models.Command>> GetAllAsync();


    } 
}