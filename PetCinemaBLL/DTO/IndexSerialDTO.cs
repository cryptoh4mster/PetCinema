using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCinemaBLL.DTO
{
    public class IndexSerialDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
        public int SeasonsAmount { get; set; }
        public int SeriesAmount { get; set; }
    }
}
