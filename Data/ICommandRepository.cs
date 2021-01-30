namespace Commander.Data
{
    public interface ICommandRepository
    {
        Models.Command GetById(int Id);

        System.Collections.Generic.IEnumerable<Models.Command> GetAll();


    } 
}