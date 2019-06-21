// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PolicyInsights_2018_04.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Policy definition summary.
    /// </summary>
    public partial class PolicyDefinitionSummary
    {
        /// <summary>
        /// Initializes a new instance of the PolicyDefinitionSummary class.
        /// </summary>
        public PolicyDefinitionSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyDefinitionSummary class.
        /// </summary>
        /// <param name="policyDefinitionId">Policy definition ID.</param>
        /// <param name="policyDefinitionReferenceId">Policy definition
        /// reference ID.</param>
        /// <param name="effect">Policy effect, i.e. policy definition
        /// action.</param>
        /// <param name="results">Non-compliance summary for the policy
        /// definition.</param>
        public PolicyDefinitionSummary(string policyDefinitionId = default(string), string policyDefinitionReferenceId = default(string), string effect = default(string), SummaryResults results = default(SummaryResults))
        {
            PolicyDefinitionId = policyDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            Effect = effect;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets policy definition ID.
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitionId")]
        public string PolicyDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets policy definition reference ID.
        /// </summary>
        [JsonProperty(PropertyName = "policyDefinitionReferenceId")]
        public string PolicyDefinitionReferenceId { get; set; }

        /// <summary>
        /// Gets or sets policy effect, i.e. policy definition action.
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        /// <summary>
        /// Gets or sets non-compliance summary for the policy definition.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public SummaryResults Results { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Results != null)
            {
                Results.Validate();
            }
        }
    }
}
