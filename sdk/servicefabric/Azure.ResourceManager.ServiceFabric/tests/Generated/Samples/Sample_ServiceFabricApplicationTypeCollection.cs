// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabric.Samples
{
    public partial class Sample_ServiceFabricApplicationTypeCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_PutAnApplicationType()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeNamePutOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationTypeResource
            ServiceFabricApplicationTypeCollection collection = serviceFabricCluster.GetServiceFabricApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            ServiceFabricApplicationTypeData data = new ServiceFabricApplicationTypeData(default)
            {
                Tags = { },
            };
            ArmOperation<ServiceFabricApplicationTypeResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, applicationTypeName, data);
            ServiceFabricApplicationTypeResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnApplicationType()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeNameGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationTypeResource
            ServiceFabricApplicationTypeCollection collection = serviceFabricCluster.GetServiceFabricApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            ServiceFabricApplicationTypeResource result = await collection.GetAsync(applicationTypeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricApplicationTypeData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_GetAListOfApplicationTypeNameResources()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeNameListOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationTypeResource
            ServiceFabricApplicationTypeCollection collection = serviceFabricCluster.GetServiceFabricApplicationTypes();

            // invoke the operation and iterate over the result
            await foreach (ServiceFabricApplicationTypeResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricApplicationTypeData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAnApplicationType()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeNameGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationTypeResource
            ServiceFabricApplicationTypeCollection collection = serviceFabricCluster.GetServiceFabricApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            bool result = await collection.ExistsAsync(applicationTypeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAnApplicationType()
        {
            // Generated from example definition: specification/servicefabric/resource-manager/Microsoft.ServiceFabric/preview/2023-11-01-preview/examples/ApplicationTypeNameGetOperation_example.json
            // this example is just showing the usage of "ApplicationTypes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceFabricClusterResource created on azure
            // for more information of creating ServiceFabricClusterResource, please refer to the document of ServiceFabricClusterResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "resRg";
            string clusterName = "myCluster";
            ResourceIdentifier serviceFabricClusterResourceId = ServiceFabricClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricClusterResource serviceFabricCluster = client.GetServiceFabricClusterResource(serviceFabricClusterResourceId);

            // get the collection of this ServiceFabricApplicationTypeResource
            ServiceFabricApplicationTypeCollection collection = serviceFabricCluster.GetServiceFabricApplicationTypes();

            // invoke the operation
            string applicationTypeName = "myAppType";
            NullableResponse<ServiceFabricApplicationTypeResource> response = await collection.GetIfExistsAsync(applicationTypeName);
            ServiceFabricApplicationTypeResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ServiceFabricApplicationTypeData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
