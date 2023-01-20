namespace BEIS.EnergyProgramme.Web
{
    public class Class
    {

        public void test()
        {
            var services = new ServiceCollection(); //1
            services.AddTransient<IMyService, MyService>(); //2
            services.AddTransient<IRepository, MyRepo>(); //2
            var serviceProvider = services.BuildServiceProvider(); // compiles the fluent syntax into a dictionary
            var userMyService = serviceProvider.GetService<IMyService>(); //singular

            //IDictionary<Type, Type> serviceCollection = new Dictionary<Type, Type>(); //1
            //serviceCollection.Add(typeof(IMyService), typeof(MyService)); // 2
            //
            //var myService = Activator.CreateInstance(serviceCollection[typeof(IMyService)]);           


        }

    }
}
