namespace VewTech.VewCore.WebApi.WebApiTest.Models;

public class TestModel : IWebApiModel
{
    public Guid Id { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime CreatedTimestamp { get; set; }
    public Guid? UpdatedBy { get; set; }
    public DateTime? UpdatedTimestamp { get; set; }
    public DateTime? DisabledTimestamp { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
}