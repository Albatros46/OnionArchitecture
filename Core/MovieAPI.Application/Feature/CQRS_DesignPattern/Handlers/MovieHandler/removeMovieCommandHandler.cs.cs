using MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.MovieCommands;
using MovieAPI.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Handlers.MovieHandler
{
    public class removeMovieCommandHandler
    {
        private readonly MovieContext _context;

        public removeMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(RemoveMovieCommand command)
        {
            var value=await _context.Movies.FindAsync(command.Id);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
