using Microsoft.EntityFrameworkCore;
using MovieAPI.Application.Feature.CQRS_DesignPattern.Results.CategoryResult;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.CategoryHandler
{
    public class getCategoryQueryHandler
    {
        private readonly MovieContext _context;

        public getCategoryQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x=>new GetCategoryQueryResult
            {
                categoryId = x.Id,
                categoryName = x.categoryName
            }).ToList();
        }
    }
}
