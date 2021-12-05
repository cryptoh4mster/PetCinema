using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetCinemaPL.ViewModels
{
    public class CreateMovieViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public float Rating { get; set; }
    }
}
