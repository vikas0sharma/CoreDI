namespace DependencyResolver
{
    public interface IDependencyResolver
    {
        void SetUp(IDependencyRegister dependencyRegister);
    }
}
