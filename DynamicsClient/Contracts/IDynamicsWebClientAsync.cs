// <copyright file="IDynamicsWebClientAsync.cs" company="Charles Kuperus">
// Copyright (c) Charles Kuperus. All rights reserved.
// </copyright>

namespace DynamicsClients.Contracts
{
    using System.Threading.Tasks;

    using DynamicsClients.Models;
    using DynamicsClients.Responses;

    /// <summary>
    /// The Dynamics Web Client with all asynchronous methods.
    /// </summary>
    public interface IDynamicsWebClientAsync
    {
        /// <summary>
        /// Provides the function to Create or Update an entity based on if the entity exists or not.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// Upsert Response
        /// </returns>
        Task<UpsertResponse> UpsertAsync<T>(T entity)
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Create an entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// Create Response
        /// </returns>
        Task<CreateResponse> CreateAsync<T>(T entity)
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Update an entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// Update Response
        /// </returns>
        Task<UpdateResponse> UpdateAsync<T>(T entity)
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve a Single Entity by identifier.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Retrieve Single Response
        /// </returns>
        Task<RetrieveSingleResponse> RetrieveSingleEntityByIdAsync<T>(string id)
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve a Single Entity by alternate field.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="fieldname">The field name.</param>
        /// <param name="value">The value.</param>
        /// <returns>
        /// Retrieve Single Response
        /// </returns>
        Task<RetrieveSingleResponse> RetrieveSingleEntityByAlternateFieldAsync<T>(string fieldname, string value)
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Retrieve Multiple Entities by Query.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <param name="query">The query.</param>
        /// <returns>
        /// Retrieve Multiple Response
        /// </returns>
        Task<RetrieveMultipleResponse> RetrieveMultipleEntitiesByQueryAsync<T>(DynamicsQuery query)
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
        /// Provides the function to Associate an entity to another entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Associate Response
        /// </returns>
        Task<AssociateResponse> AssociateAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Disassociate an entity to another entity.
        /// </summary>
        /// <typeparam name="T">The entity model</typeparam>
        /// <returns>
        /// Disassociate Response
        /// </returns>
        Task<DisasociateResponse> DisassociateAsync<T>()
            where T : IDynamicsEntityModel, new();

        /// <summary>
        /// Provides the function to Execute a Batch Operation.
        /// </summary>
        /// <returns>
        /// Execute Batch Operation Response
        /// </returns>
        Task<ExecuteBatchOperationResponse> ExecuteBatchOperationAsync();
    }
}