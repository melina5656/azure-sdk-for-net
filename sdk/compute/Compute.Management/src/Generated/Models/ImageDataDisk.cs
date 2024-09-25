// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources.Models;

namespace Compute.Management.Models
{
    /// <summary> Describes a data disk. </summary>
    public partial class ImageDataDisk : ImageDisk
    {
        /// <summary> Initializes a new instance of <see cref="ImageDataDisk"/>. </summary>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        public ImageDataDisk(int lun)
        {
            Lun = lun;
        }

        /// <summary> Initializes a new instance of <see cref="ImageDataDisk"/>. </summary>
        /// <param name="snapshot"> The snapshot. </param>
        /// <param name="managedDisk"> The managedDisk. </param>
        /// <param name="blobUri"> The Virtual Hard Disk. </param>
        /// <param name="caching"> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The default values are: **None for Standard storage. ReadOnly for Premium storage.**. </param>
        /// <param name="diskSizeGB"> Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. This value cannot be larger than 1023 GB. </param>
        /// <param name="storageAccountType"> Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk. </param>
        /// <param name="diskEncryptionSet"> Specifies the customer managed disk encryption set resource id for the managed image disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="lun"> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </param>
        internal ImageDataDisk(WritableSubResource snapshot, WritableSubResource managedDisk, Uri blobUri, CachingType? caching, int? diskSizeGB, StorageAccountType? storageAccountType, WritableSubResource diskEncryptionSet, IDictionary<string, BinaryData> serializedAdditionalRawData, int lun) : base(snapshot, managedDisk, blobUri, caching, diskSizeGB, storageAccountType, diskEncryptionSet, serializedAdditionalRawData)
        {
            Lun = lun;
        }

        /// <summary> Initializes a new instance of <see cref="ImageDataDisk"/> for deserialization. </summary>
        internal ImageDataDisk()
        {
        }

        /// <summary> Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM. </summary>
        public int Lun { get; set; }
    }
}
