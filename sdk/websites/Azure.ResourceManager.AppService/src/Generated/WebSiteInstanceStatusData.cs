// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the WebSiteInstanceStatus data model. </summary>
    public partial class WebSiteInstanceStatusData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="WebSiteInstanceStatusData"/>. </summary>
        public WebSiteInstanceStatusData()
        {
            Containers = new ChangeTrackingDictionary<string, ContainerInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="WebSiteInstanceStatusData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"></param>
        /// <param name="statusUri"> Link to the GetStatusApi in Kudu. </param>
        /// <param name="detectorUri"> Link to the Diagnose and Solve Portal. </param>
        /// <param name="consoleUri"> Link to the console to web app instance. </param>
        /// <param name="healthCheckUrlString"> Link to the console to web app instance. </param>
        /// <param name="containers"> Dictionary of &lt;ContainerInfo&gt;. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal WebSiteInstanceStatusData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRuntimeState? state, Uri statusUri, Uri detectorUri, Uri consoleUri, string healthCheckUrlString, IDictionary<string, ContainerInfo> containers, string kind) : base(id, name, resourceType, systemData)
        {
            State = state;
            StatusUri = statusUri;
            DetectorUri = detectorUri;
            ConsoleUri = consoleUri;
            HealthCheckUrlString = healthCheckUrlString;
            Containers = containers;
            Kind = kind;
        }

        /// <summary> Gets or sets the state. </summary>
        public SiteRuntimeState? State { get; set; }
        /// <summary> Link to the GetStatusApi in Kudu. </summary>
        public Uri StatusUri { get; set; }
        /// <summary> Link to the Diagnose and Solve Portal. </summary>
        public Uri DetectorUri { get; set; }
        /// <summary> Link to the console to web app instance. </summary>
        public Uri ConsoleUri { get; set; }
        /// <summary> Link to the console to web app instance. </summary>
        public string HealthCheckUrlString { get; set; }
        /// <summary> Dictionary of &lt;ContainerInfo&gt;. </summary>
        public IDictionary<string, ContainerInfo> Containers { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
