using Microsoft.EntityFrameworkCore;
using MovieAPI.Application.Feature.CQRS_DesignPattern.Results.MovieResult;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.MovieHandler
{
    public class getMovieQueryHandler
    {
        private readonly MovieContext _context;

        public getMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<getMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new getMovieQueryResult
            {
                movieId = x.Id,
                Title = x.Title,
                coverImageUrl=x.coverImageUrl,
                Ratig = x.Ratig,
                Description=x.Description,
                Duration = x.Duration,
                ReleaseDate = x.ReleaseDate,
                CreatedYear = x.CreatedYear,
                status = x.status
            }).ToList();
        }
    }
}
