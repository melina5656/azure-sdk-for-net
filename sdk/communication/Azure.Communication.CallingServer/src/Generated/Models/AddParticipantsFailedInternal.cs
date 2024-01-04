// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The AddParticipantsFailedEvent. </summary>
    internal partial class AddParticipantsFailedInternal
    {
        /// <summary> Initializes a new instance of <see cref="AddParticipantsFailedInternal"/>. </summary>
        internal AddParticipantsFailedInternal()
        {
            Participants = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="AddParticipantsFailedInternal"/>. </summary>
        /// <param name="eventSource"></param>
        /// <param name="operationContext"></param>
        /// <param name="resultInformation"></param>
        /// <param name="participants"></param>
        /// <param name="version"> Used to determine the version of the event. </param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="publicEventType"> The public event namespace used as the "type" property in the CloudEvent. </param>
        internal AddParticipantsFailedInternal(string eventSource, string operationContext, ResultInformation resultInformation, IReadOnlyList<CommunicationIdentifierModel> participants, string version, string callConnectionId, string serverCallId, string correlationId, string publicEventType)
        {
            EventSource = eventSource;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            Participants = participants;
            Version = version;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            PublicEventType = publicEventType;
        }

        /// <summary> Gets the event source. </summary>
        public string EventSource { get; }
        /// <summary> Gets the operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets the result information. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Gets the participants. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Participants { get; }
        /// <summary> Used to determine the version of the event. </summary>
        public string Version { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> The public event namespace used as the "type" property in the CloudEvent. </summary>
        public string PublicEventType { get; }
    }
}
