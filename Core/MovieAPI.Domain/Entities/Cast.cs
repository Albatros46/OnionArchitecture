using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Domain.Entities
{
    public class Cast
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FullName { get; set; }
        public string imageUrl { get; set; }
        public string? Overview { get; set; }
        public string? Biography { get; set; }
    }
}
