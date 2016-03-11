using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    public class Recipe
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<string> Directions { get; set; }
        public string DirectionsAsText => Directions == null ? string.Empty : string.Join(" | ", Directions);
    }
}
