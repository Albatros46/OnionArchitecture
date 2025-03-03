using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.CategoryCommands;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.CategoryHandler
{
    public class removeCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public removeCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveCategoryCommand command) 
        {
            var value=await _context.Categories.FindAsync(command.Id);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
