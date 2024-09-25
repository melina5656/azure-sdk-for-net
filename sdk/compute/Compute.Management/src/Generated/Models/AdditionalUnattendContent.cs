// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Compute.Management.Models
{
    /// <summary> Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied. </summary>
    public partial class AdditionalUnattendContent
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

        /// <summary> Initializes a new instance of <see cref="AdditionalUnattendContent"/>. </summary>
        public AdditionalUnattendContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalUnattendContent"/>. </summary>
        /// <param name="passName"> The pass name. Currently, the only allowable value is OobeSystem. </param>
        /// <param name="componentName"> The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup. </param>
        /// <param name="settingName"> Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon. </param>
        /// <param name="content"> Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdditionalUnattendContent(PassName? passName, ComponentName? componentName, SettingName? settingName, string content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PassName = passName;
            ComponentName = componentName;
            SettingName = settingName;
            Content = content;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The pass name. Currently, the only allowable value is OobeSystem. </summary>
        public PassName? PassName { get; set; }
        /// <summary> The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup. </summary>
        public ComponentName? ComponentName { get; set; }
        /// <summary> Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon. </summary>
        public SettingName? SettingName { get; set; }
        /// <summary> Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted. </summary>
        public string Content { get; set; }
    }
}
