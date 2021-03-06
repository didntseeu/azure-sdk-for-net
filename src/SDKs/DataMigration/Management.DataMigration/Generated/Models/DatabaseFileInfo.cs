// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Database file specific information
    /// </summary>
    public partial class DatabaseFileInfo
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseFileInfo class.
        /// </summary>
        public DatabaseFileInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseFileInfo class.
        /// </summary>
        /// <param name="databaseName">Name of the database</param>
        /// <param name="id">Unique identifier for database file</param>
        /// <param name="logicalName">Logical name of the file</param>
        /// <param name="physicalFullName">Operating-system full path of the
        /// file</param>
        /// <param name="restoreFullName">Suggested full path of the file for
        /// restoring</param>
        /// <param name="fileType">Database file type. Possible values include:
        /// 'Rows', 'Log', 'Filestream', 'NotSupported', 'Fulltext'</param>
        /// <param name="sizeMB">Size of the file in megabytes</param>
        public DatabaseFileInfo(string databaseName = default(string), string id = default(string), string logicalName = default(string), string physicalFullName = default(string), string restoreFullName = default(string), string fileType = default(string), double? sizeMB = default(double?))
        {
            DatabaseName = databaseName;
            Id = id;
            LogicalName = logicalName;
            PhysicalFullName = physicalFullName;
            RestoreFullName = restoreFullName;
            FileType = fileType;
            SizeMB = sizeMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the database
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for database file
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets logical name of the file
        /// </summary>
        [JsonProperty(PropertyName = "logicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// Gets or sets operating-system full path of the file
        /// </summary>
        [JsonProperty(PropertyName = "physicalFullName")]
        public string PhysicalFullName { get; set; }

        /// <summary>
        /// Gets or sets suggested full path of the file for restoring
        /// </summary>
        [JsonProperty(PropertyName = "restoreFullName")]
        public string RestoreFullName { get; set; }

        /// <summary>
        /// Gets or sets database file type. Possible values include: 'Rows',
        /// 'Log', 'Filestream', 'NotSupported', 'Fulltext'
        /// </summary>
        [JsonProperty(PropertyName = "fileType")]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or sets size of the file in megabytes
        /// </summary>
        [JsonProperty(PropertyName = "sizeMB")]
        public double? SizeMB { get; set; }

    }
}
