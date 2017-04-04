// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Service health policy
    /// </summary>
    public partial class ServiceTypeDeltaHealthPolicy
    {
        /// <summary>
        /// Initializes a new instance of the ServiceTypeDeltaHealthPolicy
        /// class.
        /// </summary>
        public ServiceTypeDeltaHealthPolicy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceTypeDeltaHealthPolicy
        /// class.
        /// </summary>
        /// <param name="maxPercentDeltaUnhealthyServices">Maximum percentage
        /// of unhealthy services in cluster</param>
        public ServiceTypeDeltaHealthPolicy(int? maxPercentDeltaUnhealthyServices = default(int?))
        {
            MaxPercentDeltaUnhealthyServices = maxPercentDeltaUnhealthyServices;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets maximum percentage of unhealthy services in cluster
        /// </summary>
        [JsonProperty(PropertyName = "maxPercentDeltaUnhealthyServices")]
        public int? MaxPercentDeltaUnhealthyServices { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxPercentDeltaUnhealthyServices > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxPercentDeltaUnhealthyServices", 100);
            }
            if (MaxPercentDeltaUnhealthyServices < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxPercentDeltaUnhealthyServices", 0);
            }
        }
    }
}
