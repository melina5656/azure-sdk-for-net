// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AzureResourceManagerGallery.Models
{
    /// <summary> A custom action that can be performed with a Gallery Application Version. </summary>
    public partial class GalleryApplicationCustomAction
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

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationCustomAction"/>. </summary>
        /// <param name="name"> The name of the custom action.  Must be unique within the Gallery Application Version. </param>
        /// <param name="script"> The script to run when executing this custom action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="script"/> is null. </exception>
        public GalleryApplicationCustomAction(string name, string script)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(script, nameof(script));

            Name = name;
            Script = script;
            Parameters = new ChangeTrackingList<GalleryApplicationCustomActionParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationCustomAction"/>. </summary>
        /// <param name="name"> The name of the custom action.  Must be unique within the Gallery Application Version. </param>
        /// <param name="script"> The script to run when executing this custom action. </param>
        /// <param name="description"> Description to help the users understand what this custom action does. </param>
        /// <param name="parameters"> The parameters that this custom action uses. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GalleryApplicationCustomAction(string name, string script, string description, IList<GalleryApplicationCustomActionParameter> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Script = script;
            Description = description;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GalleryApplicationCustomAction"/> for deserialization. </summary>
        internal GalleryApplicationCustomAction()
        {
        }

        /// <summary> The name of the custom action.  Must be unique within the Gallery Application Version. </summary>
        public string Name { get; set; }
        /// <summary> The script to run when executing this custom action. </summary>
        public string Script { get; set; }
        /// <summary> Description to help the users understand what this custom action does. </summary>
        public string Description { get; set; }
        /// <summary> The parameters that this custom action uses. </summary>
        public IList<GalleryApplicationCustomActionParameter> Parameters { get; }
    }
}
