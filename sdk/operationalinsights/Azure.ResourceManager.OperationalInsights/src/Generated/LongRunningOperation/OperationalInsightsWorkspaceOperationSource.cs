// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights
{
    internal class OperationalInsightsWorkspaceOperationSource : IOperationSource<OperationalInsightsWorkspaceResource>
    {
        private readonly ArmClient _client;

        internal OperationalInsightsWorkspaceOperationSource(ArmClient client)
        {
            _client = client;
        }

        OperationalInsightsWorkspaceResource IOperationSource<OperationalInsightsWorkspaceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<OperationalInsightsWorkspaceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerOperationalInsightsContext.Default);
            return new OperationalInsightsWorkspaceResource(_client, data);
        }

        async ValueTask<OperationalInsightsWorkspaceResource> IOperationSource<OperationalInsightsWorkspaceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<OperationalInsightsWorkspaceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerOperationalInsightsContext.Default);
            return await Task.FromResult(new OperationalInsightsWorkspaceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
