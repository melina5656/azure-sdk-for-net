// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_PartnerNamespaceChannelResource
    {
        // Channels_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ChannelsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Channels_Get.json
            // this example is just showing the usage of "Channels_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceChannelResource created on azure
            // for more information of creating PartnerNamespaceChannelResource, please refer to the document of PartnerNamespaceChannelResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            string channelName = "exampleChannelName1";
            ResourceIdentifier partnerNamespaceChannelResourceId = PartnerNamespaceChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName, channelName);
            PartnerNamespaceChannelResource partnerNamespaceChannel = client.GetPartnerNamespaceChannelResource(partnerNamespaceChannelResourceId);

            // invoke the operation
            PartnerNamespaceChannelResource result = await partnerNamespaceChannel.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            PartnerNamespaceChannelData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Channels_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ChannelsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Channels_Delete.json
            // this example is just showing the usage of "Channels_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceChannelResource created on azure
            // for more information of creating PartnerNamespaceChannelResource, please refer to the document of PartnerNamespaceChannelResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            string channelName = "exampleEventChannelName1";
            ResourceIdentifier partnerNamespaceChannelResourceId = PartnerNamespaceChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName, channelName);
            PartnerNamespaceChannelResource partnerNamespaceChannel = client.GetPartnerNamespaceChannelResource(partnerNamespaceChannelResourceId);

            // invoke the operation
            await partnerNamespaceChannel.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Channels_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ChannelsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Channels_Update.json
            // this example is just showing the usage of "Channels_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceChannelResource created on azure
            // for more information of creating PartnerNamespaceChannelResource, please refer to the document of PartnerNamespaceChannelResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplePartnerNamespaceName1";
            string channelName = "exampleChannelName1";
            ResourceIdentifier partnerNamespaceChannelResourceId = PartnerNamespaceChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName, channelName);
            PartnerNamespaceChannelResource partnerNamespaceChannel = client.GetPartnerNamespaceChannelResource(partnerNamespaceChannelResourceId);

            // invoke the operation
            PartnerNamespaceChannelPatch patch = new PartnerNamespaceChannelPatch()
            {
                ExpireOnIfNotActivated = DateTimeOffset.Parse("2022-03-23T23:06:11.785Z"),
            };
            await partnerNamespaceChannel.UpdateAsync(patch);

            Console.WriteLine($"Succeeded");
        }

        // Channels_GetFullUrl
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFullUri_ChannelsGetFullUrl()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/Channels_GetFullUrl.json
            // this example is just showing the usage of "Channels_GetFullUrl" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this PartnerNamespaceChannelResource created on azure
            // for more information of creating PartnerNamespaceChannelResource, please refer to the document of PartnerNamespaceChannelResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string partnerNamespaceName = "examplenamespace";
            string channelName = "examplechannel";
            ResourceIdentifier partnerNamespaceChannelResourceId = PartnerNamespaceChannelResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, partnerNamespaceName, channelName);
            PartnerNamespaceChannelResource partnerNamespaceChannel = client.GetPartnerNamespaceChannelResource(partnerNamespaceChannelResourceId);

            // invoke the operation
            EventSubscriptionFullUri result = await partnerNamespaceChannel.GetFullUriAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
