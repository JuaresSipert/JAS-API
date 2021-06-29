using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;

//Endpoint => URL
//https://localhost:5001
//http://localhost:5000
//https://meuapp.azurewebsites
[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    // public string Get()
    // {
    //     return "Get";
    // }
    public async Task<ActionResult<List<Category>>> Get()//programação de forma paralela, não trava a aplicação
    {
        return new List<Category>();
    }

    [HttpGet]
    //[Route("{id}")]//parametro
    [Route("{id:int}")]//parametro com restrição de rota - evita validações dentro do método
    public async Task<ActionResult<Category>> GetById(int id)
    {
        return new Category();
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Post([FromBody]Category model)//model binder faz essa conversão
    {
        
        return Ok(model);
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Category>>> Put(int id, [FromBody]Category model)
    {
        if (model.Id == id)
        {
            return Ok(model);
        }else
            return null;
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<List<Category>>> Delete(int id)
    {
        return Ok();
    }
}