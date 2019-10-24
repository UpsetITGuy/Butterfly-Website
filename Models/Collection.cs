using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButterflyWebsite.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public string LatinName { get; set; }
        public DateTime CatchDate { get; set; }

        public string Sex { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ImagePath { get; set; }
    }
}
