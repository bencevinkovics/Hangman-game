
namespace G5_F4V5SO
{
    partial class LoseForm
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
            this.uj_btn = new System.Windows.Forms.Button();
            this.kilep_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.megf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uj_btn
            // 
            this.uj_btn.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.uj_btn.Location = new System.Drawing.Point(35, 150);
            this.uj_btn.Name = "uj_btn";
            this.uj_btn.Size = new System.Drawing.Size(115, 40);
            this.uj_btn.TabIndex = 4;
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
            this.kilep_btn.TabIndex = 5;
            this.kilep_btn.Text = "Kilépés";
            this.kilep_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sajnos ez most nem sikerült :(";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mit szeretnél tenni?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "A megfejtés:";
            // 
            // megf
            // 
            this.megf.AutoSize = true;
            this.megf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.megf.Location = new System.Drawing.Point(146, 56);
            this.megf.Name = "megf";
            this.megf.Size = new System.Drawing.Size(53, 25);
            this.megf.TabIndex = 10;
            this.megf.Text = "teszt";
            // 
            // LoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 213);
            this.Controls.Add(this.megf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kilep_btn);
            this.Controls.Add(this.uj_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vesztettél";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uj_btn;
        private System.Windows.Forms.Button kilep_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label megf;
    }
}