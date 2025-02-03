using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSeriesRecording.DataAccessLayer.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public int  MovieDuration { get; set; }
        public string MovieDescription { get; set; } //Açıklama
        public DateTime MovieDate { get; set; }

        //Foreign Key belirledik.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
