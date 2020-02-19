using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria;
using R5T.Costobocia;
using R5T.Dacia;


namespace R5T.Alamania.Bulgaria
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="BulgariaRivetOrganizationDirectoryPathProvider"/> implementation of <see cref="IRivetOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddBulgariaRivetOrganizationDirectoryPathProvider(this IServiceCollection services,
            ServiceAction<IDropboxDirectoryPathProvider> addDropboxDirectoryPathProvider,
            ServiceAction<IOrganizationStringlyTypedPathOperator> addOrganizationStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IRivetOrganizationDirectoryPathProvider, BulgariaRivetOrganizationDirectoryPathProvider>()
                .RunServiceAction(addDropboxDirectoryPathProvider)
                .RunServiceAction(addOrganizationStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="BulgariaRivetOrganizationDirectoryPathProvider"/> implementation of <see cref="IRivetOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IRivetOrganizationDirectoryPathProvider> AddBulgariaRivetOrganizationDirectoryPathProviderAction(this IServiceCollection services,
            ServiceAction<IDropboxDirectoryPathProvider> addDropboxDirectoryPathProvider,
            ServiceAction<IOrganizationStringlyTypedPathOperator> addOrganizationStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IRivetOrganizationDirectoryPathProvider>(() => services.AddBulgariaRivetOrganizationDirectoryPathProvider(
                addDropboxDirectoryPathProvider,
                addOrganizationStringlyTypedPathOperator));
            return serviceAction;
        }
    }
}
