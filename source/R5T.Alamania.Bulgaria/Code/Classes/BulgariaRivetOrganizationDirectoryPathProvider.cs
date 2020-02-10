using System;

using R5T.Bulgaria;
using R5T.Costobocia;
using R5T.Ostrogothia.Rivet;


namespace R5T.Alamania.Bulgaria
{
    /// <summary>
    /// Provides the Rivet organization directory path from the Dropbox directory path (provided by the codenamed Bulgaria project).
    /// </summary>
    public class BulgariaRivetOrganizationDirectoryPathProvider : IRivetOrganizationDirectoryPathProvider
    {
        public IDropboxDirectoryPathProvider DropboxDirectoryPathProvider { get; }
        public IOrganizationStringlyTypedPathOperator OrganizationStringlyTypedPathOperator { get; }


        public BulgariaRivetOrganizationDirectoryPathProvider(
            IDropboxDirectoryPathProvider dropboxDirectoryPathProvider,
            IOrganizationStringlyTypedPathOperator organizationStringlyTypedPathOperator)
        {
            this.DropboxDirectoryPathProvider = dropboxDirectoryPathProvider;
            this.OrganizationStringlyTypedPathOperator = organizationStringlyTypedPathOperator;
        }

        public string GetRivetOrganizationDirectoryPath()
        {
            var dropboxDirectoryPath = this.DropboxDirectoryPathProvider.GetDropboxDirectoryPath();

            var rivetOrganizationDropboxDirectoryPath = this.OrganizationStringlyTypedPathOperator.GetOrganizationDirectoryPath(dropboxDirectoryPath, RivetOrganization.Instance.Value);
            return rivetOrganizationDropboxDirectoryPath;
        }
    }
}
