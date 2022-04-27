using System;

using R5T.Bulgaria;
using R5T.Costobocia;
using R5T.Ostrogothia.Rivet;

using R5T.T0064;


namespace R5T.Alamania.Bulgaria
{
    /// <summary>
    /// Provides the Rivet organization directory path from the Dropbox directory path (provided by the codenamed Bulgaria project).
    /// </summary>
    [ServiceImplementationMarker]
    public class RivetOrganizationDirectoryPathProvider : IRivetOrganizationDirectoryPathProvider, IServiceImplementation
    {
        private IDropboxDirectoryPathProvider DropboxDirectoryPathProvider { get; }
        private IOrganizationStringlyTypedPathOperator OrganizationStringlyTypedPathOperator { get; }


        public RivetOrganizationDirectoryPathProvider(
            IDropboxDirectoryPathProvider dropboxDirectoryPathProvider,
            IOrganizationStringlyTypedPathOperator organizationStringlyTypedPathOperator)
        {
            this.DropboxDirectoryPathProvider = dropboxDirectoryPathProvider;
            this.OrganizationStringlyTypedPathOperator = organizationStringlyTypedPathOperator;
        }

        public string GetRivetOrganizationDirectoryPath()
        {
            var dropboxDirectoryPath = this.DropboxDirectoryPathProvider.GetDropboxDirectoryPath();

            var rivetOrganizationDropboxDirectoryPath = this.OrganizationStringlyTypedPathOperator.GetOrganizationDirectoryPath(dropboxDirectoryPath, RivetOrganization.Instance);
            return rivetOrganizationDropboxDirectoryPath;
        }
    }
}
