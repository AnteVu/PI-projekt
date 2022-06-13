namespace PresentationLayer
{
    partial class FormAddProjection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTeatres = new System.Windows.Forms.ComboBox();
            this.comboBoxMovies = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(138, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj projekciju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Početni datum prikazivanja";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(62, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 43);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Location = new System.Drawing.Point(12, 446);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(87, 45);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "Pomoć?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(104, 131);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(121, 20);
            this.datePickerFrom.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Odabir dvorane";
            // 
            // datePickerTo
            // 
            this.datePickerTo.Location = new System.Drawing.Point(104, 178);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(121, 20);
            this.datePickerTo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Krajnji datum prikazivanja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Odabir kina";
            // 
            // comboBoxTeatres
            // 
            this.comboBoxTeatres.FormattingEnabled = true;
            this.comboBoxTeatres.Location = new System.Drawing.Point(137, 232);
            this.comboBoxTeatres.Name = "comboBoxTeatres";
            this.comboBoxTeatres.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeatres.TabIndex = 22;
            this.comboBoxTeatres.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTeatres_SelectionChangeCommitted);
            // 
            // comboBoxMovies
            // 
            this.comboBoxMovies.FormattingEnabled = true;
            this.comboBoxMovies.Location = new System.Drawing.Point(135, 84);
            this.comboBoxMovies.Name = "comboBoxMovies";
            this.comboBoxMovies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMovies.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odabir filma";
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.Location = new System.Drawing.Point(242, 131);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.Size = new System.Drawing.Size(79, 20);
            this.timePickerFrom.TabIndex = 25;
            // 
            // timePickerTo
            // 
            this.timePickerTo.Location = new System.Drawing.Point(242, 178);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.Size = new System.Drawing.Size(79, 20);
            this.timePickerTo.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(139, 284);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // FormAddProjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 503);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.timePickerTo);
            this.Controls.Add(this.timePickerFrom);
            this.Controls.Add(this.comboBoxMovies);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxTeatres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePickerTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePickerFrom);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddProjection";
            this.Text = "Dodavanje projekcije";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTeatres;
        private System.Windows.Forms.ComboBox comboBoxMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}