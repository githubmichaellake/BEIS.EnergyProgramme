namespace BEIS.EnergyProgramme.Web
{
    public class MyService : IMyService
    {
        private readonly IRepository repository;

        public MyService(IRepository repository)
        {
            this.repository = repository;
        }

    }

    public interface IRepository
    {
    }

    public class MyRepo : IRepository
    { 
    }

    public class MyService2 : IMyService
    {
    }

    public interface IMyService
    {
    }
}