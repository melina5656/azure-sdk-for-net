// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
    public partial class VirtualMachineStorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineStorageProfile"/>. </summary>
        public VirtualMachineStorageProfile()
        {
            DataDisks = new ChangeTrackingList<VirtualMachineDataDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineStorageProfile"/>. </summary>
        /// <param name="imageReference"> Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. </param>
        /// <param name="osDisk"> Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </param>
        /// <param name="dataDisks"> Specifies the parameters that are used to add a data disk to a virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </param>
        /// <param name="diskControllerType"> Specifies the disk controller type configured for the VM. **Note:** This property will be set to the default disk controller type if not specified provided virtual machine is being created with 'hyperVGeneration' set to V2 based on the capabilities of the operating system disk and VM size from the the specified minimum api version. You need to deallocate the VM before updating its disk controller type unless you are updating the VM size in the VM configuration which implicitly deallocates and reallocates the VM. Minimum api-version: 2022-08-01. </param>
        internal VirtualMachineStorageProfile(ImageReference imageReference, VirtualMachineOSDisk osDisk, IList<VirtualMachineDataDisk> dataDisks, DiskControllerType? diskControllerType)
        {
            ImageReference = imageReference;
            OSDisk = osDisk;
            DataDisks = dataDisks;
            DiskControllerType = diskControllerType;
        }

        /// <summary> Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. </summary>
        public ImageReference ImageReference { get; set; }
        /// <summary> Specifies information about the operating system disk used by the virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
        public VirtualMachineOSDisk OSDisk { get; set; }
        /// <summary> Specifies the parameters that are used to add a data disk to a virtual machine. For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
        public IList<VirtualMachineDataDisk> DataDisks { get; }
        /// <summary> Specifies the disk controller type configured for the VM. **Note:** This property will be set to the default disk controller type if not specified provided virtual machine is being created with 'hyperVGeneration' set to V2 based on the capabilities of the operating system disk and VM size from the the specified minimum api version. You need to deallocate the VM before updating its disk controller type unless you are updating the VM size in the VM configuration which implicitly deallocates and reallocates the VM. Minimum api-version: 2022-08-01. </summary>
        public DiskControllerType? DiskControllerType { get; set; }
    }
}
