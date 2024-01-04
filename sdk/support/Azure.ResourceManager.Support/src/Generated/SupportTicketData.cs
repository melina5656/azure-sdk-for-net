// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing the SupportTicket data model.
    /// Object that represents SupportTicketDetails resource.
    /// </summary>
    public partial class SupportTicketData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SupportTicketData"/>. </summary>
        public SupportTicketData()
        {
            SecondaryConsent = new ChangeTrackingList<SecondaryConsent>();
        }

        /// <summary> Initializes a new instance of <see cref="SupportTicketData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="supportTicketId"> System generated support ticket Id that is unique. </param>
        /// <param name="description"> Detailed description of the question or issue. </param>
        /// <param name="problemClassificationId"> Each Azure service has its own set of issue categories, also known as problem classification. This parameter is the unique Id for the type of problem you are experiencing. </param>
        /// <param name="problemClassificationDisplayName"> Localized name of problem classification. </param>
        /// <param name="severity"> A value that indicates the urgency of the case, which in turn determines the response time according to the service level agreement of the technical support plan you have with Azure. Note: 'Highest critical impact', also known as the 'Emergency - Severe impact' level in the Azure portal is reserved only for our Premium customers. </param>
        /// <param name="enrollmentId"> Enrollment Id associated with the support ticket. </param>
        /// <param name="require24X7Response"> Indicates if this requires a 24x7 response from Azure. </param>
        /// <param name="advancedDiagnosticConsent"> Advanced diagnostic consent to be updated on the support ticket. </param>
        /// <param name="problemScopingQuestions"> Problem scoping questions associated with the support ticket. </param>
        /// <param name="supportPlanId"> Support plan id associated with the support ticket. </param>
        /// <param name="contactDetails"> Contact information of the user requesting to create a support ticket. </param>
        /// <param name="serviceLevelAgreement"> Service Level Agreement information for this support ticket. </param>
        /// <param name="supportEngineer"> Information about the support engineer working on this support ticket. </param>
        /// <param name="supportPlanType"> Support plan type associated with the support ticket. </param>
        /// <param name="supportPlanDisplayName"> Support plan type associated with the support ticket. </param>
        /// <param name="title"> Title of the support ticket. </param>
        /// <param name="problemStartOn"> Time in UTC (ISO 8601 format) when the problem started. </param>
        /// <param name="serviceId"> This is the resource Id of the Azure service resource associated with the support ticket. </param>
        /// <param name="serviceDisplayName"> Localized name of the Azure service. </param>
        /// <param name="status"> Status of the support ticket. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the support ticket was created. </param>
        /// <param name="modifiedOn"> Time in UTC (ISO 8601 format) when the support ticket was last modified. </param>
        /// <param name="fileWorkspaceName"> File workspace name. </param>
        /// <param name="technicalTicketDetails"> Additional ticket details associated with a technical support ticket request. </param>
        /// <param name="quotaTicketDetails"> Additional ticket details associated with a quota support ticket request. </param>
        /// <param name="secondaryConsent"> This property indicates secondary consents for the support ticket. </param>
        internal SupportTicketData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string supportTicketId, string description, string problemClassificationId, string problemClassificationDisplayName, SupportSeverityLevel? severity, string enrollmentId, bool? require24X7Response, AdvancedDiagnosticConsent? advancedDiagnosticConsent, string problemScopingQuestions, string supportPlanId, SupportContactProfile contactDetails, SupportServiceLevelAgreement serviceLevelAgreement, SupportEngineer supportEngineer, string supportPlanType, string supportPlanDisplayName, string title, DateTimeOffset? problemStartOn, string serviceId, string serviceDisplayName, string status, DateTimeOffset? createdOn, DateTimeOffset? modifiedOn, string fileWorkspaceName, TechnicalTicketDetails technicalTicketDetails, QuotaTicketDetails quotaTicketDetails, IList<SecondaryConsent> secondaryConsent) : base(id, name, resourceType, systemData)
        {
            SupportTicketId = supportTicketId;
            Description = description;
            ProblemClassificationId = problemClassificationId;
            ProblemClassificationDisplayName = problemClassificationDisplayName;
            Severity = severity;
            EnrollmentId = enrollmentId;
            Require24X7Response = require24X7Response;
            AdvancedDiagnosticConsent = advancedDiagnosticConsent;
            ProblemScopingQuestions = problemScopingQuestions;
            SupportPlanId = supportPlanId;
            ContactDetails = contactDetails;
            ServiceLevelAgreement = serviceLevelAgreement;
            SupportEngineer = supportEngineer;
            SupportPlanType = supportPlanType;
            SupportPlanDisplayName = supportPlanDisplayName;
            Title = title;
            ProblemStartOn = problemStartOn;
            ServiceId = serviceId;
            ServiceDisplayName = serviceDisplayName;
            Status = status;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            FileWorkspaceName = fileWorkspaceName;
            TechnicalTicketDetails = technicalTicketDetails;
            QuotaTicketDetails = quotaTicketDetails;
            SecondaryConsent = secondaryConsent;
        }

        /// <summary> System generated support ticket Id that is unique. </summary>
        public string SupportTicketId { get; set; }
        /// <summary> Detailed description of the question or issue. </summary>
        public string Description { get; set; }
        /// <summary> Each Azure service has its own set of issue categories, also known as problem classification. This parameter is the unique Id for the type of problem you are experiencing. </summary>
        public string ProblemClassificationId { get; set; }
        /// <summary> Localized name of problem classification. </summary>
        public string ProblemClassificationDisplayName { get; }
        /// <summary> A value that indicates the urgency of the case, which in turn determines the response time according to the service level agreement of the technical support plan you have with Azure. Note: 'Highest critical impact', also known as the 'Emergency - Severe impact' level in the Azure portal is reserved only for our Premium customers. </summary>
        public SupportSeverityLevel? Severity { get; set; }
        /// <summary> Enrollment Id associated with the support ticket. </summary>
        public string EnrollmentId { get; }
        /// <summary> Indicates if this requires a 24x7 response from Azure. </summary>
        public bool? Require24X7Response { get; set; }
        /// <summary> Advanced diagnostic consent to be updated on the support ticket. </summary>
        public AdvancedDiagnosticConsent? AdvancedDiagnosticConsent { get; set; }
        /// <summary> Problem scoping questions associated with the support ticket. </summary>
        public string ProblemScopingQuestions { get; set; }
        /// <summary> Support plan id associated with the support ticket. </summary>
        public string SupportPlanId { get; set; }
        /// <summary> Contact information of the user requesting to create a support ticket. </summary>
        public SupportContactProfile ContactDetails { get; set; }
        /// <summary> Service Level Agreement information for this support ticket. </summary>
        public SupportServiceLevelAgreement ServiceLevelAgreement { get; set; }
        /// <summary> Information about the support engineer working on this support ticket. </summary>
        internal SupportEngineer SupportEngineer { get; set; }
        /// <summary> Email address of the Azure Support engineer assigned to the support ticket. </summary>
        public string SupportEngineerEmailAddress
        {
            get => SupportEngineer is null ? default : SupportEngineer.EmailAddress;
        }

        /// <summary> Support plan type associated with the support ticket. </summary>
        public string SupportPlanType { get; }
        /// <summary> Support plan type associated with the support ticket. </summary>
        public string SupportPlanDisplayName { get; }
        /// <summary> Title of the support ticket. </summary>
        public string Title { get; set; }
        /// <summary> Time in UTC (ISO 8601 format) when the problem started. </summary>
        public DateTimeOffset? ProblemStartOn { get; set; }
        /// <summary> This is the resource Id of the Azure service resource associated with the support ticket. </summary>
        public string ServiceId { get; set; }
        /// <summary> Localized name of the Azure service. </summary>
        public string ServiceDisplayName { get; }
        /// <summary> Status of the support ticket. </summary>
        public string Status { get; }
        /// <summary> Time in UTC (ISO 8601 format) when the support ticket was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time in UTC (ISO 8601 format) when the support ticket was last modified. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> File workspace name. </summary>
        public string FileWorkspaceName { get; set; }
        /// <summary> Additional ticket details associated with a technical support ticket request. </summary>
        internal TechnicalTicketDetails TechnicalTicketDetails { get; set; }
        /// <summary> This is the resource Id of the Azure service resource (For example: A virtual machine resource or an HDInsight resource) for which the support ticket is created. </summary>
        public ResourceIdentifier TechnicalTicketDetailsResourceId
        {
            get => TechnicalTicketDetails is null ? default : TechnicalTicketDetails.ResourceId;
            set
            {
                if (TechnicalTicketDetails is null)
                    TechnicalTicketDetails = new TechnicalTicketDetails();
                TechnicalTicketDetails.ResourceId = value;
            }
        }

        /// <summary> Additional ticket details associated with a quota support ticket request. </summary>
        public QuotaTicketDetails QuotaTicketDetails { get; set; }
        /// <summary> This property indicates secondary consents for the support ticket. </summary>
        public IList<SecondaryConsent> SecondaryConsent { get; }
    }
}
