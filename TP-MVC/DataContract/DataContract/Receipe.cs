using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    public class Receipe
    {
        public Guid ID;
        public string Title;
        public List<string> Directions;

        public string getDirectionsAsText()
        {
            return string.Join(" | ", Directions);
        }
    }
}
