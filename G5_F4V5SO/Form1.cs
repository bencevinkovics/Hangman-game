using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_F4V5SO
{
    public partial class Form1 : Form
    {
        int hibaszam;
        string szofajl= "szolista.txt";
        public static string megfejtes = "----";

        List<String> szolista = new List<String>();
        List <Label> labelek = new List<Label>();
        List<Button> Billgombok;

        public Form1()
        {
            InitializeComponent();

            Billentyu();
            foreach (Button betu in Billgombok)
            {
                betu.Visible = false;
            }
            feladbtn.Visible = false;
        }

        public void Billentyu()
        {
            //billentyű betöltése
            Billgombok = new List<Button>();
            StreamReader bill = new StreamReader("kbd_hun.txt");

            while (!bill.EndOfStream)
            {
                int x = int.Parse(bill.ReadLine());
                int y = int.Parse(bill.ReadLine());
                int h = int.Parse(bill.ReadLine());
                int w = int.Parse(bill.ReadLine());
                string jel = bill.ReadLine();

                Button betu = new Button();
                betu.Name = betu.Text + "betu";
                betu.Top = y + 180;
                betu.Left = x + 90;
                betu.Width = w;
                betu.Height = h;
                betu.Text = jel;
                betu.Font = new Font(Font.FontFamily, 10, FontStyle.Bold);


                betu.Click += Betu_Click;
                Controls.Add(betu);
                Billgombok.Add(betu as Button);
            }

            bill.Close();

        }

        private void Betu_Click(object sender, EventArgs e)
        {
            //billentyű megnoymása
            Button megnyomott = (Button)sender;
            megnyomott.Enabled = false;
            string tipp = megnyomott.Text.ToLower();

            //jotipp
            if (megfejtes.IndexOf(char.Parse(tipp)) >= 0)
            {
                bool nyert = true;
                megnyomott.BackColor = Color.Green;
                foreach (Label lbl in labelek)
                {
                    if (lbl.Tag.ToString() == tipp) lbl.Text = tipp;
                    if (lbl.Text == "__") nyert = false;
                }

                //nyerés
                if (nyert == true)
                {
                    WinForm winform = new WinForm();
                    if (winform.ShowDialog() == DialogResult.Retry)
                    {
                        UjJatek();
                    }
                    else
                    {
                        this.Close();
                    }
                }

            }
            //rossz tipp
            else
            {
                megnyomott.BackColor = Color.Red;
                hibaszam++;
                Rajz();

                //vesztés
                if (hibaszam == 8)
                {
                    LoseForm loseform = new LoseForm();

                    if (loseform.ShowDialog() == DialogResult.Retry)
                    {
                        UjJatek();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

        }

        void Beolvasas()
        {
            //szövegfájl létezésének ellenőrzés
            if (File.Exists(szofajl) == false)
            {
                szofajl = "szolista.txt";
                MessageBox.Show("Hiba miatt visszaállt az eredeti szövegfájl.", "Hiba");
            }
            //szövegfájl üres-e
            if (new FileInfo(szofajl).Length ==0)
            {
                MessageBox.Show("A betölteni kívánt fájl üres. Visszatöltjük az eredetit szólistát.", "Hiba");
                szofajl = "szolista.txt";
            }
            //fájl beolvasása
            StreamReader sr = new StreamReader(szofajl, Encoding.UTF8);            
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine(); 
                //spec karakterek kivétele és kisbetűvé alakítása
                Regex rgx = new Regex("[^a-zA-Z]");
                sor = sor.ToLower();

                //ha nem üres a sor, szavak tömbbe
                if (!string.IsNullOrEmpty(sor))
                {
                    string[] szavak = sor.Split(' ');

                    foreach (string szo in szavak)
                    {                    
                    szolista.Add(szo);
                    }
                }
                
               
            }
            sr.Close();
            //random szó kiválasztása
            Random rnd = new Random();
            int listahossz = szolista.Count;
            megfejtes = szolista[rnd.Next(listahossz)];
        }

        void Betoltes()
        {
            //Random szó betöltése feladványként
            //kis vonalak kihelyezése
            Beolvasas();            
            char[] megfchar = megfejtes.ToCharArray();

            int eltolas = 0;
            foreach (char betu in megfchar)
            {

                Label lbl = new Label();               
                lbl.Tag = betu;
                lbl.Font = new Font(Font.FontFamily, 20, FontStyle.Bold);
                lbl.Width = 30;
                lbl.Height = 30;
                lbl.Text = "__";
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Left = eltolas * 30 + Tabla.Width / 5;
                lbl.Top = Tabla.Height / 2 - 15;
                Tabla.Controls.Add(lbl);
                labelek.Add(lbl as Label);
                eltolas++;
            }

        }
        
        private void Startbtn_Click(object sender, EventArgs e)
        {
            //játék indítás gomb új játékot indít
            UjJatek();            
        }

        private void Feladbtn_Click(object sender, EventArgs e)
        {
            //feladom gomb kirajzolja az embert és megmondja a megoldást
            hibaszam = 99;
            Rajz();
            if (MessageBox.Show("Legközelebb biztosan sikerül!" + Environment.NewLine + "A megfejtés: " + megfejtes + Environment.NewLine + "Mehet egy új játék?", "Nem gond", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UjJatek();

            }
            else { this.Close(); }
        }

        void Rajz()
        {
            //emberke rajzolása
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);

            if (hibaszam == 0)
            {
                g.Clear(BackColor);
            }

            if (hibaszam == 1)
            {
                //alap
                g.DrawLine(pen, 15, 180, 115, 180);
            }
            if (hibaszam == 2)
            {
                //oszlop
                g.DrawLine(pen, 65, 180, 65, 30);
                g.DrawLine(pen, 85, 180, 65, 160);
            }
            if (hibaszam == 3)
            {
                //felsoresz
                g.DrawLine(pen, 15, 30, 200, 30);
                g.DrawLine(pen, 85, 30, 65, 50);
            }
            if (hibaszam == 4)
            {
                //kotel
                g.DrawLine(pen, 185, 30, 185, 60);
            }
            if (hibaszam == 5)
            {
                //fej
                Brush brush = new SolidBrush(Color.Black);
                g.FillEllipse(brush, 170, 58, 30, 30);
                Pen arctoll = new Pen(Color.White, 1);
                g.DrawLine(arctoll, 176, 68, 182, 74);
                g.DrawLine(arctoll, 182, 68, 176, 74);
                g.DrawLine(arctoll, 194, 68, 188, 74);
                g.DrawLine(arctoll, 188, 68, 194, 74);
                g.DrawLine(arctoll, 180, 80, 190, 80);
            }
            if (hibaszam == 6)
            {
                //test
                g.DrawLine(pen, 185, 85, 185, 120);
            }
            if (hibaszam == 7)
            {
                //labak
                g.DrawLine(pen, 170, 150, 185, 120);
                g.DrawLine(pen, 200, 150, 185, 120);
            }
            if (hibaszam == 8)
            {
                //kezek
                g.DrawLine(pen, 170, 120, 185, 90);
                g.DrawLine(pen, 200, 120, 185, 90);
            }           

            //Tesztrajz
            if (hibaszam == 99)
            {
                g.DrawLine(pen, 15, 180, 115, 180);
                g.DrawLine(pen, 65, 180, 65, 30);
                g.DrawLine(pen, 15, 30, 200, 30);
                g.DrawLine(pen, 185, 30, 185, 60);
                Brush brush = new SolidBrush(Color.Black);
                g.FillEllipse(brush, 170, 58, 30, 30);
                Pen arctoll = new Pen(Color.White, 1);
                g.DrawLine(arctoll, 176, 68, 182, 74);
                g.DrawLine(arctoll, 182, 68, 176, 74);
                g.DrawLine(arctoll, 194, 68, 188, 74);
                g.DrawLine(arctoll, 188, 68, 194, 74);
                g.DrawLine(arctoll, 180, 80, 190, 80);
                g.DrawLine(pen, 185, 85, 185, 120);
                g.DrawLine(pen, 170, 150, 185, 120);
                g.DrawLine(pen, 200, 150, 185, 120);
                g.DrawLine(pen, 170, 120, 185, 90);
                g.DrawLine(pen, 200, 120, 185, 90);
            }
        }

        void UjJatek()
        {
            //új játék
            hibaszam = 0;
            
            foreach (Button betu in Billgombok)
            {
                Controls.Remove(betu);
                betu.Enabled = true;
                betu.Visible = true;
            }

            foreach (Label lbl in labelek)
            {
                Tabla.Controls.Remove(lbl);
                lbl.Dispose();
            }
            feladbtn.Visible = true;
            Cimlbl.Visible = false;
            Startbtn.Visible = false;

            Billentyu();
            Rajz();
            Betoltes();
            

        }

        void Masikfile()
        {
            //másik szövegfile megnyitása
            OpenFileDialog fajl = new OpenFileDialog();
            fajl.Multiselect = false;
            fajl.InitialDirectory = "c:\\";
            //fajl.DefaultExt = "txt";
            fajl.Filter = "TXT files|*.txt";
            fajl.CheckFileExists = true;
            

            if (fajl.ShowDialog() == DialogResult.OK)
            {
                //kiterjesztés ellenőrzése
                string ext = Path.GetExtension(fajl.FileName);
                if (ext == ".txt")
                {                    
                    szofajl = fajl.FileName;
                    Beolvasas();
                    UjJatek();
                    MessageBox.Show("Új fájl betöltve.", "Kész");
                }
                else
                {
                    if (MessageBox.Show("Csak txt file-t tudsz betölteni " + ext, "Rossz formátum", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    {
                        Masikfile();
                    }
                }

            }
        }

        //menü gombok
        private void UjJatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjJatek();
        }


        private void szövegfájlBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masikfile();
        }

        private void KilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos kilpész?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
 
            }
        }

        private void feltételekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeltoltInfoForm feltoltinform = new FeltoltInfoForm();

            if (feltoltinform.ShowDialog() == DialogResult.OK) { }
        }
    }
}
