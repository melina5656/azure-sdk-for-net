// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.EmailDeliveryReportReceived event. </summary>
    public partial class AcsEmailDeliveryReportReceivedEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsEmailDeliveryReportReceivedEventData"/>. </summary>
        internal AcsEmailDeliveryReportReceivedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsEmailDeliveryReportReceivedEventData"/>. </summary>
        /// <param name="sender"> The Sender Email Address. </param>
        /// <param name="recipient"> The recipient Email Address. </param>
        /// <param name="messageId"> The Id of the email been sent. </param>
        /// <param name="status"> The status of the email. Any value other than Delivered is considered failed. </param>
        /// <param name="deliveryStatusDetails"> Detailed information about the status if any. </param>
        /// <param name="deliveryAttemptTimestamp"> The time at which the email delivery report received timestamp. </param>
        internal AcsEmailDeliveryReportReceivedEventData(string sender, string recipient, string messageId, AcsEmailDeliveryReportStatus? status, AcsEmailDeliveryReportStatusDetails deliveryStatusDetails, DateTimeOffset? deliveryAttemptTimestamp)
        {
            Sender = sender;
            Recipient = recipient;
            MessageId = messageId;
            Status = status;
            DeliveryStatusDetails = deliveryStatusDetails;
            DeliveryAttemptTimestamp = deliveryAttemptTimestamp;
        }

        /// <summary> The Sender Email Address. </summary>
        public string Sender { get; }
        /// <summary> The recipient Email Address. </summary>
        public string Recipient { get; }
        /// <summary> The Id of the email been sent. </summary>
        public string MessageId { get; }
        /// <summary> The status of the email. Any value other than Delivered is considered failed. </summary>
        public AcsEmailDeliveryReportStatus? Status { get; }
        /// <summary> Detailed information about the status if any. </summary>
        public AcsEmailDeliveryReportStatusDetails DeliveryStatusDetails { get; }
        /// <summary> The time at which the email delivery report received timestamp. </summary>
        public DateTimeOffset? DeliveryAttemptTimestamp { get; }
    }
}
