namespace DependencyResolver
{
    public interface IDependencyRegister
    {
        void AddTransient<TFrom, TTo>() where TTo : class, TFrom where TFrom : class;
        void AddScoped<TFrom, TTo>() where TTo : class, TFrom where TFrom : class;
        void AddScopedForMultiImplementation<TFrom, TTo>() where TTo : class, TFrom where TFrom : class;
    }
}
