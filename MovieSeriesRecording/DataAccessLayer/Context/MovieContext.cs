using MovieSeriesRecording.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSeriesRecording.DataAccessLayer.Context
{
    /// <summary>
    /// Context sınıfı veritabanı ile uygulama arasındaki bağlantıyı yönetir ve veritabanı tablolarını temsil eder.
    /// </summary>
    public class MovieContext: DbContext //DbContext: EF teknolojisine ait veri tabanına bağlanma sınıfımız.
    {
        /// <summary>
        /// Benim DBSet türünde olan Movie sınıfımızı SQL'de Movies adında bir tabloya dönüştür.
        /// </summary>
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
