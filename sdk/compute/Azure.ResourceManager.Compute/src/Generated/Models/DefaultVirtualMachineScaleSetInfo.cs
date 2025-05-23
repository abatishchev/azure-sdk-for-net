// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Indicates the target Virtual Machine ScaleSet properties upon triggering a seamless migration without downtime of the VMs via the ConvertToVirtualMachineScaleSet API. </summary>
    public partial class DefaultVirtualMachineScaleSetInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DefaultVirtualMachineScaleSetInfo"/>. </summary>
        internal DefaultVirtualMachineScaleSetInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DefaultVirtualMachineScaleSetInfo"/>. </summary>
        /// <param name="constrainedMaximumCapacity"> Indicates if the the maximum capacity of the default migrated Virtual Machine Scale Set after its migration will be constrained to a limited number of VMs. </param>
        /// <param name="defaultVirtualMachineScaleSet"> The default Virtual Machine ScaleSet Uri that the Availability Set will be moved to upon triggering a seamless migration via the ConvertToVirtualMachineScaleSet API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DefaultVirtualMachineScaleSetInfo(bool? constrainedMaximumCapacity, WritableSubResource defaultVirtualMachineScaleSet, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ConstrainedMaximumCapacity = constrainedMaximumCapacity;
            DefaultVirtualMachineScaleSet = defaultVirtualMachineScaleSet;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates if the the maximum capacity of the default migrated Virtual Machine Scale Set after its migration will be constrained to a limited number of VMs. </summary>
        public bool? ConstrainedMaximumCapacity { get; }
        /// <summary> The default Virtual Machine ScaleSet Uri that the Availability Set will be moved to upon triggering a seamless migration via the ConvertToVirtualMachineScaleSet API. </summary>
        internal WritableSubResource DefaultVirtualMachineScaleSet { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DefaultVirtualMachineScaleSetId
        {
            get => DefaultVirtualMachineScaleSet?.Id;
        }
    }
}
