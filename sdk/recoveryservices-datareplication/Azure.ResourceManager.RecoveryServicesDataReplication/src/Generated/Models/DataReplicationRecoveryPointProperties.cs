// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Recovery point model properties. </summary>
    public partial class DataReplicationRecoveryPointProperties
    {
        /// <summary> Initializes a new instance of <see cref="DataReplicationRecoveryPointProperties"/>. </summary>
        /// <param name="recoveryPointOn"> Gets or sets the recovery point time. </param>
        /// <param name="recoveryPointType"> Gets or sets the recovery point type. </param>
        /// <param name="customProperties">
        /// Recovery point model custom properties.
        /// Please note <see cref="RecoveryPointModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciRecoveryPointModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        internal DataReplicationRecoveryPointProperties(DateTimeOffset recoveryPointOn, DataReplicationRecoveryPointType recoveryPointType, RecoveryPointModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            RecoveryPointOn = recoveryPointOn;
            RecoveryPointType = recoveryPointType;
            CustomProperties = customProperties;
        }

        /// <summary> Gets or sets the recovery point time. </summary>
        public DateTimeOffset RecoveryPointOn { get; }
        /// <summary> Gets or sets the recovery point type. </summary>
        public DataReplicationRecoveryPointType RecoveryPointType { get; }
        /// <summary>
        /// Recovery point model custom properties.
        /// Please note <see cref="RecoveryPointModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciRecoveryPointModelCustomProperties"/>.
        /// </summary>
        public RecoveryPointModelCustomProperties CustomProperties { get; }
    }
}
