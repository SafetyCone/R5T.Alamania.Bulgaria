using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bulgaria;
using R5T.Costobocia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Alamania.Bulgaria
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="RivetOrganizationDirectoryPathProvider"/> implementation of <see cref="IRivetOrganizationDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRivetOrganizationDirectoryPathProvider> AddRivetOrganizationDirectoryPathProviderAction(this IServiceAction _,
            IServiceAction<IDropboxDirectoryPathProvider> dropboxDirectoryPathProviderAction,
            IServiceAction<IOrganizationStringlyTypedPathOperator> organizationStringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IRivetOrganizationDirectoryPathProvider>(services => services.AddRivetOrganizationDirectoryPathProvider(
                dropboxDirectoryPathProviderAction,
                organizationStringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
