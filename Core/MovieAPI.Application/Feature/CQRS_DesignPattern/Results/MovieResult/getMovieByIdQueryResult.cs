using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Results.MovieResult
{
    public class getMovieByIdQueryResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string coverImageUrl { get; set; }
        public decimal Ratig { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreatedYear { get; set; }
        public bool status { get; set; }
    }
}
