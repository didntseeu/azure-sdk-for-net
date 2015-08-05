// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Http logs configuration
    /// </summary>
    public partial class HttpLogsConfig
    {
        /// <summary>
        /// Http logs to file system configuration
        /// </summary>
        [JsonProperty(PropertyName = "fileSystem")]
        public FileSystemHttpLogsConfig FileSystem { get; set; }

        /// <summary>
        /// Http logs to azure blob storage configuration
        /// </summary>
        [JsonProperty(PropertyName = "azureBlobStorage")]
        public AzureBlobStorageHttpLogsConfig AzureBlobStorage { get; set; }

    }
}
