namespace PRG282_Project_Group8
{
    partial class frmModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModules));
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.picStudents = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.picDashboard = new System.Windows.Forms.PictureBox();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnsearchModule = new System.Windows.Forms.Button();
            this.btnremoveModule = new System.Windows.Forms.Button();
            this.btnupdateModule = new System.Windows.Forms.Button();
            this.btndisplayModule = new System.Windows.Forms.Button();
            this.btnaddModule = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudents)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).BeginInit();
            this.pnlLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.picStudents);
            this.pnlStudents.Location = new System.Drawing.Point(265, 18);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(60, 77);
            this.pnlStudents.TabIndex = 31;
            // 
            // picStudents
            // 
            this.picStudents.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStudents.BackgroundImage")));
            this.picStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudents.Location = new System.Drawing.Point(0, 7);
            this.picStudents.Name = "picStudents";
            this.picStudents.Size = new System.Drawing.Size(62, 59);
            this.picStudents.TabIndex = 11;
            this.picStudents.TabStop = false;
            this.picStudents.Click += new System.EventHandler(this.picStudents_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.picDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(72, 18);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(60, 77);
            this.pnlDashboard.TabIndex = 30;
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
            this.pnlLogout.Location = new System.Drawing.Point(813, 18);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(60, 77);
            this.pnlLogout.TabIndex = 29;
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
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.picLogo);
            this.panel7.Location = new System.Drawing.Point(398, 18);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(156, 71);
            this.panel7.TabIndex = 28;
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
            // dgvModules
            // 
            this.dgvModules.BackgroundColor = System.Drawing.Color.White;
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(298, 172);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.Size = new System.Drawing.Size(575, 238);
            this.dgvModules.TabIndex = 38;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.pnlBottom.Location = new System.Drawing.Point(-1, 468);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(889, 44);
            this.pnlBottom.TabIndex = 37;
            // 
            // btnsearchModule
            // 
            this.btnsearchModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnsearchModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsearchModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearchModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearchModule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchModule.ForeColor = System.Drawing.Color.White;
            this.btnsearchModule.Location = new System.Drawing.Point(22, 373);
            this.btnsearchModule.Name = "btnsearchModule";
            this.btnsearchModule.Size = new System.Drawing.Size(195, 37);
            this.btnsearchModule.TabIndex = 36;
            this.btnsearchModule.Text = "Search Module";
            this.btnsearchModule.UseVisualStyleBackColor = false;
            // 
            // btnremoveModule
            // 
            this.btnremoveModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnremoveModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnremoveModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnremoveModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnremoveModule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremoveModule.ForeColor = System.Drawing.Color.White;
            this.btnremoveModule.Location = new System.Drawing.Point(22, 324);
            this.btnremoveModule.Name = "btnremoveModule";
            this.btnremoveModule.Size = new System.Drawing.Size(195, 37);
            this.btnremoveModule.TabIndex = 35;
            this.btnremoveModule.Text = "Remove Module";
            this.btnremoveModule.UseVisualStyleBackColor = false;
            // 
            // btnupdateModule
            // 
            this.btnupdateModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnupdateModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnupdateModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateModule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateModule.ForeColor = System.Drawing.Color.White;
            this.btnupdateModule.Location = new System.Drawing.Point(22, 271);
            this.btnupdateModule.Name = "btnupdateModule";
            this.btnupdateModule.Size = new System.Drawing.Size(195, 37);
            this.btnupdateModule.TabIndex = 34;
            this.btnupdateModule.Text = "Update Module";
            this.btnupdateModule.UseVisualStyleBackColor = false;
            // 
            // btndisplayModule
            // 
            this.btndisplayModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btndisplayModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndisplayModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndisplayModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplayModule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplayModule.ForeColor = System.Drawing.Color.White;
            this.btndisplayModule.Location = new System.Drawing.Point(22, 221);
            this.btndisplayModule.Name = "btndisplayModule";
            this.btndisplayModule.Size = new System.Drawing.Size(195, 37);
            this.btndisplayModule.TabIndex = 33;
            this.btndisplayModule.Text = "Display Modules";
            this.btndisplayModule.UseVisualStyleBackColor = false;
            // 
            // btnaddModule
            // 
            this.btnaddModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(68)))));
            this.btnaddModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnaddModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddModule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddModule.ForeColor = System.Drawing.Color.White;
            this.btnaddModule.Location = new System.Drawing.Point(22, 172);
            this.btnaddModule.Name = "btnaddModule";
            this.btnaddModule.Size = new System.Drawing.Size(195, 37);
            this.btnaddModule.TabIndex = 32;
            this.btnaddModule.Text = "Add Module";
            this.btnaddModule.UseVisualStyleBackColor = false;
            this.btnaddModule.Click += new System.EventHandler(this.btnaddModule_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.pnlTop.Location = new System.Drawing.Point(-1, 32);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(895, 44);
            this.pnlTop.TabIndex = 27;
            // 
            // frmModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 531);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlLogout);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnsearchModule);
            this.Controls.Add(this.btnremoveModule);
            this.Controls.Add(this.btnupdateModule);
            this.Controls.Add(this.btndisplayModule);
            this.Controls.Add(this.btnaddModule);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmModules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modules";
            this.pnlStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStudents)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDashboard)).EndInit();
            this.pnlLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox picStudents;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox picDashboard;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnsearchModule;
        private System.Windows.Forms.Button btnremoveModule;
        private System.Windows.Forms.Button btnupdateModule;
        private System.Windows.Forms.Button btndisplayModule;
        private System.Windows.Forms.Button btnaddModule;
        private System.Windows.Forms.Panel pnlTop;
    }
}