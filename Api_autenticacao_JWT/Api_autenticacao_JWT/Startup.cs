namespace Api_autenticacao_JWT
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //DbContext
            services.AddDbContext<DataContext>();
        }
    }
}
