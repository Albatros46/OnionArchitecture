using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Application.Feature.CQRS_DesignPattern.Commands.CategoryCommands
{
    public class CreateCategoryCommand
    {
        public string categoryName { get; set; }
    }
}
