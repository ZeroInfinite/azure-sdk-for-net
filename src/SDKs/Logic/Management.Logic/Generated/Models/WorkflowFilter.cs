// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow filter.
    /// </summary>
    public partial class WorkflowFilter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowFilter class.
        /// </summary>
        public WorkflowFilter() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowFilter class.
        /// </summary>
        /// <param name="state">The state of workflows. Possible values
        /// include: 'NotSpecified', 'Completed', 'Enabled', 'Disabled',
        /// 'Deleted', 'Suspended'</param>
        public WorkflowFilter(WorkflowState? state = default(WorkflowState?))
        {
            State = state;
        }

        /// <summary>
        /// Gets or sets the state of workflows. Possible values include:
        /// 'NotSpecified', 'Completed', 'Enabled', 'Disabled', 'Deleted',
        /// 'Suspended'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public WorkflowState? State { get; set; }

    }
}

