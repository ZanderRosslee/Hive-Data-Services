namespace PRG282_Project_Group8
{
    partial class frmStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            this.pnlModules = new System.Windows.Forms.Panel();
            this.picModules = new System.Windows.Forms.PictureBox();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.picDashboard = new System.Windows.Forms.PictureBox();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnaddStudent = new System.Windows.Forms.Button();
            this.btndisplayStudent = new System.Windows.Forms.Button();
            this.btnupdateStudent = new System.Windows.Forms.Button();
            this.btnremoveStudent = new System.Windows.Forms.Button();
            this.btnsearchStudent = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlModules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModules)).BeginInit();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).BeginInit();
            this.pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlModules
            // 
            this.pnlModules.Controls.Add(this.picModules);
            this.pnlModules.Location = new System.Drawing.Point(265, 13);
            this.pnlModules.Name = "pnlModules";
            this.pnlModules.Size = new System.Drawing.Size(60, 77);
            this.pnlModules.TabIndex = 18;
            // 
            // picModules
            // 
            this.picModules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picModules.BackgroundImage")));
            this.picModules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picModules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picModules.Location = new System.Drawing.Point(0, 8);
            this.picModules.Name = "picModules";
            this.picModules.Size = new System.Drawing.Size(62, 55);
            this.picModules.TabIndex = 11;
            this.picModules.TabStop = false;
            this.picModules.Click += new System.EventHandler(this.picModules_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.picDashboard);
            this.pnlStudents.Location = new System.Drawing.Point(72, 13);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(60, 77);
            this.pnlStudents.TabIndex = 17;
            // 
            // picDashboard
            // 
            this.picDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDashboard.BackgroundImage")));
            this.picDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDashboard.Location = new System.Drawing.Point(-2, 7);
            this.picDashboard.Name = "picDashboard";
            this.picDashboard.Size = new System.Drawing.Size(62, 57);
            this.picDashboard.TabIndex = 11;
            this.picDashboard.TabStop = false;
            this.picDashboard.Click += new System.EventHandler(this.picDashboard_Click);
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.picLogout);
            this.pnlLogout.Location = new System.Drawing.Point(813, 13);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(60, 77);
            this.pnlLogout.TabIndex = 16;
            // 
            // picLogout
            // 
            this.picLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogout.BackgroundImage")));
            this.picLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Location = new System.Drawing.Point(0, 6);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(62, 59);
            this.picLogout.TabIndex = 10;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picLogo);
            this.panel7.Location = new System.Drawing.Point(398, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 71);
            this.panel7.TabIndex = 15;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(-10, -69);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(207, 210);
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.pnlTop.Location = new System.Drawing.Point(-1, 27);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(895, 44);
            this.pnlTop.TabIndex = 14;
            // 
            // btnaddStudent
            // 
            this.btnaddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnaddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnaddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddStudent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddStudent.ForeColor = System.Drawing.Color.White;
            this.btnaddStudent.Location = new System.Drawing.Point(22, 167);
            this.btnaddStudent.Name = "btnaddStudent";
            this.btnaddStudent.Size = new System.Drawing.Size(195, 37);
            this.btnaddStudent.TabIndex = 20;
            this.btnaddStudent.Text = "Add Student";
            this.btnaddStudent.UseVisualStyleBackColor = false;
            this.btnaddStudent.Click += new System.EventHandler(this.btnaddStudent_Click);
            // 
            // btndisplayStudent
            // 
            this.btndisplayStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btndisplayStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndisplayStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndisplayStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplayStudent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplayStudent.ForeColor = System.Drawing.Color.White;
            this.btndisplayStudent.Location = new System.Drawing.Point(22, 216);
            this.btndisplayStudent.Name = "btndisplayStudent";
            this.btndisplayStudent.Size = new System.Drawing.Size(195, 37);
            this.btndisplayStudent.TabIndex = 21;
            this.btndisplayStudent.Text = "Display Students";
            this.btndisplayStudent.UseVisualStyleBackColor = false;
            // 
            // btnupdateStudent
            // 
            this.btnupdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnupdateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnupdateStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateStudent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnupdateStudent.Location = new System.Drawing.Point(22, 266);
            this.btnupdateStudent.Name = "btnupdateStudent";
            this.btnupdateStudent.Size = new System.Drawing.Size(195, 37);
            this.btnupdateStudent.TabIndex = 22;
            this.btnupdateStudent.Text = "Update Student";
            this.btnupdateStudent.UseVisualStyleBackColor = false;
            this.btnupdateStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnremoveStudent
            // 
            this.btnremoveStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnremoveStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnremoveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoveStudent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveStudent.ForeColor = System.Drawing.Color.White;
            this.btnremoveStudent.Location = new System.Drawing.Point(22, 319);
            this.btnremoveStudent.Name = "btnremoveStudent";
            this.btnremoveStudent.Size = new System.Drawing.Size(195, 37);
            this.btnremoveStudent.TabIndex = 23;
            this.btnremoveStudent.Text = "Remove Student";
            this.btnremoveStudent.UseVisualStyleBackColor = false;
            // 
            // btnsearchStudent
            // 
            this.btnsearchStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnsearchStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearchStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchStudent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnsearchStudent.Location = new System.Drawing.Point(22, 368);
            this.btnsearchStudent.Name = "btnsearchStudent";
            this.btnsearchStudent.Size = new System.Drawing.Size(195, 37);
            this.btnsearchStudent.TabIndex = 24;
            this.btnsearchStudent.Text = "Search Student";
            this.btnsearchStudent.UseVisualStyleBackColor = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.pnlBottom.Location = new System.Drawing.Point(-1, 463);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(889, 44);
            this.pnlBottom.TabIndex = 25;
            // 
            // dgvStudents
            // 
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(298, 167);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(575, 238);
            this.dgvStudents.TabIndex = 26;
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 531);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnsearchStudent);
            this.Controls.Add(this.btnremoveStudent);
            this.Controls.Add(this.btnupdateStudent);
            this.Controls.Add(this.btndisplayStudent);
            this.Controls.Add(this.btnaddStudent);
            this.Controls.Add(this.pnlModules);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlLogout);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.pnlModules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picModules)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).EndInit();
            this.pnlLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModules;
        private System.Windows.Forms.PictureBox picModules;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnaddStudent;
        private System.Windows.Forms.Button btndisplayStudent;
        private System.Windows.Forms.Button btnupdateStudent;
        private System.Windows.Forms.Button btnremoveStudent;
        private System.Windows.Forms.Button btnsearchStudent;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}