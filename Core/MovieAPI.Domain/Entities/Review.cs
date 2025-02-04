using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string reviewComment { get; set; }
        public int userRating { get; set; }
        public DateTime reviewtDate { get; set; }
        public bool Status { get; set; }
    }
}
