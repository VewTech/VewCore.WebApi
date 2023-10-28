namespace VewTech.VewCore.WebApi;

public interface IWebApiModel
{
    public Guid Id { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime CreatedTimestamp { get; set; }
    public Guid UpdatedBy { get; set; }
    public DateTime UpdatedTimestamp { get; set; }
    public bool Disabled { get; set; }
    public DateTime? DisabledTimestamp { get; set; }
}