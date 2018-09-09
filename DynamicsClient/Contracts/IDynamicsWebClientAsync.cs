// <copyright file="IDynamicsWebClientAsync.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Contracts
{
    using System.Threading.Tasks;

    using DynamicsClients.Responses;

    /// <summary>
    /// The Dynamics Web Client with all asynchronous implementations
    /// </summary>
    public interface IDynamicsWebClientAsync
    {
        /// <summary>
        /// Provides the function to Create or Update an entity based on if the entity exists or not.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="id">The identifier.</param>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// Upsert Response
        /// </returns>
        Task<UpsertResponse> UpsertAsync<T>(string id, T entity)
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Create an entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Create Response
        /// </returns>
        Task<CreateResponse> CreateAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Update an entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Update Response
        /// </returns>
        Task<UpdateResponse> UpdateAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve a Single Entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Retrieve Single Response
        /// </returns>
        Task<RetrieveSingleResponse> RetrieveSingleEntityAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve Multiple Entities.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Retrieve Multiple Response
        /// </returns>
        Task<RetrieveMultipleResponse> RetrieveMultipleEntitiesAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve the result of a Metadata Query.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Retrieve Metadata Query Response
        /// </returns>
        Task<RetrieveMetadataQueryResponse> RetrieveMetadataQueryAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve the result of a FetchXml Query.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Retrieve Fetch XML Query Response
        /// </returns>
        Task<RetrieveFetchXmlQueryResponse> RetrieveFetchXmlQueryAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Delete an entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Delete Response
        /// </returns>
        Task<DeleteResponse> DeleteAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Associates the asynchronous.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Associate Response
        /// </returns>
        Task<AssociateResponse> AssociateAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Disasociates the asynchronous.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Disasociate Response
        /// </returns>
        Task<DisasociateResponse> DisasociateAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Executes the batch operation asynchronous.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Execute Batch Operation Response
        /// </returns>
        Task<ExecuteBatchOperationResponse> ExecuteBatchOperationAsync<T>()
            where T : IDynamicsEntityModel, new();
    }
}