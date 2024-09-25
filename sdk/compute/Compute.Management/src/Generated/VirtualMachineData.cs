// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Compute.Management.Models;

namespace Compute.Management
{
    /// <summary>
    /// A class representing the VirtualMachine data model.
    /// Describes a Virtual Machine.
    /// </summary>
    public partial class VirtualMachineData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineData"/>. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineData(AzureLocation location) : base(location)
        {
            Resources = new ChangeTrackingList<VirtualMachineExtensionData>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="resources"> The virtual machine child extension resources. </param>
        /// <param name="identity"> The identity of the virtual machine, if configured. </param>
        /// <param name="zones"> The virtual machine zones. </param>
        /// <param name="extendedLocation"> The extended location of the Virtual Machine. </param>
        /// <param name="managedBy"> ManagedBy is set to Virtual Machine Scale Set(VMSS) flex ARM resourceID, if the VM is part of the VMSS. This property is used by platform for internal resource group delete optimization. </param>
        /// <param name="etag"> Etag is property returned in Create/Update/Get response of the VM, so that customer can supply it in the header to ensure optimistic updates. </param>
        /// <param name="hardwareProfile"> Specifies the hardware settings for the virtual machine. </param>
        /// <param name="scheduledEventsPolicy"> Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations for the virtual machine. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="additionalCapabilities"> Specifies additional capabilities enabled or disabled on the virtual machine. </param>
        /// <param name="osProfile"> Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot be changed once VM is provisioned. </param>
        /// <param name="networkProfile"> Specifies the network interfaces of the virtual machine. </param>
        /// <param name="securityProfile"> Specifies the Security related profile settings for the virtual machine. </param>
        /// <param name="diagnosticsProfile"> Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15. </param>
        /// <param name="availabilitySet"> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Availability sets overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being added should be under the same resource group as the availability set resource. An existing VM cannot be added to an availability set. This property cannot exist along with a non-null properties.virtualMachineScaleSet reference. </param>
        /// <param name="virtualMachineScaleSet"> Specifies information about the virtual machine scale set that the virtual machine should be assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM cannot be added to a virtual machine scale set. This property cannot exist along with a non-null properties.availabilitySet reference. Minimum api‐version: 2019‐03‐01. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the virtual machine should be assigned to. Minimum api-version: 2018-04-01. </param>
        /// <param name="priority"> Specifies the priority for the virtual machine. Minimum api-version: 2019-03-01. </param>
        /// <param name="evictionPolicy"> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview. </param>
        /// <param name="billingProfile"> Specifies the billing related details of a Azure Spot virtual machine. Minimum api-version: 2019-03-01. </param>
        /// <param name="host"> Specifies information about the dedicated host that the virtual machine resides in. Minimum api-version: 2018-10-01. </param>
        /// <param name="hostGroup"> Specifies information about the dedicated host group that the virtual machine resides in. **Note:** User cannot specify both host and hostGroup properties. Minimum api-version: 2020-06-01. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="instanceView"> The virtual machine instance view. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="vmId"> Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands. </param>
        /// <param name="extensionsTimeBudget"> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). Minimum api-version: 2020-06-01. </param>
        /// <param name="platformFaultDomain"> Specifies the scale set logical fault domain into which the Virtual Machine will be created. By default, the Virtual Machine will by automatically assigned to a fault domain that best maintains balance across available fault domains. This is applicable only if the 'virtualMachineScaleSet' property of this Virtual Machine is set. The Virtual Machine Scale Set that is referenced, must have 'platformFaultDomainCount' greater than 1. This property cannot be updated once the Virtual Machine is created. Fault domain assignment can be viewed in the Virtual Machine Instance View. Minimum api‐version: 2020‐12‐01. </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        /// <param name="userData"> UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here. Minimum api-version: 2021-03-01. </param>
        /// <param name="capacityReservation"> Specifies information about the capacity reservation that is used to allocate virtual machine. Minimum api-version: 2021-04-01. </param>
        /// <param name="applicationProfile"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        /// <param name="timeCreated"> Specifies the time at which the Virtual Machine resource was created. Minimum api-version: 2021-11-01. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ComputeManagementPlan plan, IReadOnlyList<VirtualMachineExtensionData> resources, ManagedServiceIdentity identity, IList<string> zones, ExtendedLocation extendedLocation, string managedBy, string etag, VirtualMachineHardwareProfile hardwareProfile, ScheduledEventsPolicy scheduledEventsPolicy, VirtualMachineStorageProfile storageProfile, AdditionalCapabilities additionalCapabilities, VirtualMachineOSProfile osProfile, VirtualMachineNetworkProfile networkProfile, SecurityProfile securityProfile, DiagnosticsProfile diagnosticsProfile, WritableSubResource availabilitySet, WritableSubResource virtualMachineScaleSet, WritableSubResource proximityPlacementGroup, VirtualMachinePriorityType? priority, VirtualMachineEvictionPolicyType? evictionPolicy, BillingProfile billingProfile, WritableSubResource host, WritableSubResource hostGroup, string provisioningState, VirtualMachineInstanceView instanceView, string licenseType, string vmId, string extensionsTimeBudget, int? platformFaultDomain, ComputeScheduledEventsProfile scheduledEventsProfile, string userData, CapacityReservationProfile capacityReservation, ApplicationProfile applicationProfile, DateTimeOffset? timeCreated, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Plan = plan;
            Resources = resources;
            Identity = identity;
            Zones = zones;
            ExtendedLocation = extendedLocation;
            ManagedBy = managedBy;
            ETag = etag;
            HardwareProfile = hardwareProfile;
            ScheduledEventsPolicy = scheduledEventsPolicy;
            StorageProfile = storageProfile;
            AdditionalCapabilities = additionalCapabilities;
            OSProfile = osProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            VirtualMachineScaleSet = virtualMachineScaleSet;
            ProximityPlacementGroup = proximityPlacementGroup;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            Host = host;
            HostGroup = hostGroup;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            LicenseType = licenseType;
            VmId = vmId;
            ExtensionsTimeBudget = extensionsTimeBudget;
            PlatformFaultDomain = platformFaultDomain;
            ScheduledEventsProfile = scheduledEventsProfile;
            UserData = userData;
            CapacityReservation = capacityReservation;
            ApplicationProfile = applicationProfile;
            TimeCreated = timeCreated;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineData"/> for deserialization. </summary>
        internal VirtualMachineData()
        {
        }

        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public ComputeManagementPlan Plan { get; set; }
        /// <summary> The virtual machine child extension resources. </summary>
        public IReadOnlyList<VirtualMachineExtensionData> Resources { get; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The virtual machine zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> The extended location of the Virtual Machine. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> ManagedBy is set to Virtual Machine Scale Set(VMSS) flex ARM resourceID, if the VM is part of the VMSS. This property is used by platform for internal resource group delete optimization. </summary>
        public string ManagedBy { get; }
        /// <summary> Etag is property returned in Create/Update/Get response of the VM, so that customer can supply it in the header to ensure optimistic updates. </summary>
        public string ETag { get; }
        /// <summary> Specifies the hardware settings for the virtual machine. </summary>
        public VirtualMachineHardwareProfile HardwareProfile { get; set; }
        /// <summary> Specifies Redeploy, Reboot and ScheduledEventsAdditionalPublishingTargets Scheduled Event related configurations for the virtual machine. </summary>
        public ScheduledEventsPolicy ScheduledEventsPolicy { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public VirtualMachineStorageProfile StorageProfile { get; set; }
        /// <summary> Specifies additional capabilities enabled or disabled on the virtual machine. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot be changed once VM is provisioned. </summary>
        public VirtualMachineOSProfile OSProfile { get; set; }
        /// <summary> Specifies the network interfaces of the virtual machine. </summary>
        public VirtualMachineNetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the Security related profile settings for the virtual machine. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the boot diagnostic settings state. Minimum api-version: 2015-06-15. </summary>
        internal DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. **NOTE**: If storageUri is being specified then ensure that the storage account is in the same region and subscription as the VM. You can easily view the output of your console log. Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnostics BootDiagnostics
        {
            get => DiagnosticsProfile is null ? default : DiagnosticsProfile.BootDiagnostics;
            set
            {
                if (DiagnosticsProfile is null)
                    DiagnosticsProfile = new DiagnosticsProfile();
                DiagnosticsProfile.BootDiagnostics = value;
            }
        }

        /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Availability sets overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates). Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being added should be under the same resource group as the availability set resource. An existing VM cannot be added to an availability set. This property cannot exist along with a non-null properties.virtualMachineScaleSet reference. </summary>
        internal WritableSubResource AvailabilitySet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier AvailabilitySetId
        {
            get => AvailabilitySet is null ? default : AvailabilitySet.Id;
            set
            {
                if (AvailabilitySet is null)
                    AvailabilitySet = new WritableSubResource();
                AvailabilitySet.Id = value;
            }
        }

        /// <summary> Specifies information about the virtual machine scale set that the virtual machine should be assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM cannot be added to a virtual machine scale set. This property cannot exist along with a non-null properties.availabilitySet reference. Minimum api‐version: 2019‐03‐01. </summary>
        internal WritableSubResource VirtualMachineScaleSet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualMachineScaleSetId
        {
            get => VirtualMachineScaleSet is null ? default : VirtualMachineScaleSet.Id;
            set
            {
                if (VirtualMachineScaleSet is null)
                    VirtualMachineScaleSet = new WritableSubResource();
                VirtualMachineScaleSet.Id = value;
            }
        }

        /// <summary> Specifies information about the proximity placement group that the virtual machine should be assigned to. Minimum api-version: 2018-04-01. </summary>
        internal WritableSubResource ProximityPlacementGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ProximityPlacementGroupId
        {
            get => ProximityPlacementGroup is null ? default : ProximityPlacementGroup.Id;
            set
            {
                if (ProximityPlacementGroup is null)
                    ProximityPlacementGroup = new WritableSubResource();
                ProximityPlacementGroup.Id = value;
            }
        }

        /// <summary> Specifies the priority for the virtual machine. Minimum api-version: 2019-03-01. </summary>
        public VirtualMachinePriorityType? Priority { get; set; }
        /// <summary> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview. </summary>
        public VirtualMachineEvictionPolicyType? EvictionPolicy { get; set; }
        /// <summary> Specifies the billing related details of a Azure Spot virtual machine. Minimum api-version: 2019-03-01. </summary>
        internal BillingProfile BillingProfile { get; set; }
        /// <summary> Specifies the maximum price you are willing to pay for a Azure Spot VM/VMSS. This price is in US Dollars. &lt;br&gt;&lt;br&gt; This price will be compared with the current Azure Spot price for the VM size. Also, the prices are compared at the time of create/update of Azure Spot VM/VMSS and the operation will only succeed if  the maxPrice is greater than the current Azure Spot price. &lt;br&gt;&lt;br&gt; The maxPrice will also be used for evicting a Azure Spot VM/VMSS if the current Azure Spot price goes beyond the maxPrice after creation of VM/VMSS. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; - Any decimal value greater than zero. Example: 0.01538 &lt;br&gt;&lt;br&gt; -1 – indicates default price to be up-to on-demand. &lt;br&gt;&lt;br&gt; You can set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS should not be evicted for price reasons. Also, the default max price is -1 if it is not provided by you. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public double? BillingMaxPrice
        {
            get => BillingProfile is null ? default : BillingProfile.MaxPrice;
            set
            {
                if (BillingProfile is null)
                    BillingProfile = new BillingProfile();
                BillingProfile.MaxPrice = value;
            }
        }

        /// <summary> Specifies information about the dedicated host that the virtual machine resides in. Minimum api-version: 2018-10-01. </summary>
        internal WritableSubResource Host { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HostId
        {
            get => Host is null ? default : Host.Id;
            set
            {
                if (Host is null)
                    Host = new WritableSubResource();
                Host.Id = value;
            }
        }

        /// <summary> Specifies information about the dedicated host group that the virtual machine resides in. **Note:** User cannot specify both host and hostGroup properties. Minimum api-version: 2020-06-01. </summary>
        internal WritableSubResource HostGroup { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HostGroupId
        {
            get => HostGroup is null ? default : HostGroup.Id;
            set
            {
                if (HostGroup is null)
                    HostGroup = new WritableSubResource();
                HostGroup.Id = value;
            }
        }

        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The virtual machine instance view. </summary>
        public VirtualMachineInstanceView InstanceView { get; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands. </summary>
        public string VmId { get; }
        /// <summary> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). Minimum api-version: 2020-06-01. </summary>
        public string ExtensionsTimeBudget { get; set; }
        /// <summary> Specifies the scale set logical fault domain into which the Virtual Machine will be created. By default, the Virtual Machine will by automatically assigned to a fault domain that best maintains balance across available fault domains. This is applicable only if the 'virtualMachineScaleSet' property of this Virtual Machine is set. The Virtual Machine Scale Set that is referenced, must have 'platformFaultDomainCount' greater than 1. This property cannot be updated once the Virtual Machine is created. Fault domain assignment can be viewed in the Virtual Machine Instance View. Minimum api‐version: 2020‐12‐01. </summary>
        public int? PlatformFaultDomain { get; set; }
        /// <summary> Specifies Scheduled Event related configurations. </summary>
        public ComputeScheduledEventsProfile ScheduledEventsProfile { get; set; }
        /// <summary> UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here. Minimum api-version: 2021-03-01. </summary>
        public string UserData { get; set; }
        /// <summary> Specifies information about the capacity reservation that is used to allocate virtual machine. Minimum api-version: 2021-04-01. </summary>
        internal CapacityReservationProfile CapacityReservation { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier CapacityReservationGroupId
        {
            get => CapacityReservation is null ? default : CapacityReservation.CapacityReservationGroupId;
            set
            {
                if (CapacityReservation is null)
                    CapacityReservation = new CapacityReservationProfile();
                CapacityReservation.CapacityReservationGroupId = value;
            }
        }

        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        internal ApplicationProfile ApplicationProfile { get; set; }
        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        public IList<VirtualMachineGalleryApplication> GalleryApplications
        {
            get
            {
                if (ApplicationProfile is null)
                    ApplicationProfile = new ApplicationProfile();
                return ApplicationProfile.GalleryApplications;
            }
        }

        /// <summary> Specifies the time at which the Virtual Machine resource was created. Minimum api-version: 2021-11-01. </summary>
        public DateTimeOffset? TimeCreated { get; }
    }
}
