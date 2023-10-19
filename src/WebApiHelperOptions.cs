using System.Text.Json;

namespace VewTech.VewCore.WebApi;

/// <summary>
/// Configurations for the WebApiHelper object.
/// </summary>
public class WebApiHelperOptions
{
    /// <summary>
    /// The HttpClient the WebApiHelper will use when performing API requests.
    /// </summary>
    public HttpClient HttpClient { get; set; } = new();

    /// <summary>
    /// The JsonSerializerOptions the WebApiHelper will use when serializing/deserializing objects.
    /// </summary>
    public JsonSerializerOptions JsonSerializerOptions { get; set; } = new();
}