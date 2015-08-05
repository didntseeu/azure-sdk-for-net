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
    /// Description of a backup schedule. Describes how often should be the
    /// backup performed and what should be the retention policy.
    /// </summary>
    public partial class BackupSchedule
    {
        /// <summary>
        /// How often should be the backup executed (e.g. for weekly backup,
        /// this should be set to 7 and FrequencyUnit should be set to Day)
        /// </summary>
        [JsonProperty(PropertyName = "frequencyInterval")]
        public int? FrequencyInterval { get; set; }

        /// <summary>
        /// How often should be the backup executed (e.g. for weekly backup,
        /// this should be set to Day and FrequencyInterval should be set to
        /// 7). Possible values for this property include: 'Day', 'Hour'
        /// </summary>
        [JsonProperty(PropertyName = "frequencyUnit")]
        public string FrequencyUnit { get; set; }

        /// <summary>
        /// True if the retention policy should always keep at least one
        /// backup in the storage account, regardless how old it is; false
        /// otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "keepAtLeastOneBackup")]
        public bool? KeepAtLeastOneBackup { get; set; }

        /// <summary>
        /// After how many days backups should be deleted
        /// </summary>
        [JsonProperty(PropertyName = "retentionPeriodInDays")]
        public int? RetentionPeriodInDays { get; set; }

        /// <summary>
        /// When the schedule should start working
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// The last time when this schedule was triggered
        /// </summary>
        [JsonProperty(PropertyName = "lastExecutionTime")]
        public DateTime? LastExecutionTime { get; set; }

    }
}
