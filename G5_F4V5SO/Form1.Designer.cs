
namespace G5_F4V5SO
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UjJatekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.másikSzövegfájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szövegfájlBetöltéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feltételekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tabla = new System.Windows.Forms.Panel();
            this.Startbtn = new System.Windows.Forms.Button();
            this.feladbtn = new System.Windows.Forms.Button();
            this.Cimlbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 238);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UjJatekToolStripMenuItem,
            this.másikSzövegfájlToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UjJatekToolStripMenuItem
            // 
            this.UjJatekToolStripMenuItem.Name = "UjJatekToolStripMenuItem";
            this.UjJatekToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.UjJatekToolStripMenuItem.Text = "Új játék";
            this.UjJatekToolStripMenuItem.Click += new System.EventHandler(this.UjJatekToolStripMenuItem_Click);
            // 
            // másikSzövegfájlToolStripMenuItem
            // 
            this.másikSzövegfájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szövegfájlBetöltéseToolStripMenuItem,
            this.feltételekToolStripMenuItem});
            this.másikSzövegfájlToolStripMenuItem.Name = "másikSzövegfájlToolStripMenuItem";
            this.másikSzövegfájlToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.másikSzövegfájlToolStripMenuItem.Text = "Másik szövegfájl";
            // 
            // szövegfájlBetöltéseToolStripMenuItem
            // 
            this.szövegfájlBetöltéseToolStripMenuItem.Name = "szövegfájlBetöltéseToolStripMenuItem";
            this.szövegfájlBetöltéseToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.szövegfájlBetöltéseToolStripMenuItem.Text = "Szövegfájl betöltése";
            this.szövegfájlBetöltéseToolStripMenuItem.Click += new System.EventHandler(this.szövegfájlBetöltéseToolStripMenuItem_Click);
            // 
            // feltételekToolStripMenuItem
            // 
            this.feltételekToolStripMenuItem.Name = "feltételekToolStripMenuItem";
            this.feltételekToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.feltételekToolStripMenuItem.Text = "Feltételek";
            this.feltételekToolStripMenuItem.Click += new System.EventHandler(this.feltételekToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.KilépésToolStripMenuItem_Click);
            // 
            // Tabla
            // 
            this.Tabla.Location = new System.Drawing.Point(327, 33);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(670, 237);
            this.Tabla.TabIndex = 6;
            // 
            // Startbtn
            // 
            this.Startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Startbtn.Location = new System.Drawing.Point(365, 260);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(260, 100);
            this.Startbtn.TabIndex = 7;
            this.Startbtn.Text = "Játék Indítása";
            this.Startbtn.UseVisualStyleBackColor = true;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // feladbtn
            // 
            this.feladbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.feladbtn.Location = new System.Drawing.Point(780, 341);
            this.feladbtn.Name = "feladbtn";
            this.feladbtn.Size = new System.Drawing.Size(117, 35);
            this.feladbtn.TabIndex = 8;
            this.feladbtn.Text = "Feladom";
            this.feladbtn.UseVisualStyleBackColor = true;
            this.feladbtn.Click += new System.EventHandler(this.Feladbtn_Click);
            // 
            // Cimlbl
            // 
            this.Cimlbl.AutoSize = true;
            this.Cimlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cimlbl.Location = new System.Drawing.Point(303, 180);
            this.Cimlbl.Name = "Cimlbl";
            this.Cimlbl.Size = new System.Drawing.Size(383, 67);
            this.Cimlbl.TabIndex = 0;
            this.Cimlbl.Text = "AKASZTÓFA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 539);
            this.Controls.Add(this.Cimlbl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.feladbtn);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabla);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Akasztófa the Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UjJatekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem másikSzövegfájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Panel Tabla;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button feladbtn;
        private System.Windows.Forms.ToolStripMenuItem szövegfájlBetöltéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feltételekToolStripMenuItem;
        private System.Windows.Forms.Label Cimlbl;
    }
}

