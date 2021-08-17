
namespace G5_F4V5SO
{
    partial class WinForm
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
            this.uj_btn = new System.Windows.Forms.Button();
            this.kilep_btn = new System.Windows.Forms.Button();
            this.kerdes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sikerült kitalálnod a szót! ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gratulálok! :)";
            // 
            // uj_btn
            // 
            this.uj_btn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.uj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uj_btn.Location = new System.Drawing.Point(35, 150);
            this.uj_btn.Name = "uj_btn";
            this.uj_btn.Size = new System.Drawing.Size(115, 40);
            this.uj_btn.TabIndex = 3;
            this.uj_btn.Text = "Új Játék";
            this.uj_btn.UseVisualStyleBackColor = true;
            // 
            // kilep_btn
            // 
            this.kilep_btn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.kilep_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.kilep_btn.Location = new System.Drawing.Point(195, 150);
            this.kilep_btn.Name = "kilep_btn";
            this.kilep_btn.Size = new System.Drawing.Size(115, 40);
            this.kilep_btn.TabIndex = 4;
            this.kilep_btn.Text = "Kilépés";
            this.kilep_btn.UseVisualStyleBackColor = true;
            // 
            // kerdes
            // 
            this.kerdes.AutoSize = true;
            this.kerdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kerdes.Location = new System.Drawing.Point(41, 79);
            this.kerdes.Name = "kerdes";
            this.kerdes.Size = new System.Drawing.Size(180, 25);
            this.kerdes.TabIndex = 5;
            this.kerdes.Text = "Mit szeretnél tenni?";
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 213);
            this.Controls.Add(this.kerdes);
            this.Controls.Add(this.kilep_btn);
            this.Controls.Add(this.uj_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyertél!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uj_btn;
        private System.Windows.Forms.Button kilep_btn;
        private System.Windows.Forms.Label kerdes;
    }
}