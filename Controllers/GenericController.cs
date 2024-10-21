using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class GenericController<TEntity> : ControllerBase where TEntity : class
{
    private readonly IRepository<TEntity> _repository;

    public GenericController(IRepository<TEntity> repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> Get()
    {
        return Ok(await _repository.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TEntity>> GetById(int id) // Change parameter type to 'int'
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null)
        {
            return NotFound();
        }
        return entity;
    }

    [HttpPost]
    public async Task<ActionResult<TEntity>> Post([FromBody] TEntity entity)
    {
        var createdEntity = await _repository.InsertAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = GetEntityId(entity) }, createdEntity);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] TEntity entity) // Change first parameter type to 'int'
    {
        if (id != GetEntityId(entity))
        {
            return BadRequest();
        }
        await _repository.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id) // Change parameter type to 'int'
    {
        await _repository.DeleteAsync(id);
        return NoContent();
    }

    // Helper method to get the primary key value (adjust as needed)
    private int GetEntityId(TEntity entity)
    {
        return (int)entity.GetType().GetProperty("Id").GetValue(entity);
    }
}