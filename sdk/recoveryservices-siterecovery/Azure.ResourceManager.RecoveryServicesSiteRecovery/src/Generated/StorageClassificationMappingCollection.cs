// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageClassificationMappingResource"/> and their operations.
    /// Each <see cref="StorageClassificationMappingResource"/> in the collection will belong to the same instance of <see cref="StorageClassificationResource"/>.
    /// To get a <see cref="StorageClassificationMappingCollection"/> instance call the GetStorageClassificationMappings method from an instance of <see cref="StorageClassificationResource"/>.
    /// </summary>
    public partial class StorageClassificationMappingCollection : ArmCollection, IEnumerable<StorageClassificationMappingResource>, IAsyncEnumerable<StorageClassificationMappingResource>
    {
        private readonly ClientDiagnostics _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics;
        private readonly ReplicationStorageClassificationMappingsRestOperations _storageClassificationMappingReplicationStorageClassificationMappingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageClassificationMappingCollection"/> class for mocking. </summary>
        protected StorageClassificationMappingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageClassificationMappingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageClassificationMappingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", StorageClassificationMappingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageClassificationMappingResource.ResourceType, out string storageClassificationMappingReplicationStorageClassificationMappingsApiVersion);
            _storageClassificationMappingReplicationStorageClassificationMappingsRestClient = new ReplicationStorageClassificationMappingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageClassificationMappingReplicationStorageClassificationMappingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageClassificationResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageClassificationResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create a storage classification mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="content"> Pairing input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageClassificationMappingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageClassificationMappingName, StorageClassificationMappingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<StorageClassificationMappingResource>(new StorageClassificationMappingOperationSource(Client), _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics, Pipeline, _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create a storage classification mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="content"> Pairing input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<StorageClassificationMappingResource> CreateOrUpdate(WaitUntil waitUntil, string storageClassificationMappingName, StorageClassificationMappingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<StorageClassificationMappingResource>(new StorageClassificationMappingOperationSource(Client), _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics, Pipeline, _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified storage classification mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> is null. </exception>
        public virtual async Task<Response<StorageClassificationMappingResource>> GetAsync(string storageClassificationMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageClassificationMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the specified storage classification mapping.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> is null. </exception>
        public virtual Response<StorageClassificationMappingResource> Get(string storageClassificationMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.Get");
            scope.Start();
            try
            {
                var response = _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageClassificationMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the storage classification mappings for the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_ListByReplicationStorageClassifications</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageClassificationMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageClassificationMappingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateListByReplicationStorageClassificationsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateListByReplicationStorageClassificationsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageClassificationMappingResource(Client, StorageClassificationMappingData.DeserializeStorageClassificationMappingData(e)), _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics, Pipeline, "StorageClassificationMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the storage classification mappings for the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_ListByReplicationStorageClassifications</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageClassificationMappingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageClassificationMappingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateListByReplicationStorageClassificationsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.CreateListByReplicationStorageClassificationsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageClassificationMappingResource(Client, StorageClassificationMappingData.DeserializeStorageClassificationMappingData(e)), _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics, Pipeline, "StorageClassificationMappingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageClassificationMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageClassificationMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageClassificationMappingResource>> GetIfExistsAsync(string storageClassificationMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageClassificationMappingResource>(response.GetRawResponse());
                return Response.FromValue(new StorageClassificationMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationFabrics/{fabricName}/replicationStorageClassifications/{storageClassificationName}/replicationStorageClassificationMappings/{storageClassificationMappingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReplicationStorageClassificationMappings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageClassificationMappingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageClassificationMappingName"> Storage classification mapping name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageClassificationMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageClassificationMappingName"/> is null. </exception>
        public virtual NullableResponse<StorageClassificationMappingResource> GetIfExists(string storageClassificationMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageClassificationMappingName, nameof(storageClassificationMappingName));

            using var scope = _storageClassificationMappingReplicationStorageClassificationMappingsClientDiagnostics.CreateScope("StorageClassificationMappingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageClassificationMappingReplicationStorageClassificationMappingsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storageClassificationMappingName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageClassificationMappingResource>(response.GetRawResponse());
                return Response.FromValue(new StorageClassificationMappingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageClassificationMappingResource> IEnumerable<StorageClassificationMappingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageClassificationMappingResource> IAsyncEnumerable<StorageClassificationMappingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
