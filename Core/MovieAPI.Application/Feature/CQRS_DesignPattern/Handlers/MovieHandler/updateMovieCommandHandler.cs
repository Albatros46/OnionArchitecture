using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.MovieCommands;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.MovieHandler
{
    public class updateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public updateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(UpdateMovieCommand command)
        {
            var value=await _context.Movies.FindAsync(command.Id);
            value.coverImageUrl=command.coverImageUrl;
            value.status=command.status;
            value.CreatedYear=command.CreatedYear;
            value.Description=command.Description;
            value.Ratig=command.Ratig;
            value.ReleaseDate=command.ReleaseDate;
            value.Title=command.Title;
            value.Duration=command.Duration;
            await _context.SaveChangesAsync();
        }
    }
}
