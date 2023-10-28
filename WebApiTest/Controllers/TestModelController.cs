using Microsoft.AspNetCore.Mvc;
using VewTech.VewCore.WebApi.WebApiTest.Models;

namespace VewTech.VewCore.WebApi.WebApiTest.Controllers;

[Route("[controller]")]
public class TestModelController(DataContext dataContext) : CrudController<TestModel>(dataContext, dataContext.TestModels) { }