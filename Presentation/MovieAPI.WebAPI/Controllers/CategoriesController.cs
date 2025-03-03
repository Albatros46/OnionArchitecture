using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.CategoryCommands;
using MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.CategoryHandler;
using MovieAPI.Application.Feature.CQRS_DesignPattern.Queries.CategoryQueries;

namespace MovieAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly getCategoryQueryHandler _getCategoryQueryHandler;
        private readonly getCategoryQueryByIdHandler _getCategoryQueryByIdHandler;
        private readonly createCategoryCommandHandler  _createCategoryCommandHandler ;
        private readonly updateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly removeCategoryCommandHandler _removeCategoryCommandHandler;

        public CategoriesController(getCategoryQueryHandler getCategoryQueryHandler, 
            getCategoryQueryByIdHandler getCategoryQueryByIdHandler, 
            createCategoryCommandHandler createCategoryCommandHandler, 
            updateCategoryCommandHandler updateCategoryCommandHandler, 
            removeCategoryCommandHandler removeCategoryCommandHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _getCategoryQueryByIdHandler = getCategoryQueryByIdHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var value = await _getCategoryQueryHandler.Handle();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory( CreateCategoryCommand command)
        {
            await _createCategoryCommandHandler.Handle(command);
            return Ok("Das Hinzufügen einer Kategorie war erfolgreich.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveCategory(int id)
        {
             _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(id));
            return Ok("Die Kategorie wurde erfolgreich gelöscht.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory( UpdateCategoryCommand command)
        {
           
            await _updateCategoryCommandHandler.Handle(command);
            return Ok("Die Kategorie wurde erfolgreich aktualisiert.");
        }
        [HttpGet("/GetCategory")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var value = await _getCategoryQueryByIdHandler.Handle(new getCategoryByIdQuery(id));
            return Ok(value);
        }
    }
}
