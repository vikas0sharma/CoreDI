using Contracts.Services;
using DependencyResolver;
using System.ComponentModel.Composition;

namespace Services
{
    [Export(typeof(IDependencyResolver))]
    public class LabelServiceResolver : IDependencyResolver
    {
        public void SetUp(IDependencyRegister dependencyRegister)
        {
            dependencyRegister.AddTransient<ILabelService, LabelService>();
        }
    }
}
