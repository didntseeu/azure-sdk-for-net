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
    /// Domain registration input for validation Api
    /// </summary>
    public partial class DomainRegistrationInput : Resource
    {
        /// <summary>
        /// Name of the domain
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string DomainRegistrationInputName { get; set; }

        /// <summary>
        /// Admin contact information
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactAdmin")]
        public Contact ContactAdmin { get; set; }

        /// <summary>
        /// Billing contact information
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactBilling")]
        public Contact ContactBilling { get; set; }

        /// <summary>
        /// Registrant contact information
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactRegistrant")]
        public Contact ContactRegistrant { get; set; }

        /// <summary>
        /// Technical contact information
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactTech")]
        public Contact ContactTech { get; set; }

        /// <summary>
        /// Domain registration status. Possible values for this property
        /// include: 'Active', 'Awaiting', 'Cancelled', 'Confiscated',
        /// 'Disabled', 'Excluded', 'Expired', 'Failed', 'Held', 'Locked',
        /// 'Parked', 'Pending', 'Reserved', 'Reverted', 'Suspended',
        /// 'Transferred', 'Unknown', 'Unlocked', 'Unparked', 'Updated',
        /// 'JsonConverterFailed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationStatus")]
        public string RegistrationStatus { get; set; }

        /// <summary>
        /// Name servers
        /// </summary>
        [JsonProperty(PropertyName = "properties.nameServers")]
        public IList<string> NameServers { get; set; }

        /// <summary>
        /// If true then domain privacy is enabled for this domain
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacy")]
        public bool? Privacy { get; set; }

        /// <summary>
        /// Domain creation timestamp
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Domain expiration timestamp
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Timestamp when the domain was renewed last time
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastRenewedTime")]
        public DateTime? LastRenewedTime { get; set; }

        /// <summary>
        /// If true then domain will renewed automatically
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoRenew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// If true then Azure can assign this domain to Web Apps. This value
        /// will be true if domain registration status is active and it is
        /// hosted on name servers Azure has programmatic access to
        /// </summary>
        [JsonProperty(PropertyName = "properties.readyForDnsRecordManagement")]
        public bool? ReadyForDnsRecordManagement { get; set; }

        /// <summary>
        /// All hostnames derived from the domain and assigned to Azure
        /// resources
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedHostNames")]
        public IList<HostName> ManagedHostNames { get; set; }

        /// <summary>
        /// Legal agreement consent
        /// </summary>
        [JsonProperty(PropertyName = "properties.consent")]
        public DomainPurchaseConsent Consent { get; set; }

    }
}
