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
    /// Instance of a web app
    /// </summary>
    public partial class SiteInstance : Resource
    {
        /// <summary>
        /// Name of instance
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string SiteInstanceName { get; set; }

    }
}
