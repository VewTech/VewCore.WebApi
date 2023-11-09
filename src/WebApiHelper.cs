using System.Net.Http.Json;
using Microsoft.AspNetCore.JsonPatch;

namespace VewTech.VewCore.WebApi;

/// <summary>
/// Provides helper methods to interact with the API endpoint a CrudController exposes.
/// </summary>
/// <typeparam name="T">The model type the controller exposes. As for current limitations, its key must be of type Guid.</typeparam>
/// <param name="endpointRoute">The HTTP(S) route where the endpoint is exposed.</param>
/// <param name="options">The options for the WebApiHelper.</param>
public class WebApiHelper<T>(string endpointRoute, WebApiHelperOptions? options = null) where T : class
{
    /// <summary>
    /// The passed options for the WebApiHelper.
    /// </summary>
    private WebApiHelperOptions Options { get; } = options ?? new WebApiHelperOptions()
    {
        JsonSerializerOptions = new(System.Text.Json.JsonSerializerDefaults.Web)
    };

    /// <summary>
    /// This is a wrapper around the GET endpoint. Will return all the resources.
    /// </summary>
    /// <returns>A list with all the resources.</returns>
    /// <exception cref="NullReferenceException"></exception>
    public async virtual Task<IEnumerable<T>> GetAll()
    {
        var response = await Options.HttpClient.GetAsync(endpointRoute);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadFromJsonAsync<IEnumerable<T>>(options: Options.JsonSerializerOptions) ?? throw new NullReferenceException();
        return content;
    }

    /// <summary>
    /// This is a wrapper around the POST endpoint. Will post the resource object.
    /// </summary>
    /// <param name="resource">The resource to be created</param>
    /// <returns>The created resource.</returns>
    /// <exception cref="NullReferenceException"></exception>
    public async virtual Task<T> Post(T resource)
    {
        var response = await Options.HttpClient.PostAsJsonAsync($"{endpointRoute}", resource);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadFromJsonAsync<T>(options: Options.JsonSerializerOptions) ?? throw new NullReferenceException();
        return content;
    }

    /// <summary>
    /// This is a wrapper around the GET "/{id}" endpoint. Will get the resource with the specified id.
    /// </summary>
    /// <param name="id">The id of the resource to retrieve.</param>
    /// <returns>The resource with the specified id.</returns>
    /// <exception cref="NullReferenceException"></exception>
    public async virtual Task<T> GetById(Guid id)
    {
        var response = await Options.HttpClient.GetAsync($"{endpointRoute}/{id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadFromJsonAsync<T>(options: Options.JsonSerializerOptions) ?? throw new NullReferenceException();
        return content;
    }

    /// <summary>
    /// This is a wrapper around the PATCH "/{id}" endpoint. It will update the resource with the specified id based on the JsonPatchDocument provided.
    /// </summary>
    /// <param name="id">The id of the object to update.</param>
    /// <param name="patch">The JsonPatchDocument with the updates to perform on the resource.</param>
    /// <returns>The updated resource.</returns>
    /// <exception cref="NullReferenceException"></exception>
    public async virtual Task<T> Patch(Guid id, JsonPatchDocument<T> patch)
    {
        var response = await Options.HttpClient.PatchAsJsonAsync
        ($"{endpointRoute}/{id}", patch.Operations, options: Options.JsonSerializerOptions);
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadFromJsonAsync<T>(options: Options.JsonSerializerOptions) ?? throw new NullReferenceException();
        return content;
    }

    /// <summary>
    /// This is a wrapper around the DELETE "/{id}" endpoint. It will delete the resource with the given id.
    /// </summary>
    /// <param name="id">The id of the resource to remove.</param>
    /// <returns></returns>
    public async virtual Task Delete(Guid id)
    {
        var response = await Options.HttpClient.DeleteAsync($"{endpointRoute}/{id}");
        response.EnsureSuccessStatusCode();
    }
}