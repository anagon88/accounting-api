using Accounting.DataAccess.Repositories;
using Accounting.DataAccess.Repositories.Interfaces;
using Accounting.Services;
using Accounting.Services.Interfaces;
using Unity;
using Unity.Resolution;

namespace Accounting.Unity
{
    /// <summary>
    /// configures unity mappings
    /// </summary>
    public static class UnityConfig
    {
        private static IUnityContainer _container;

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        /// <returns>the unity container</returns>
        public static IUnityContainer GetConfiguredContainer()
        {
            if (_container == null)
            {
                _container = new UnityContainer();
                RegisterTypes(_container);
            }

            return _container;
        }

        public static T Resolve<T>(params ResolverOverride[] overrides)
        {
            GetConfiguredContainer();
            return _container.Resolve<T>(overrides);
        }

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ITransactionService, TransactionService>();
            container.RegisterType<IFinancialAccountService, FinancialAccountService>();
            container.RegisterType<ITransactionRepository, TransactionRepository>();
            container.RegisterType<IFinancialAccountRepository, FinancialAccountRepository>();
        }
    }
}