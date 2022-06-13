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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeatreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservationsLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieasyDataSet1 = new PresentationLayer.MovieasyDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetalj = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnTeatre = new System.Windows.Forms.Button();
            this.projectionTableAdapter = new PresentationLayer.MovieasyDataSet1TableAdapters.ProjectionTableAdapter();
            this.projectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddProjection = new System.Windows.Forms.Button();
            this.btnPregledFilmova = new System.Windows.Forms.Button();
            this.projectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieasyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieName,
            this.timeFromDataGridViewTextBoxColumn,
            this.timeToDataGridViewTextBoxColumn,
            this.TeatreName,
            this.ReservationsLeft});
            this.dataGridView1.DataSource = this.projectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // MovieName
            // 
            this.MovieName.DataPropertyName = "MovieName";
            this.MovieName.HeaderText = "Naslov";
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            // 
            // timeFromDataGridViewTextBoxColumn
            // 
            this.timeFromDataGridViewTextBoxColumn.DataPropertyName = "TimeFrom";
            this.timeFromDataGridViewTextBoxColumn.HeaderText = "Početak prikazivanja";
            this.timeFromDataGridViewTextBoxColumn.Name = "timeFromDataGridViewTextBoxColumn";
            // 
            // timeToDataGridViewTextBoxColumn
            // 
            this.timeToDataGridViewTextBoxColumn.DataPropertyName = "TimeTo";
            this.timeToDataGridViewTextBoxColumn.HeaderText = "Kraj prikazivanja";
            this.timeToDataGridViewTextBoxColumn.Name = "timeToDataGridViewTextBoxColumn";
            // 
            // TeatreName
            // 
            this.TeatreName.DataPropertyName = "TeatreName";
            this.TeatreName.HeaderText = "Kino";
            this.TeatreName.Name = "TeatreName";
            this.TeatreName.ReadOnly = true;
            // 
            // ReservationsLeft
            // 
            this.ReservationsLeft.DataPropertyName = "ReservationsLeft";
            this.ReservationsLeft.HeaderText = "Broj rezervacija";
            this.ReservationsLeft.Name = "ReservationsLeft";
            this.ReservationsLeft.ReadOnly = true;
            // 
            // projectionBindingSource
            // 
            this.projectionBindingSource.DataMember = "Projection";
            this.projectionBindingSource.DataSource = this.movieasyDataSet1;
            // 
            // movieasyDataSet1
            // 
            this.movieasyDataSet1.DataSetName = "MovieasyDataSet1";
            this.movieasyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filmovi";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(254, 18);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(101, 42);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Dodaj film";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
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
            this.btnDetalj.Location = new System.Drawing.Point(461, 371);
            this.btnDetalj.Name = "btnDetalj";
            this.btnDetalj.Size = new System.Drawing.Size(100, 45);
            this.btnDetalj.TabIndex = 7;
            this.btnDetalj.Text = "Detalji filma";
            this.btnDetalj.UseVisualStyleBackColor = true;
            this.btnDetalj.Click += new System.EventHandler(this.btnDetalj_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(12, 431);
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
            // btnTeatre
            // 
            this.btnTeatre.Location = new System.Drawing.Point(16, 371);
            this.btnTeatre.Name = "btnTeatre";
            this.btnTeatre.Size = new System.Drawing.Size(88, 45);
            this.btnTeatre.TabIndex = 10;
            this.btnTeatre.Text = "Uređivanje ponude kina";
            this.btnTeatre.UseVisualStyleBackColor = true;
            this.btnTeatre.Click += new System.EventHandler(this.btnTeatre_Click);
            // 
            // projectionTableAdapter
            // 
            this.projectionTableAdapter.ClearBeforeFill = true;
            // 
            // projectionBindingSource1
            // 
            this.projectionBindingSource1.DataMember = "Projection";
            this.projectionBindingSource1.DataSource = this.movieasyDataSet1;
            // 
            // buttonAddProjection
            // 
            this.buttonAddProjection.Location = new System.Drawing.Point(633, 100);
            this.buttonAddProjection.Name = "buttonAddProjection";
            this.buttonAddProjection.Size = new System.Drawing.Size(101, 42);
            this.buttonAddProjection.TabIndex = 11;
            this.buttonAddProjection.Text = "Dodaj projekciju";
            this.buttonAddProjection.UseVisualStyleBackColor = true;
            this.buttonAddProjection.Click += new System.EventHandler(this.buttonAddProjection_Click);
            // 
            // btnPregledFilmova
            // 
            this.btnPregledFilmova.Location = new System.Drawing.Point(633, 175);
            this.btnPregledFilmova.Name = "btnPregledFilmova";
            this.btnPregledFilmova.Size = new System.Drawing.Size(101, 40);
            this.btnPregledFilmova.TabIndex = 12;
            this.btnPregledFilmova.Text = "Pregled Filmova";
            this.btnPregledFilmova.UseVisualStyleBackColor = true;
            this.btnPregledFilmova.Click += new System.EventHandler(this.btnPregledFilmova_Click);
            // 
            // projectionBindingSource2
            // 
            this.projectionBindingSource2.DataSource = typeof(DataAccessLayer.Model.Projection);
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.Location = new System.Drawing.Point(16, 79);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerFilter.TabIndex = 14;
            this.dateTimePickerFilter.ValueChanged += new System.EventHandler(this.dateTimePickerFilter_ValueChanged);
            // 
            // MovieCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 488);
            this.Controls.Add(this.dateTimePickerFilter);
            this.Controls.Add(this.btnPregledFilmova);
            this.Controls.Add(this.buttonAddProjection);
            this.Controls.Add(this.btnTeatre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDetalj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MovieCatalog";
            this.Text = "MovieCatalog";
            this.Load += new System.EventHandler(this.MovieCatalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieasyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetalj;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnTeatre;
        private MovieasyDataSet1 movieasyDataSet1;
        private System.Windows.Forms.BindingSource projectionBindingSource;
        private MovieasyDataSet1TableAdapters.ProjectionTableAdapter projectionTableAdapter;
        private System.Windows.Forms.BindingSource projectionBindingSource1;
        private System.Windows.Forms.BindingSource projectionBindingSource2;
        private System.Windows.Forms.Button buttonAddProjection;
        private System.Windows.Forms.Button btnPregledFilmova;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeatreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationsLeft;
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
    }
}