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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private MovieContext context = new MovieContext();

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearForm();   
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            var categories = context.Categories
                .Select(c => new
                {
                    c.CategoryId,
                    c.CategoryTitle
                })
                .ToList();

            dataGridView1.DataSource = categories;
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
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            GetAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txt_CategoryName.Text = row.Cells["CategoryTitle"].Value.ToString();
                    
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı Alan Seçimi");
                throw;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            try
            { 
                category.CategoryTitle = txt_CategoryName.Text;
                context.Categories.Add(category);
                context.SaveChanges();
                MessageBox.Show("Yeni Veri Eklendi!", "Kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Hatalı Veri Girişi. Lütfen Bilgileri Kontrol Ediniz!");
                Console.WriteLine(exception.Message);
                throw;
            }
            GetAll();
            ClearForm();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryId"].Value);
                var removeValues = context.Categories.Find(id);
                context.Categories.Remove(removeValues);
                context.SaveChanges();
                MessageBox.Show("Kategori Silindi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
                ClearForm();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string categoryName = txt_CategoryName.Text;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CategoryId"].Value);
                var values = context.Categories.Find(id);

                values.CategoryTitle = categoryName;

                context.SaveChanges();

                MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemde Güncellendi", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAll();
                ClearForm();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var values = context.Categories.Where(c => c.CategoryTitle == txt_CategoryName.Text).ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_Movie_Click(object sender, EventArgs e)
        {
            FrmMovies frmMovies = new FrmMovies();
            frmMovies.Show();
            this.Hide();
        }

        private void btn_Categorys_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }
    }
}
