using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSeriesRecording.DataAccessLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }

        //Bir kategorinin birden fazla filmi olabileceği için List içinde Movie tanımladık.
        public List<Movie> Movies { get; set; }
    }
}
