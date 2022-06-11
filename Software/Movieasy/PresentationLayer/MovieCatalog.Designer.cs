namespace PresentationLayer
{
    partial class MovieCatalog
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRez = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetalj = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies";
            // 
            // btnRez
            // 
            this.btnRez.Location = new System.Drawing.Point(205, 323);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(84, 45);
            this.btnRez.TabIndex = 2;
            this.btnRez.Text = "Rezerviraj";
            this.btnRez.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(295, 323);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(92, 45);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Kupi kartu";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(254, 18);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(101, 42);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Dodaj film";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 42);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Ažuriraj film";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(461, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Obriši film";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDetalj
            // 
            this.btnDetalj.Location = new System.Drawing.Point(460, 323);
            this.btnDetalj.Name = "btnDetalj";
            this.btnDetalj.Size = new System.Drawing.Size(100, 45);
            this.btnDetalj.TabIndex = 7;
            this.btnDetalj.Text = "Detalji filma";
            this.btnDetalj.UseVisualStyleBackColor = true;
            this.btnDetalj.Click += new System.EventHandler(this.btnDetalj_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 323);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 45);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Pomoć?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(151, 18);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(97, 42);
            this.btnAddGenre.TabIndex = 9;
            this.btnAddGenre.Text = "Dodaj Žanr";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // MovieCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 408);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDetalj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnRez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MovieCatalog";
            this.Text = "MovieCatalog";
            this.Load += new System.EventHandler(this.MovieCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetalj;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAddGenre;
    }
}