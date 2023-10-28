namespace VewTech.VewCore.WebApi;

/// <summary>
/// The class models need to inherit from in order to be handled by CrudController and WebApiHelper.
/// </summary>
public class WebApiModel
{
    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The id of the resource that created the resource.
    /// </summary>
    public Guid? CreatedBy { get; set; } = null;

    /// <summary>
    /// The time the resource was created at.
    /// </summary>
    public DateTime? CreatedTimestamp { get; set; } = null;

    /// <summary>
    /// The id of the resource that last updated the resource.
    /// </summary>
    public Guid? UpdatedBy { get; set; } = null;

    /// <summary>
    /// The time the resource was last updated at.
    /// </summary>
    public DateTime? UpdatedTimestamp { get; set; } = null;

    /// <summary>
    /// The time the resource was disabled at.
    /// </summary>
    public DateTime? DisabledTimestamp { get; set; } = null;
}