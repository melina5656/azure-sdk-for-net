// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The object representing periodic mode backup policy. </summary>
    public partial class PeriodicModeBackupPolicy : CosmosDBAccountBackupPolicy
    {
        /// <summary> Initializes a new instance of <see cref="PeriodicModeBackupPolicy"/>. </summary>
        public PeriodicModeBackupPolicy()
        {
            BackupPolicyType = BackupPolicyType.Periodic;
        }

        /// <summary> Initializes a new instance of <see cref="PeriodicModeBackupPolicy"/>. </summary>
        /// <param name="backupPolicyType"> Describes the mode of backups. </param>
        /// <param name="migrationState"> The object representing the state of the migration between the backup policies. </param>
        /// <param name="periodicModeProperties"> Configuration values for periodic mode backup. </param>
        internal PeriodicModeBackupPolicy(BackupPolicyType backupPolicyType, BackupPolicyMigrationState migrationState, PeriodicModeProperties periodicModeProperties) : base(backupPolicyType, migrationState)
        {
            PeriodicModeProperties = periodicModeProperties;
            BackupPolicyType = backupPolicyType;
        }

        /// <summary> Configuration values for periodic mode backup. </summary>
        public PeriodicModeProperties PeriodicModeProperties { get; set; }
    }
}
