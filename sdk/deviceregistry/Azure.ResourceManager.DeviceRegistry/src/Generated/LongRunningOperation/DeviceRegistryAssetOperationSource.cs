// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry
{
    internal class DeviceRegistryAssetOperationSource : IOperationSource<DeviceRegistryAssetResource>
    {
        private readonly ArmClient _client;

        internal DeviceRegistryAssetOperationSource(ArmClient client)
        {
            _client = client;
        }

        DeviceRegistryAssetResource IOperationSource<DeviceRegistryAssetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DeviceRegistryAssetData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDeviceRegistryContext.Default);
            return new DeviceRegistryAssetResource(_client, data);
        }

        async ValueTask<DeviceRegistryAssetResource> IOperationSource<DeviceRegistryAssetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DeviceRegistryAssetData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDeviceRegistryContext.Default);
            return await Task.FromResult(new DeviceRegistryAssetResource(_client, data)).ConfigureAwait(false);
        }
    }
}
