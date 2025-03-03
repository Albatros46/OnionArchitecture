using MovieAPI.Application.Feature.CQRS_DesignPattern.Results.MovieResult;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.MovieHandler
{
    public class getMovieQueryByIdHandler
    {
        private readonly MovieContext _context;

        public getMovieQueryByIdHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<getMovieByIdQueryResult> Handle(getMovieByIdQueryResult idQuery)
        {
            var value = await _context.Movies.FindAsync(idQuery.Id);
            return new getMovieByIdQueryResult
            {
                Id = value.Id,
                Title = value.Title,
                coverImageUrl = value.coverImageUrl,
                Ratig = value.Ratig,
                Description = value.Description,
                Duration = value.Duration,
                ReleaseDate = value.ReleaseDate,
                CreatedYear = value.CreatedYear,
                status = value.status
            };
        }
    }
}
