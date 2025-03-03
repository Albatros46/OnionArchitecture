using MovieAPI.Application.Feature.CQRS_DesignPattern.Queries.CategoryQueries;
using MovieAPI.Application.Feature.CQRS_DesignPattern.Results.CategoryResult;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.CategoryHandler
{
    public class getCategoryQueryByIdHandler
    {
        private readonly MovieContext _context;

        public getCategoryQueryByIdHandler(MovieContext context)
        {
            _context = context;
        }

  

        public int Id { get; }

        public async Task<GetCategoryByIdQueryResult> Handle(getCategoryByIdQuery idQuery)
        {
            var value= await _context.Categories.FindAsync(idQuery.Id);
            return new GetCategoryByIdQueryResult
            {
                categoryId = value.Id,
                categoryName= value.categoryName
            };
        }
    }
}
