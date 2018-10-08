using Ninject;

using SportsStore.Domain.Abstract;
using SportsStore.Domain.Concrete;
using SportsStore.Infrastructure.Abstract;
using SportsStore.Infrastructure.Concrete;

using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SportsStore.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            this.kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return this.kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //TODO                       
            this.kernel.Bind<IProductsRepository>().To<EFProductRepository>();
            EmailSettings emailSettings = new EmailSettings();          
            this.kernel.Bind<IOrderProcessor>().To<EmailOrderProcessor>().WithConstructorArgument("settings",emailSettings);
            this.kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}