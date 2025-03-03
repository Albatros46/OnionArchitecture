using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.CategoryCommands;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.CategoryHandler
{
    public class updateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public updateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async         Task
Handle(UpdateCategoryCommand command)
        {
            var value=await _context.Categories.FindAsync(command.Id);
            value.categoryName=command.categoryName;
            await _context.SaveChangesAsync();
        }
    }
}
