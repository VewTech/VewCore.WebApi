namespace VewTech.VewCore.WebApi;

public interface IWebApiModel
{
    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The id of the resource that created the resource.
    /// </summary>
    public Guid? CreatedBy { get; set; }

    /// <summary>
    /// The time the resource was created at.
    /// </summary>
    public DateTime CreatedTimestamp { get; set; }

    /// <summary>
    /// The id of the resource that last updated the resource.
    /// </summary>
    public Guid? UpdatedBy { get; set; }

    /// <summary>
    /// The time the resource was last updated at.
    /// </summary>
    public DateTime? UpdatedTimestamp { get; set; }

    /// <summary>
    /// The time the resource was disabled at.
    /// </summary>
    public DateTime? DisabledTimestamp { get; set; }
}