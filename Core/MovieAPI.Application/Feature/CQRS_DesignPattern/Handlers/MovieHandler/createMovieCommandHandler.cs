using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.MovieCommands;
using MovieAPI.Domain.Entities;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.MovieHandler
{
    public class createMovieCommandHandler
    {
        private readonly MovieContext _context;

        public createMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(CreateMovieCommand command) 
        {
            _context.Add(new Movie
            {
                 coverImageUrl=command.coverImageUrl,
                 CreatedYear=command.CreatedYear,
                 Description=command.Description,
                 Duration=command.Duration,
                 Ratig =command.Ratig,
                 ReleaseDate=command.ReleaseDate,
                 status=command.status,
                 Title=command.Title,
            });
            await _context.SaveChangesAsync();
        }
    }
}
