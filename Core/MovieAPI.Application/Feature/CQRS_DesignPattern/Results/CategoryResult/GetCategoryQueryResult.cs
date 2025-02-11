using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Results.CategoryResult
{
    public class GetCategoryQueryResult
    {
        public int Id { get; set; }
        public string categoryName { get; set; }
    }
}
