// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the AdaptiveApplicationControlGroup data model. </summary>
    public partial class AdaptiveApplicationControlGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AdaptiveApplicationControlGroupData"/>. </summary>
        public AdaptiveApplicationControlGroupData()
        {
            Issues = new ChangeTrackingList<AdaptiveApplicationControlIssueSummary>();
            VmRecommendations = new ChangeTrackingList<VmRecommendation>();
            PathRecommendations = new ChangeTrackingList<PathRecommendation>();
        }

        /// <summary> Initializes a new instance of <see cref="AdaptiveApplicationControlGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="enforcementMode"> The application control policy enforcement/protection mode of the machine group. </param>
        /// <param name="protectionMode"> The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux. </param>
        /// <param name="configurationStatus"> The configuration status of the machines group or machine or rule. </param>
        /// <param name="recommendationStatus"> The initial recommendation status of the machine group or machine. </param>
        /// <param name="issues"></param>
        /// <param name="sourceSystem"> The source type of the machine group. </param>
        /// <param name="vmRecommendations"></param>
        /// <param name="pathRecommendations"></param>
        /// <param name="location"> Location where the resource is stored. </param>
        internal AdaptiveApplicationControlGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AdaptiveApplicationControlEnforcementMode? enforcementMode, SecurityCenterFileProtectionMode protectionMode, SecurityCenterConfigurationStatus? configurationStatus, RecommendationStatus? recommendationStatus, IReadOnlyList<AdaptiveApplicationControlIssueSummary> issues, AdaptiveApplicationControlGroupSourceSystem? sourceSystem, IList<VmRecommendation> vmRecommendations, IList<PathRecommendation> pathRecommendations, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            EnforcementMode = enforcementMode;
            ProtectionMode = protectionMode;
            ConfigurationStatus = configurationStatus;
            RecommendationStatus = recommendationStatus;
            Issues = issues;
            SourceSystem = sourceSystem;
            VmRecommendations = vmRecommendations;
            PathRecommendations = pathRecommendations;
            Location = location;
        }

        /// <summary> The application control policy enforcement/protection mode of the machine group. </summary>
        public AdaptiveApplicationControlEnforcementMode? EnforcementMode { get; set; }
        /// <summary> The protection mode of the collection/file types. Exe/Msi/Script are used for Windows, Executable is used for Linux. </summary>
        public SecurityCenterFileProtectionMode ProtectionMode { get; set; }
        /// <summary> The configuration status of the machines group or machine or rule. </summary>
        public SecurityCenterConfigurationStatus? ConfigurationStatus { get; }
        /// <summary> The initial recommendation status of the machine group or machine. </summary>
        public RecommendationStatus? RecommendationStatus { get; }
        /// <summary> Gets the issues. </summary>
        public IReadOnlyList<AdaptiveApplicationControlIssueSummary> Issues { get; }
        /// <summary> The source type of the machine group. </summary>
        public AdaptiveApplicationControlGroupSourceSystem? SourceSystem { get; }
        /// <summary> Gets the vm recommendations. </summary>
        public IList<VmRecommendation> VmRecommendations { get; }
        /// <summary> Gets the path recommendations. </summary>
        public IList<PathRecommendation> PathRecommendations { get; }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
