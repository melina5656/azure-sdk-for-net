// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings. </summary>
    public partial class WindowsVmGuestPatchAutomaticByPlatformSettings
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

        /// <summary> Initializes a new instance of <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/>. </summary>
        public WindowsVmGuestPatchAutomaticByPlatformSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WindowsVmGuestPatchAutomaticByPlatformSettings"/>. </summary>
        /// <param name="rebootSetting"> Specifies the reboot setting for all AutomaticByPlatform patch installation operations. </param>
        /// <param name="bypassPlatformSafetyChecksOnUserSchedule"> Enables customer to schedule patching without accidental upgrades. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WindowsVmGuestPatchAutomaticByPlatformSettings(WindowsVmGuestPatchAutomaticByPlatformRebootSetting? rebootSetting, bool? bypassPlatformSafetyChecksOnUserSchedule, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RebootSetting = rebootSetting;
            BypassPlatformSafetyChecksOnUserSchedule = bypassPlatformSafetyChecksOnUserSchedule;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the reboot setting for all AutomaticByPlatform patch installation operations. </summary>
        public WindowsVmGuestPatchAutomaticByPlatformRebootSetting? RebootSetting { get; set; }
        /// <summary> Enables customer to schedule patching without accidental upgrades. </summary>
        public bool? BypassPlatformSafetyChecksOnUserSchedule { get; set; }
    }
}
