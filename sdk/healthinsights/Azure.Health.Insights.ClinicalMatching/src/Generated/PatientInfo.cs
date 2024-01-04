// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> Patient structured information, including demographics and known structured clinical information. </summary>
    public partial class PatientInfo
    {
        /// <summary> Initializes a new instance of <see cref="PatientInfo"/>. </summary>
        public PatientInfo()
        {
            ClinicalInfo = new ChangeTrackingList<ClinicalCodedElement>();
        }

        /// <summary> Initializes a new instance of <see cref="PatientInfo"/>. </summary>
        /// <param name="sex"> The patient's sex. </param>
        /// <param name="birthDate"> The patient's date of birth. </param>
        /// <param name="clinicalInfo"> Known clinical information for the patient, structured. </param>
        internal PatientInfo(PatientInfoSex? sex, DateTimeOffset? birthDate, IList<ClinicalCodedElement> clinicalInfo)
        {
            Sex = sex;
            BirthDate = birthDate;
            ClinicalInfo = clinicalInfo;
        }

        /// <summary> The patient's sex. </summary>
        public PatientInfoSex? Sex { get; set; }
        /// <summary> The patient's date of birth. </summary>
        public DateTimeOffset? BirthDate { get; set; }
        /// <summary> Known clinical information for the patient, structured. </summary>
        public IList<ClinicalCodedElement> ClinicalInfo { get; }
    }
}
