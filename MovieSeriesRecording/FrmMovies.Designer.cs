﻿
namespace MovieSeriesRecording
{
    partial class FrmMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Movie = new System.Windows.Forms.Button();
            this.btn_Categorys = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_MovieTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeP_MovieDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MovieDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MovieDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(129)))), ((int)(((byte)(142)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-12, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 40);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filmler Formu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Movie);
            this.panel1.Controls.Add(this.btn_Categorys);
            this.panel1.Location = new System.Drawing.Point(-12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 717);
            this.panel1.TabIndex = 25;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(33, 175);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(184, 52);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Çıkış Yap";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Movie
            // 
            this.btn_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Movie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Movie.ForeColor = System.Drawing.Color.White;
            this.btn_Movie.Location = new System.Drawing.Point(33, 99);
            this.btn_Movie.Name = "btn_Movie";
            this.btn_Movie.Size = new System.Drawing.Size(184, 52);
            this.btn_Movie.TabIndex = 5;
            this.btn_Movie.Text = "Filmler";
            this.btn_Movie.UseVisualStyleBackColor = false;
            this.btn_Movie.Click += new System.EventHandler(this.btn_Movie_Click);
            // 
            // btn_Categorys
            // 
            this.btn_Categorys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(72)))), ((int)(((byte)(80)))));
            this.btn_Categorys.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Categorys.ForeColor = System.Drawing.Color.White;
            this.btn_Categorys.Location = new System.Drawing.Point(33, 27);
            this.btn_Categorys.Name = "btn_Categorys";
            this.btn_Categorys.Size = new System.Drawing.Size(184, 52);
            this.btn_Categorys.TabIndex = 0;
            this.btn_Categorys.Text = "Kategoriler";
            this.btn_Categorys.UseVisualStyleBackColor = false;
            this.btn_Categorys.Click += new System.EventHandler(this.btn_Categorys_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_Add.Location = new System.Drawing.Point(275, 242);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(184, 60);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Yeni Film";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_MovieTitle
            // 
            this.txt_MovieTitle.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MovieTitle.Location = new System.Drawing.Point(173, 14);
            this.txt_MovieTitle.Name = "txt_MovieTitle";
            this.txt_MovieTitle.Size = new System.Drawing.Size(338, 29);
            this.txt_MovieTitle.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Film Adı:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmb_Category);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dateTimeP_MovieDate);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_MovieDescription);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_MovieDuration);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_Clear);
            this.panel3.Controls.Add(this.btn_Update);
            this.panel3.Controls.Add(this.btn_Delete);
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.btn_GetAll);
            this.panel3.Controls.Add(this.txt_MovieTitle);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(244, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 330);
            this.panel3.TabIndex = 28;
            // 
            // cmb_Category
            // 
            this.cmb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(752, 137);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(338, 30);
            this.cmb_Category.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(628, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Categori:";
            // 
            // dateTimeP_MovieDate
            // 
            this.dateTimeP_MovieDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeP_MovieDate.Location = new System.Drawing.Point(173, 136);
            this.dateTimeP_MovieDate.Name = "dateTimeP_MovieDate";
            this.dateTimeP_MovieDate.Size = new System.Drawing.Size(338, 29);
            this.dateTimeP_MovieDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(55, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Çıkış Tarihi:";
            // 
            // txt_MovieDescription
            // 
            this.txt_MovieDescription.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MovieDescription.Location = new System.Drawing.Point(752, 14);
            this.txt_MovieDescription.Multiline = true;
            this.txt_MovieDescription.Name = "txt_MovieDescription";
            this.txt_MovieDescription.Size = new System.Drawing.Size(338, 107);
            this.txt_MovieDescription.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(652, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Konu:";
            // 
            // txt_MovieDuration
            // 
            this.txt_MovieDuration.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_MovieDuration.Location = new System.Drawing.Point(173, 75);
            this.txt_MovieDuration.Name = "txt_MovieDuration";
            this.txt_MovieDuration.Size = new System.Drawing.Size(338, 29);
            this.txt_MovieDuration.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Film Süresi dk:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(868, 242);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(184, 60);
            this.btn_Clear.TabIndex = 18;
            this.btn_Clear.Text = "Temizle";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Update.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(671, 242);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(184, 60);
            this.btn_Update.TabIndex = 17;
            this.btn_Update.Text = "Film Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_Delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(474, 242);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(184, 60);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "Film Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(165)))), ((int)(((byte)(175)))));
            this.btn_GetAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GetAll.ForeColor = System.Drawing.Color.Black;
            this.btn_GetAll.Location = new System.Drawing.Point(76, 242);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(184, 60);
            this.btn_GetAll.TabIndex = 8;
            this.btn_GetAll.Text = "Listele";
            this.btn_GetAll.UseVisualStyleBackColor = false;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 347);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 752);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMovies";
            this.Load += new System.EventHandler(this.FrmMovies_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Movie;
        private System.Windows.Forms.Button btn_Categorys;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_MovieTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_MovieDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MovieDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeP_MovieDate;
        private System.Windows.Forms.Label label5;
    }
}