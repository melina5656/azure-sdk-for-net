// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;

namespace AzureResourceManagerGallery.Samples
{
    public partial class Sample_SharedGalleryResource
    {
        // Get a shared gallery.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASharedGallery()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/GalleryRP/stable/2023-07-03/examples/sharedGalleryExamples/SharedGallery_Get.json
            // this example is just showing the usage of "SharedGalleries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SharedGalleryResource created on azure
            // for more information of creating SharedGalleryResource, please refer to the document of SharedGalleryResource
            string subscriptionId = "{subscription-id}";
            AzureLocation location = new AzureLocation("myLocation");
            string galleryUniqueName = "galleryUniqueName";
            ResourceIdentifier sharedGalleryResourceId = SharedGalleryResource.CreateResourceIdentifier(subscriptionId, location, galleryUniqueName);
            SharedGalleryResource sharedGallery = client.GetSharedGalleryResource(sharedGalleryResourceId);

            // invoke the operation
            SharedGalleryResource result = await sharedGallery.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SharedGalleryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
