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
    /// Collection of csm usage quotas
    /// </summary>
    public partial class CsmUsageQuotaCollection
    {
        /// <summary>
        /// Collection of resources
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<CsmUsageQuota> Value { get; set; }

        /// <summary>
        /// Link to next page of resources
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
