using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieSeriesRecording.DataAccessLayer.Context;
using MovieSeriesRecording.DataAccessLayer.Entities;

namespace MovieSeriesRecording
{
    public partial class FrmMovies : Form
    {
        public FrmMovies()
        {
            InitializeComponent();
        }


        private MovieContext movieContext = new MovieContext();

        /// <summary>
        /// Combobox nesnemize vt'nin Category tablosundaki CategoryName alanlarını ekledik.
        /// </summary>
        public void Category()
        {
            var values = movieContext.Categories.Select(c => new { c.CategoryId, c.CategoryTitle }).ToList();
            cmb_Category.DataSource = values;
            cmb_Category.DisplayMember = "CategoryTitle"; //ComboBox'ta görüntülenecek metin olarak, her öğenin CategoryTitle özelliği belirlenir.
            cmb_Category.ValueMember = "CategoryId"; //ComboBox'taki her öğenin arka planda tutulacak değeri olarak CategoryId özelliği atanır.
            cmb_Category.SelectedIndex = -1; // Varsayılan olarak hiçbir şey seçili olmasın
        }

        /// <summary>
        /// Movies tablosu ile Categories tablosunu birleştirerek CategoryTitle bilgisini
        /// DataGridView üzerinde gösterebiliriz.
        /// Bunun için LINQ sorgusu kullanıldı.
        /// </summary>
        public void GetAll()
        {
            using (var values=new MovieContext())
            {
                var spendingList = values.Movies.Select(m => new
                {
                    m.MovieID,
                    m.MovieTitle,
                    m.MovieDuration,
                    m.MovieDescription,
                    m.MovieDate,
                    m.Category.CategoryTitle
                }).ToList();
                dataGridView1.DataSource = spendingList;
            }
        }


        public void ClearForm()
        {
            foreach (Control control in panel3.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            cmb_Category.SelectedIndex = -1;
            dateTimeP_MovieDate.Value = DateTime.Now;
        }

        private void btn_Categorys_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btn_Movie_Click(object sender, EventArgs e)
        {
            FrmMovies frmMovies = new FrmMovies();
            frmMovies.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMovies_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GetAll();
            Category();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            string movieTitle = txt_MovieTitle.Text;
            int movieDuration = Convert.ToInt32(txt_MovieDuration.Text);
            string movieDescription = txt_MovieDescription.Text;
            DateTime movieDate = dateTimeP_MovieDate.Value;
            int categoryId = (int)cmb_Category.SelectedValue; // ComboBox üzerinden seçilen kategori ID'si

            movie.MovieTitle = movieTitle;
            movie.MovieDuration = movieDuration;
            movie.MovieDescription = movieDescription;
            movie.MovieDate = movieDate;
            movie.CategoryId = categoryId;

            movieContext.Movies.Add(movie);
            movieContext.SaveChanges();
            MessageBox.Show("Yeni Film Eklendi", "Filmler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetAll();
            ClearForm();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MovieID"].Value);
                var removeValues = movieContext.Movies.Find(id);
                movieContext.Movies.Remove(removeValues);
                movieContext.SaveChanges();

                MessageBox.Show("Film Silindi", "Filmler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
                ClearForm();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txt_MovieTitle.Text = row.Cells["MovieTitle"].Value.ToString();
                    txt_MovieDuration.Text = row.Cells["MovieDuration"].Value.ToString();
                    txt_MovieDescription.Text = row.Cells["MovieDescription"].Value.ToString();
                    dateTimeP_MovieDate.Value = Convert.ToDateTime(row.Cells["MovieDate"].Value);
                    cmb_Category.Text = row.Cells["CategoryTitle"].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı Alan Seçimi");
                throw;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçili MovieID kontrolü
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Cells["MovieID"].Value == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // (ComboBox) seçimi kontrolü
                if (cmb_Category.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen işlem tipini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int movieId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MovieID"].Value);
                string processType = cmb_Category.SelectedItem.ToString(); // Category doğru bir şekilde alındı.

                // Diğer alanlar
                string movieTitle = txt_MovieTitle.Text;
                int movieDuration = Convert.ToInt32(txt_MovieDuration.Text);
                string movieDescription = txt_MovieDescription.Text;
                DateTime movieDate = dateTimeP_MovieDate.Value;
                int categoryId = (int)cmb_Category.SelectedValue; // ComboBox üzerinden seçilen kategori ID'si

                
                var values = movieContext.Movies.Find(movieId);// Veritabanından güncellenecek kaydı bul
                if (values == null)
                {
                    MessageBox.Show("Seçilen kayıt bulunamadı. Lütfen işlemi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Güncelleme işlemleri
                values.MovieTitle = movieTitle;
                values.MovieDuration = movieDuration;
                values.MovieDescription = movieDescription;
                values.MovieDate = movieDate;
                values.CategoryId = categoryId;

                // Değişiklikleri kaydet
                movieContext.SaveChanges();
                MessageBox.Show("Kayıt başarılı bir şekilde güncellendi.", "Filmler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
                ClearForm();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı işlem. Lütfen bilgileri kontrol ediniz.");
                Console.WriteLine(exception.Message); // Hata mesajını yazdır
                MessageBox.Show("Beklenmedik bir hata oluştu. Hata: " + exception.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
