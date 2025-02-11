using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.CategoryCommands;
using MovieAPI.Domain.Entities;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.CategoryHandler
{
    public class createCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public createCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateCategoryCommand command) 
        {
            _context.Categories.Add(new Category {
                categoryName=command.categoryName
            });
            await _context.SaveChangesAsync();
        }
    }
}
