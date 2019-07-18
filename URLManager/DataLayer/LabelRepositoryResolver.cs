using Contracts.Repository;
using DependencyResolver;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;

namespace DataLayer
{
    [Export(typeof(IDependencyResolver))]
    public class LabelRepositoryResolver : IDependencyResolver
    {
        public void SetUp(IDependencyRegister dependencyRegister)
        {
            dependencyRegister.AddScoped<ILabelRepository, LabelRepository>();
        }
    }
}
