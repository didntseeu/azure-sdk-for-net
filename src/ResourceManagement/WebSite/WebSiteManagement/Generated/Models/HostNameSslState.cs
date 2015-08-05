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
    /// Object that represents a SSL-enabled host name.
    /// </summary>
    public partial class HostNameSslState
    {
        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// SSL type. Possible values for this property include: 'Disabled',
        /// 'SniEnabled', 'IpBasedEnabled'
        /// </summary>
        [JsonProperty(PropertyName = "sslState")]
        public string SslState { get; set; }

        /// <summary>
        /// Virtual IP address assigned to the host name if IP based SSL is
        /// enabled
        /// </summary>
        [JsonProperty(PropertyName = "virtualIP")]
        public string VirtualIP { get; set; }

        /// <summary>
        /// SSL cert thumbprint
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Set this flag to update existing host name
        /// </summary>
        [JsonProperty(PropertyName = "toUpdate")]
        public bool? ToUpdate { get; set; }

        /// <summary>
        /// Set this flag to update existing host name
        /// </summary>
        [JsonProperty(PropertyName = "toUpdateIpBasedSsl")]
        public bool? ToUpdateIpBasedSsl { get; set; }

    }
}
