using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Galmun_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        void InitCustomLabelFont()
        {

        //Select your font from the resources.
        //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.Mechanical_Machine.Length;

        // create a buffer to read in to
            byte[] fontdata = Properties.Resources.Mechanical_Machine;

        // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            

        // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

        // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            fontLength = Properties.Resources.Audiowide_Regular.Length;
            fontdata = Properties.Resources.Audiowide_Regular;
            data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc2.AddMemoryFont(data, fontLength);
        }

        void Ascunde()
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            pictureBox1.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            Credits.Visible = false;
            save_G.Visible = false;
            save_G.Enabled = false;


        }

        void Activeaza()
        {
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            Credits.Visible = true;
            Credits.Enabled = true;
            popInfo.Visible = false;
            CreditsInfo.Visible = false;
            P.Visible = false;
            U.Visible = false;
            save_G.Visible = true;
            save_G.Enabled = true;

            int i;
            for (i = 1; i <= nEuropa; i++)
            {
                labE[i].Visible = false;
                labE[i].Enabled = false;
            }
            for (i = 1; i <= nAmerica; i++)
            {
                labAm[i].Visible = false;
                labAm[i].Enabled = false;
            }
            for (i = 1; i <= nAfrica; i++)
            {
                labAf[i].Visible = false;
                labAf[i].Enabled = false;
            }
            for (i = 1; i <= nAsia; i++)
            {
                labAs[i].Visible = false;
                labAs[i].Enabled = false;
            }
            for (i = 1; i <= nAsiaP; i++)
            {
                labAsP[i].Visible = false;
                labAsP[i].Enabled = false;
            }
        }

        public string Filter(string s)
        {
            int i;
            if(s.Contains('.'))
            {
                string[] bits= s.Split('.');
                s = "";
                s = s + bits[0];
                for (i = 1; i < bits.Length; i++)
                    s = s + ' ' + bits[i];
                return s;
            }
            else
                return s; 
        }

        void InitializareMain()
        {
            InitCustomLabelFont();
            label1.Left = this.Width / 2 - label1.Width / 2;
            button2.Left = this.Width / 2 - button2.Width / 2;
            pictureBox1.Left = this.Width / 2 - pictureBox1.Width / 2;
            button1.Left = this.Width / 2 - button1.Width / 2;
            button3.Left = pictureBox1.Left - button3.Width -50;
            button4.Left = button3.Left + 20;
            button6.Left = button3.Left - 50;
            button5.Left = pictureBox1.Left + pictureBox1.Width + 50;
            button7.Left = button5.Left + 30;
            
            popInfo.Width = this.Width/5 ;
            popInfo.Height = this.Height/4 ;
            popInfo.BorderStyle = BorderStyle.FixedSingle;
            popInfo.Top = 0;
            popInfo.Left = 0;
            popInfo.BackgroundImage = Image.FromFile(@"Resources/back.png");
            popInfo.BackgroundImageLayout = ImageLayout.Stretch;
            popInfo.BackColor = Color.Black;
            
            NumeDInfo.Top = popInfo.Top + d;
            NumeDInfo.Left = popInfo.Left + d/5;
            NumeDInfo.Text = "";
            NumeDInfo.BackColor = Color.Transparent;
            NumeDInfo.ForeColor = System.Drawing.Color.Black;
            
            
            TaraInfo.Top = popInfo.Top + 3* d;
            TaraInfo.Left = popInfo.Left + d;
            TaraInfo.Text = "";
            TaraInfo.BackColor = Color.Transparent;
            
            nrDivInfo.Top =  popInfo.Top + 5 * d;
            nrDivInfo.Left = popInfo.Left + popInfo.Width / 2 - 2*d;
            nrDivInfo.Text = "";
            nrDivInfo.ForeColor = NumeDInfo.ForeColor = TaraInfo.ForeColor = Color.Black;
            nrDivInfo.Font = NumeDInfo.Font = TaraInfo.Font = new Font("Century", 20);
            nrDivInfo.AutoSize = NumeDInfo.AutoSize = TaraInfo.AutoSize = true;
            nrDivInfo.BackColor = Color.Transparent;
            
            combatInfo.Top = popInfo.Top + 7 * d;
            combatInfo.Left = popInfo.Left + popInfo.Width / 2 - 2 * d;
            combatInfo.Text = "";
            combatInfo.ForeColor = Color.Black;
            combatInfo.Font = NumeDInfo.Font;
            combatInfo.AutoSize = true;
            combatInfo.BackColor = Color.Transparent;


            Credits.Text = "Credits";
            Credits.Font = new Font("Palatino Linotype", 20,FontStyle.Bold);
            Credits.AutoSize = true;
            Credits.ForeColor = button1.ForeColor;
            Credits.Top = button1.Top - button1.Height - d / 2;
            Credits.Left = button1.Left -d/3;

            Back.Text = "<";
            Back.Width = 2 * d;
            Back.Height = 2 * d;
            Back.ForeColor = Color.White;
            Back.BackColor = Color.Black;
            Back.Font = new Font("Arial", 15);
            Back.Left = this.Width -  Minim.Width- 2*d + d/2;
            Back.Top = this.Height - Back.Height-d;

            Minim.Text = "-";
            Minim.Width = 2 * d;
            Minim.Height = 2 * d;
            Minim.ForeColor = Color.White;
            Minim.BackColor = Color.Black;
            Minim.Font = new Font("Arial", 15);
            Minim.Left = this.Width - Minim.Width - d;
            Minim.Top = this.Height - Minim.Height - d;

            Attack.Left = popInfo.Left + popInfo.Width/2 - Attack.Width/2;
            Attack.Top = popInfo.Top + popInfo.Height - Attack.Height;
            Attack.Text = "Attack";
            Attack.ForeColor = Color.Black;
            Attack.AutoSize = true;
            Attack.BackColor = Color.Transparent;

            VS.Text = "Vs";
            VS.AutoSize = true;
            VS.ForeColor = Color.Black;
            VS.BackColor = Color.Transparent;
            VS.Font = new Font("Century", 18);
            VS.Left = this.Width/2+d/2;
            VS.Top = this.Height/2-2*d;

            Fight.Text = "FIGHT!";
            Fight.AutoSize = true;
            Fight.ForeColor = Color.Black;
            Fight.BackColor = Color.Transparent;
            Fight.Font = VS.Font;
            Fight.Left = this.Width / 2 + d/2;
            Fight.Top = this.Height / 2 + d/2;


            
            //Inptu 1;
            inputDiv.Left = nrDivInfo.Left + 2 * d;
            inputDiv.Top = nrDivInfo.Top ;
            inputDiv.Width = d;
            inputDiv.MaxLength = 2;
            inputDiv.Mask = "00";
            inputDiv.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //Input 2;
            inputAtt.Left = U.Left + 2 * d;
            inputAtt.Top = U.Top + 3 * d + d / 2;
            inputAtt.Width = d;
            inputAtt.MaxLength = 2;
            inputAtt.Mask = "00";
            inputAtt.Font = editDiv.Font;
            //Input 3;
            inputComb.Left = combatInfo.Left + 4 * d;
            inputComb.Top = combatInfo.Top;
            inputComb.Width = d+d/3;
            inputComb.MaxLength = 2;
            inputComb.Mask = "000";
            inputComb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            editDiv.Left = inputDiv.Left + d;
            editDiv.Top = inputDiv.Top;
            editDiv.Text = "edit";
            editDiv.ForeColor = Color.Black;
            editDiv.Width = 2 * d;
            editDiv.BackColor = Color.Transparent;

            editComb.Left = inputComb.Left + inputComb.Width;
            editComb.Top = inputComb.Top;
            editComb.Text = "edit";
            editComb.ForeColor = Color.Black;
            editComb.Width = 2 * d;
            editComb.BackColor = Color.Transparent;

            editAtt.Left = U.Left + inputAtt.Width +2*d;
            editAtt.Top = U.Top + 3*d+d/2;
            editAtt.Text = "edit";
            editAtt.Font = editDiv.Font;
            editAtt.ForeColor = Color.Black;
            editAtt.Width = 2 * d;
            editAtt.BackColor = Color.Transparent;

            Bonus1.Left = U.Left +d/2 ;
            Bonus1.Top = U.Top + 5*d;
            Bonus1.ForeColor = Color.White;
            Bonus1.Width = 2 * d;
            Bonus1.AutoSize = true;
            Bonus1.Checked = false;
            Bonus1.BackColor = Color.Transparent;

            Bonus2.Left = Bonus1.Left + P.Left - U.Left;
            Bonus2.Top = U.Top + 5 * d;
            Bonus2.ForeColor = Color.White;
            Bonus2.Width = 2 * d;
            Bonus2.AutoSize = true;
            Bonus2.Checked = false;
            Bonus2.BackColor = Color.Transparent;

            BonusTx1.Left = U.Left + d / 2 +d;
            BonusTx1.Top = U.Top + 5 * d;
            BonusTx1.ForeColor = Color.Green;
            BonusTx1.Width = 2 * d;
            BonusTx1.AutoSize = true;
            BonusTx1.Font = editAtt.Font;
            BonusTx1.Text = "(+10 Combat)";
            BonusTx1.BackColor = Color.Transparent;

            BonusTx2.Left = U.Left + d / 2 + d + P.Left - U.Left;
            BonusTx2.Top = U.Top + 5 * d;
            BonusTx2.ForeColor = Color.Green;
            BonusTx2.Width = 2 * d;
            BonusTx2.AutoSize = true;
            BonusTx2.Font = editAtt.Font;
            BonusTx2.Text = "(+10 Combat)";
            BonusTx2.BackColor = Color.Transparent;
            
            //Pierderi 1
            Deaths1.Left = inputAtt.Left;
            Deaths1.Top = editAtt.Top;
            Deaths1.ForeColor = Color.Red;
            Deaths1.Width = 2 * d;
            Deaths1.AutoSize = true;
            Deaths1.Font = new Font("Century", 12);
            Deaths1.Text = "(-"+Los1.ToString()+")";
            Deaths1.BackColor = Color.Transparent;

            //Pierderi 2
            Deaths2.Left = inputAtt.Left + P.Left - U.Left;
            Deaths2.Top = editAtt.Top;
            Deaths2.ForeColor = Color.Red;
            Deaths2.Width = 2 * d;
            Deaths2.AutoSize = true;
            Deaths2.Font = Deaths1.Font;
            Deaths2.Text = "(-" + Los2.ToString() + ")";
            Deaths2.BackColor = Color.Transparent;

            W = this.Width / 3; // latime fereastra raport
            H = this.Height / 3; // inaltime fereastra raport


            U.AutoSize = true;          //U = Atacator
            U.ForeColor = Color.Black;
            U.Font = new Font("Century", 19);
            U.Text = "Tara" + '\n' + "(" + "Provincie" + ")" + '\n' + "Nr.Div";
            U.Top = this.Height/2-H/2 + 2 * d;
            U.Left = this.Width/2-W/2 - 2 * d;
            U.BackgroundImage = Image.FromFile(@"Resources/back.png");
            U.BackgroundImageLayout = ImageLayout.Stretch;
            U.BorderStyle = BorderStyle.FixedSingle;

            P.AutoSize = true;          //P = Atacat
            P.Font = U.Font;
            P.ForeColor = Color.Black;   
            P.Text = "Tara" + '\n' + "(" + "Provincie" + ")" + '\n' + "Nr.Div";
            P.Top = U.Top;
            P.Left = this.Width/2 + W/2 - 5 * d;
            P.BackgroundImage = Image.FromFile(@"Resources/back.png");
            P.BackgroundImageLayout = ImageLayout.Stretch;
            P.BorderStyle = BorderStyle.FixedSingle;

            //Raportul 1
            Raport1.Left = U.Left;
            Raport1.Top = U.Top +7*d;
            Raport1.Text = "RAPORT1";
            Raport1.UseCompatibleTextRendering = true;
            Raport1.Font = U.Font;
            Raport1.BackColor = Color.Transparent;
            Raport1.ForeColor = Color.Black;
            Raport1.AutoSize = true;

            //Raportul 2 
            Raport2.Left = P.Left;
            Raport2.Top = U.Top + 7*d;
            Raport2.UseCompatibleTextRendering = true;
            Raport2.Text = "RAPORT2";
            Raport2.Font = Raport1.Font;
            Raport2.BackColor = Color.Transparent;
            Raport2.ForeColor = Color.Black;
            Raport2.AutoSize = true;

            CreditsInfo.Text = "< Hello World! >" + '\n' + '\n' + "My name is Adam Adrian," + '\n' + "student at CNMK Galati. " + '\n' + "This was an experiment and a good way " + '\n' + "to learn a lot of things" + '\n' + "about programming.";
            CreditsInfo.ForeColor = Color.Orange;
            CreditsInfo.BackColor = Color.Transparent;
            CreditsInfo.Font = new Font(pfc2.Families[0], 30);
            CreditsInfo.Left = 2 * d;
            CreditsInfo.Top = 2 * d;
            CreditsInfo.AutoSize = true;
            CreditsInfo.UseCompatibleTextRendering = true;

            CreditsInfo2.Text = "Here are my contact info : " + '\n' + "Facebook: Adrian Adam" + '\n' + "Instagram: adrian.adam.c" + '\n' + "Mail: adrian_etto@yahoo.com";
            CreditsInfo2.ForeColor = Color.Orange;
            CreditsInfo2.BackColor = Color.Transparent;
            CreditsInfo2.Font = new Font(pfc2.Families[0], 30);
            CreditsInfo2.Left = 2 * d;
            CreditsInfo2.Top = this.Height / 2 +5*d;
            CreditsInfo2.AutoSize = true;
            CreditsInfo2.UseCompatibleTextRendering = true;

            load_G.Top = button2.Top+load_G.Height/2;
            load_G.Left = button2.Left;

            new_G.Top = load_G.Top - new_G.Height - 10;
            new_G.Left = button2.Left;

            save_G.Top = Credits.Top - save_G.Height - 10;
            save_G.Left = Credits.Left-5;

            save_G.Visible = false;
            save_G.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;
            Credits.Visible = false;
            Credits.Enabled = false;
            popInfo.Visible = false;
            inputDiv.Visible = false;
            inputDiv.Enabled = false;
            inputAtt.Visible = false;
            inputAtt.Enabled = false;
            editDiv.Visible = false;
            editDiv.Enabled = false;
            editComb.Visible = false;
            editComb.Enabled = false;
            inputComb.Visible = false;
            inputComb.Enabled = false;
            U.Visible = false;
            P.Visible = false;
            Back.Visible = false;
            Back.Enabled = false;
            VS.Visible = false;
            VS.Enabled = false;
            Fight.Visible = false;
            Fight.Enabled = false;
            CreditsInfo.Visible = false;
            Deaths1.Visible = false;
            Deaths2.Visible = false;
            Raport1.Visible = false;
            Raport1.Enabled = false;
            Raport2.Visible = false;
            Raport2.Enabled = false;
            pb.Visible = false;
         

            this.Controls.Add(popInfo);
            popInfo.Controls.Add(TaraInfo);
            popInfo.Controls.Add(NumeDInfo);
            popInfo.Controls.Add(nrDivInfo);
            popInfo.Controls.Add(combatInfo);
            popInfo.Controls.Add(inputDiv);
            popInfo.Controls.Add(inputComb);
            popInfo.Controls.Add(editDiv);
            popInfo.Controls.Add(editComb);
            popInfo.Controls.Add(Attack);
            U.Controls.Add(editAtt);
            U.Controls.Add(inputAtt);
            U.Controls.Add(Bonus1);
            U.Controls.Add(BonusTx1);
            U.Controls.Add(Deaths1);
            P.Controls.Add(Bonus2);
            P.Controls.Add(BonusTx2);
            P.Controls.Add(Deaths2);
            this.Controls.Add(VS);
            this.Controls.Add(P);
            this.Controls.Add(U);
            this.Controls.Add(Back);
            this.Controls.Add(Minim);
            this.Controls.Add(Fight);
            this.Controls.Add(Credits);
            this.Controls.Add(Raport1);
            this.Controls.Add(Raport2);
            this.Controls.Add(pb);
            pb.Controls.Add(CreditsInfo);
            pb.Controls.Add(CreditsInfo2);
            

            editDiv.Click += new EventHandler(edit_Click);
            editAtt.Click += new EventHandler(edit2_Click);
            editComb.Click += new EventHandler(edit3_Click);
            Back.Click += new EventHandler(back_Click);
            Minim.Click += new EventHandler(minimize_Click);
            Attack.Click += new EventHandler(attack_Click);
            VS.Click += new EventHandler(vs_Click);
            Credits.Click += new EventHandler(Credits_Click);
            Fight.Click += new EventHandler(fight_Click);
            Raport1.Click += new EventHandler(Surr_Click);
            Raport2.Click += new EventHandler(Run_Click);
        }

        void citire(StreamReader fe, StreamReader fam , StreamReader faf ,StreamReader fas, StreamReader fasP)
        {

            Image myimageE = new Bitmap(@"Resources\europa.png");
            Image myimageAm = new Bitmap(@"Resources\america.png");
            Image myimageAf = new Bitmap(@"Resources\africa.png");
            Image myimageAs = new Bitmap(@"Resources\asia.png");
            Image myimageAsP = new Bitmap(@"Resources\asiaP.png");

            double Xi = this.Width, Yi = this.Height;
            string text;
            int i=0;
            while((text = fe.ReadLine()) !=null)
            {
                i++;
                string[] bits = text.Split(' ');
                xE[i]=int.Parse(bits[0]);
                yE[i]=int.Parse(bits[1]);
                taraE[i] = bits[2];
                nrDivE[i] = int.Parse(bits[3]);
                numePE[i] = bits[4];
                combatE[i] = int.Parse(bits[5]);
                cul = bits[6];
                

                labE[i] = new Label();
                labE[i].Left = (int)((Xi / myimageE.Width) * xE[i]);
                labE[i].Top = (int)((Yi / myimageE.Height) * yE[i]);
                labE[i].Width = d;
                labE[i].Height = d;
                labE[i].Top = labE[i].Top - labE[i].Width / 2;
                labE[i].Left = labE[i].Left - labE[i].Height / 2;
                labE[i].Text = nrDivE[i].ToString();
                labE[i].ForeColor = Color.White;
                labE[i].TextAlign = ContentAlignment.MiddleCenter;
                labE[i].BorderStyle = BorderStyle.Fixed3D;
                labE[i].BackColor = System.Drawing.ColorTranslator.FromHtml(cul);
                labE[i].AutoSize = true;
                labE[i].Font = new Font("Arial", 11, FontStyle.Bold);
                
                labE[i].Visible = false;
                labE[i].Enabled = false;

                this.Controls.Add(labE[i]);
                labE[i].Click += new EventHandler(lab_Click);
                labE[i].Cursor = Cursors.Hand;
            }
            nEuropa = i;

            i = 0;
            while ((text = fam.ReadLine()) != null)
            {
                i++;
                string[] bits = text.Split(' ');
                xAm[i] = int.Parse(bits[0]);
                yAm[i] = int.Parse(bits[1]);
                taraAm[i] = bits[2];
                nrDivAm[i] = int.Parse(bits[3]);
                numePAm[i] = bits[4];
                combatAm[i] = int.Parse(bits[5]);
                cul = bits[6];

                labAm[i] = new Label();
                labAm[i].Left = (int)((Xi / myimageAm.Width) * xAm[i]);
                labAm[i].Top = (int)((Yi / myimageAm.Height) * yAm[i]);
                labAm[i].Width = d;
                labAm[i].Height = d;
                labAm[i].Top = labAm[i].Top - labAm[i].Width / 2;
                labAm[i].Left = labAm[i].Left - labAm[i].Height / 2;
                labAm[i].Text = nrDivAm[i].ToString();
                labAm[i].ForeColor = Color.White;
                labAm[i].TextAlign = ContentAlignment.MiddleCenter;
                labAm[i].BorderStyle = BorderStyle.Fixed3D;
                labAm[i].BackColor = System.Drawing.ColorTranslator.FromHtml(cul);
                labAm[i].AutoSize = true;
                labAm[i].Font = labE[1].Font;

                labAm[i].Visible = false;
                labAm[i].Enabled = false;

                this.Controls.Add(labAm[i]);
                labAm[i].Click += new EventHandler(lab_Click);
                labAm[i].Cursor = Cursors.Hand;
            }
            nAmerica = i;

            i = 0;
            while ((text = faf.ReadLine()) != null)
            {
                i++;
                string[] bits = text.Split(' ');
                xAf[i] = int.Parse(bits[0]);
                yAf[i] = int.Parse(bits[1]);
                taraAf[i] = bits[2];
                nrDivAf[i] = int.Parse(bits[3]);
                numePAf[i] = bits[4];
                combatAf[i] = int.Parse(bits[5]);
                cul = bits[6];

                labAf[i] = new Label();
                labAf[i].Left = (int)((Xi / myimageAf.Width) * xAf[i]);
                labAf[i].Top = (int)((Yi / myimageAf.Height) * yAf[i]);
                labAf[i].Width = d;
                labAf[i].Height = d;
                labAf[i].Top = labAf[i].Top - labAf[i].Width / 2;
                labAf[i].Left = labAf[i].Left - labAf[i].Height / 2;
                labAf[i].Text = nrDivAf[i].ToString();
                labAf[i].ForeColor = Color.White;
                labAf[i].TextAlign = ContentAlignment.MiddleCenter;
                labAf[i].BorderStyle = BorderStyle.Fixed3D;
                labAf[i].BackColor = System.Drawing.ColorTranslator.FromHtml(cul);
                labAf[i].AutoSize = true;
                labAf[i].Font = labE[1].Font;

                labAf[i].Visible = false;
                labAf[i].Enabled = false;

                this.Controls.Add(labAf[i]);
                labAf[i].Click += new EventHandler(lab_Click);
                labAf[i].Cursor = Cursors.Hand;
            }
            nAfrica = i;

            i = 0;
            while ((text = fas.ReadLine()) != null)
            {
                i++;
                string[] bits = text.Split(' ');
                xAs[i] = int.Parse(bits[0]);
                yAs[i] = int.Parse(bits[1]);
                taraAs[i] = bits[2];
                nrDivAs[i] = int.Parse(bits[3]);
                numePAs[i] = bits[4];
                combatAs[i] = int.Parse(bits[5]);
                cul = bits[6];
                

                labAs[i] = new Label();
                labAs[i].Left = (int)((Xi / myimageAs.Width) * xAs[i]);
                labAs[i].Top = (int)((Yi / myimageAs.Height) * yAs[i]);
                labAs[i].Width = d;
                labAs[i].Height = d;
                labAs[i].Top = labAs[i].Top - labAs[i].Width / 2;
                labAs[i].Left = labAs[i].Left - labAs[i].Height / 2;
                labAs[i].Text = nrDivAs[i].ToString();
                labAs[i].ForeColor = Color.White;
                labAs[i].TextAlign = ContentAlignment.MiddleCenter;
                labAs[i].BorderStyle = BorderStyle.Fixed3D;
                labAs[i].BackColor = System.Drawing.ColorTranslator.FromHtml(cul);
                labAs[i].AutoSize = true;
                labAs[i].Font = labE[1].Font;

                labAs[i].Visible = false;
                labAs[i].Enabled = false;

                this.Controls.Add(labAs[i]);
                labAs[i].Click += new EventHandler(lab_Click);
                labAs[i].Cursor = Cursors.Hand;

            }
            nAsia = i;

            i = 0;
            while ((text = fasP.ReadLine()) != null)
            {
                i++;
                string[] bits = text.Split(' ');
                xAsP[i] = int.Parse(bits[0]);
                yAsP[i] = int.Parse(bits[1]);
                taraAsP[i] = bits[2];
                nrDivAsP[i] = int.Parse(bits[3]);
                numePAsP[i] = bits[4];
                combatAsP[i] = int.Parse(bits[5]);
                cul = bits[6];

                labAsP[i] = new Label();
                labAsP[i].Left = (int)((Xi / myimageAsP.Width) * xAsP[i]);
                labAsP[i].Top = (int)((Yi / myimageAsP.Height) * yAsP[i]);
                labAsP[i].Width = d;
                labAsP[i].Height = d;
                labAsP[i].Top = labAsP[i].Top - labAsP[i].Width / 2;
                labAsP[i].Left = labAsP[i].Left - labAsP[i].Height / 2;
                labAsP[i].Text = nrDivAsP[i].ToString();
                labAsP[i].ForeColor = Color.White;
                labAsP[i].TextAlign = ContentAlignment.MiddleCenter;
                labAsP[i].BorderStyle = BorderStyle.Fixed3D;
                labAsP[i].BackColor = System.Drawing.ColorTranslator.FromHtml(cul);
                labAsP[i].AutoSize = true;
                labAsP[i].Font = labE[1].Font;

                labAsP[i].Visible = false;
                labAsP[i].Enabled = false;

                this.Controls.Add(labAsP[i]);
                labAsP[i].Click += new EventHandler(lab_Click);
                labAsP[i].Cursor = Cursors.Hand;
            }
            nAsiaP = i;


            fe.Close();
            fam.Close();
            faf.Close();
            fas.Close();
            fasP.Close();
        }

        PrivateFontCollection pfc = new PrivateFontCollection();
        PrivateFontCollection pfc2 = new PrivateFontCollection();
        Random rnd = new Random();
        bool fs = false;
        bool e1 =false, e2 = false, e3 = false,rap=false;
        int W, H;
        int Rounds; //(1-5)
        int Bulan; //(0-50)
        float A, B;
        int Ca, Cb,Win;
        float Los1, Los2;
        int pmap, pindex,pNrD,pComb;
        string ptara,pprov;
        int umap, uindex,uNrD,uComb;
        string rtara;
        int rindex,rmap;
        string cul;
        string utara,uprov;
        int nEuropa,nAsia,nAsiaP,nAmerica,nAfrica;
        int indexE, indexAm, indexAf, indexAs, indexAsP;
        int mapa;
        Color cul1, cul2;
        Button editDiv = new Button();
        Button editAtt = new Button();
        Button editComb = new Button();
        Button Back = new Button();
        Button Minim = new Button();
        Button Attack = new Button();
        Button VS = new Button();
        Button Fight = new Button();
        Button Credits = new Button();
        Button Raport1 = new Button(); // Vic/Los 1
        Button Raport2 = new Button(); // Vic/Los 2
        CheckBox Bonus1 = new CheckBox();
        CheckBox Bonus2 = new CheckBox();
        MaskedTextBox inputDiv = new MaskedTextBox();
        MaskedTextBox inputAtt = new MaskedTextBox();
        MaskedTextBox inputComb = new MaskedTextBox();
        PictureBox popInfo = new PictureBox();
        PictureBox pb = new PictureBox();
        Label TaraInfo=new Label();
        Label NumeDInfo = new Label();
        Label nrDivInfo = new Label();
        Label combatInfo = new Label();
        Label P = new Label();
        Label U = new Label();
        Label BonusTx1 = new Label();
        Label BonusTx2 = new Label();
        Label CreditsInfo = new Label();
        Label CreditsInfo2 = new Label();
        Label Deaths1 = new Label();
        Label Deaths2 = new Label();

        Label[] labE = new Label[112];
        Label[] labAm = new Label[17];
        Label[] labAf = new Label[18];
        Label[] labAs = new Label[21];
        Label[] labAsP = new Label[18];

        string[] taraE = new string[112];
        string[] taraAm = new string[17];
        string[] taraAf = new string[18];
        string[] taraAs = new string[21];
        string[] taraAsP = new string[18];

        int[] nrDivE = new int[112];
        int[] nrDivAm = new int[17];
        int[] nrDivAf = new int[18];
        int[] nrDivAs = new int[21];
        int[] nrDivAsP = new int[18];

        string[] numePE = new string[112];
        string[] numePAm = new string[17];
        string[] numePAf = new string[18];
        string[] numePAs = new string[21];
        string[] numePAsP = new string[18];

        int[] combatE = new int[112];
        int[] combatAm = new int[17];
        int[] combatAf = new int[18];
        int[] combatAs = new int[21];
        int[] combatAsP = new int[18];

        int[] xE = new int[112];
        int[] xAm = new int[17];
        int[] xAf = new int[18];
        int[] xAs = new int[21];
        int[] xAsP = new int[18];

        int[] yE = new int[112];
        int[] yAm = new int[17];
        int[] yAf = new int[18];
        int[] yAs = new int[21];
        int[] yAsP = new int[18];
       
        int d = 20;

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;


        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            InitializareMain();

            fs = true;
            GoFullscreen(fs);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Xi = this.Width, Yi = this.Height;
            Ascunde();
            Image myimage = new Bitmap(@"Resources\europa.png");
            this.BackgroundImage = myimage;
            Back.Visible = true;
            Back.Enabled = true;
            mapa = 1;
        
            if (rap == true)
            {
                Raport2.Visible = true;
                Raport1.Visible = true;
            }

            int i;
            for (i = 1; i <= nEuropa; i++)
            {
                labE[i].Visible = true;
                labE[i].Enabled = true;
            }
            popInfo.Top = 0;
            popInfo.Left = 0;

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Xi = this.Width, Yi = this.Height;
            Ascunde();
            Image myimage = new Bitmap(@"Resources\america.png");
            this.BackgroundImage = myimage;
            Back.Visible = true;
            Back.Enabled = true;
            mapa = 2;
            if (rap == true)
            {
                Raport2.Visible = true;
                Raport1.Visible = true;
            }

            int i;
            for (i = 1; i <= nAmerica; i++)
            {
                labAm[i].Visible = true;
                labAm[i].Enabled = true;
            }
            popInfo.Top = 0;
            popInfo.Left = 0;
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Xi = this.Width, Yi = this.Height;
            Ascunde();
            Image myimage = new Bitmap(@"Resources\africa.png");
            this.BackgroundImage = myimage;
            Back.Visible = true;
            Back.Enabled = true;
            mapa = 3;
            if (rap == true)
            {
                Raport2.Visible = true;
                Raport1.Visible = true;
            }

            int i;
            for (i = 1; i <= nAfrica; i++)
            {
                labAf[i].Visible = true;
                labAf[i].Enabled = true;
            }
            popInfo.Top = this.Height - popInfo.Height;
            popInfo.Left = 0;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double Xi = this.Width, Yi = this.Height;
            Ascunde();
            Image myimage = new Bitmap(@"Resources\asiaP.png");
            this.BackgroundImage = myimage;
            Back.Visible = true;
            Back.Enabled = true;
            mapa = 5;
            if (rap == true)
            {
                Raport2.Visible = true;
                Raport1.Visible = true;
            }

            int i;
            for (i = 1; i <= nAsiaP; i++)
            {
                labAsP[i].Visible = true;
                labAsP[i].Enabled = true;
            }
            popInfo.Top = this.Height - popInfo.Height; 
            popInfo.Left = 0;

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Xi = this.Width, Yi = this.Height;
            Ascunde();
            Image myimage = new Bitmap(@"Resources\asia.png");
            this.BackgroundImage = myimage;
            Back.Visible = true;
            Back.Enabled = true;
            mapa = 4;
            if (rap == true)
            {
                Raport2.Visible = true;
                Raport1.Visible = true;
            }

            int i;
            for (i = 1; i <= nAsia; i++)
            {
                labAs[i].Visible = true;
                labAs[i].Enabled = true;
            }
            popInfo.Top = 0; 
            popInfo.Left = this.Width - popInfo.Width;

            

        }
       
        private void lab_Click(object sender, EventArgs e)
        {
            indexE = Array.IndexOf(labE, (Label)sender);
            indexAm = Array.IndexOf(labAm, (Label)sender);
            indexAf = Array.IndexOf(labAf, (Label)sender);
            indexAs = Array.IndexOf(labAs, (Label)sender);
            indexAsP = Array.IndexOf(labAsP, (Label)sender);
            if (VS.Visible == false||Raport2.Text=="RETREAT")
            {
                popInfo.Visible = true;
                if (rap == false)
                {
                    editDiv.Visible = true;
                    editDiv.Enabled = true;
                    editComb.Visible = true;
                    editComb.Enabled = true;
                }
                if (mapa == 1)
                {
                    if (Raport2.Text != "RETREAT")
                    {
                        umap = pmap;
                        uindex = pindex;
                        utara = ptara;
                        uprov = pprov;
                        uNrD = pNrD;
                        uComb = pComb;
                        cul2 = cul1;
                        pmap = mapa;
                        pindex = indexE;
                        ptara = taraE[indexE];
                        pprov = numePE[indexE];
                        pNrD = nrDivE[indexE];
                        pComb = combatE[indexE];
                        cul1 = labE[pindex].BackColor;
                        NumeDInfo.Text = numePE[indexE];
                        TaraInfo.Text = taraE[indexE];
                        nrDivInfo.Text = nrDivE[indexE].ToString();
                        combatInfo.Text = combatE[indexE].ToString() + "%";
                    }
                    else 
                    {
                        rmap = mapa;
                        rindex = indexE;
                        rtara = taraE[rindex];
                        NumeDInfo.Text = numePE[indexE];
                        TaraInfo.Text = taraE[indexE];
                        nrDivInfo.Text = nrDivE[indexE].ToString();
                        combatInfo.Text = combatE[indexE].ToString() + "%";
                    }
                }
                else
                    if (mapa == 2)
                    {
                        if (Raport2.Text != "RETREAT")
                        {
                            umap = pmap;
                            uindex = pindex;
                            utara = ptara;
                            uprov = pprov;
                            uNrD = pNrD;
                            uComb = pComb;
                            cul2 = cul1;
                            pmap = mapa;
                            pindex = indexAm;
                            ptara = taraAm[indexAm];
                            pprov = numePAm[indexAm];
                            pNrD = nrDivAm[indexAm];
                            pComb = combatAm[indexAm];
                            cul1 = labAm[pindex].BackColor;
                            NumeDInfo.Text = numePAm[indexAm];
                            TaraInfo.Text = taraAm[indexAm];
                            nrDivInfo.Text = nrDivAm[indexAm].ToString();
                            combatInfo.Text = combatAm[indexAm].ToString() + "%";
                        }
                        else
                        {
                            rmap = mapa;
                            rindex = indexAm;
                            rtara = taraAm[rindex];
                            NumeDInfo.Text = numePAm[indexAm];
                            TaraInfo.Text = taraAm[indexAm];
                            nrDivInfo.Text = nrDivAm[indexAm].ToString();
                            combatInfo.Text = combatAm[indexAm].ToString() + "%";
                        }
                    }
                    else
                        if (mapa == 3)
                        {
                            if (Raport2.Text != "RETREAT")
                            {
                                umap = pmap;
                                uindex = pindex;
                                utara = ptara;
                                uprov = pprov;
                                uNrD = pNrD;
                                uComb = pComb;
                                cul2 = cul1;
                                pmap = mapa;
                                pindex = indexAf;
                                ptara = taraAf[indexAf];
                                pprov = numePAf[indexAf];
                                pNrD = nrDivAf[indexAf];
                                pComb = combatAf[indexAf];
                                cul1=labAf[pindex].BackColor;
                                NumeDInfo.Text = numePAf[indexAf];
                                TaraInfo.Text = taraAf[indexAf];
                                nrDivInfo.Text = nrDivAf[indexAf].ToString();
                                combatInfo.Text = combatAf[indexAf].ToString() + "%";
                            }
                            else
                            {
                                rmap = mapa;
                                rindex = indexAf;
                                rtara = taraAf[rindex];
                                NumeDInfo.Text = numePAf[indexAf];
                                TaraInfo.Text = taraAf[indexAf];
                                nrDivInfo.Text = nrDivAf[indexAf].ToString();
                                combatInfo.Text = combatAf[indexAf].ToString() + "%";
                            }
                        }
                        else
                            if (mapa == 4)
                            {
                                if (Raport2.Text != "RETREAT")
                                {
                                    umap = pmap;
                                    uindex = pindex;
                                    utara = ptara;
                                    uprov = pprov;
                                    uNrD = pNrD;
                                    uComb = pComb;
                                    cul2 = cul1;
                                    pmap = mapa;
                                    pindex = indexAs;
                                    ptara = taraAs[indexAs];
                                    pprov = numePAs[indexAs];
                                    pNrD = nrDivAs[indexAs];
                                    pComb = combatAs[indexAs];
                                    cul1 = labAs[pindex].BackColor;
                                    NumeDInfo.Text = numePAs[indexAs];
                                    TaraInfo.Text = taraAs[indexAs];
                                    nrDivInfo.Text = nrDivAs[indexAs].ToString();
                                    combatInfo.Text = combatAs[indexAs].ToString() + "%";
                                }
                                else
                                {
                                    rmap = mapa;
                                    rindex = indexAs;
                                    rtara = taraAs[rindex];
                                    NumeDInfo.Text = numePAs[indexAs];
                                    TaraInfo.Text = taraAs[indexAs];
                                    nrDivInfo.Text = nrDivAs[indexAs].ToString();
                                    combatInfo.Text = combatAs[indexAs].ToString() + "%";
                                }
                            }
                            else
                                if (mapa == 5)
                                {
                                    if (Raport2.Text != "RETREAT")
                                    {
                                        umap = pmap;
                                        uindex = pindex;
                                        utara = ptara;
                                        uprov = pprov;
                                        uNrD = pNrD;
                                        uComb = pComb;
                                        cul2 = cul1;
                                        pmap = mapa;
                                        pindex = indexAsP;
                                        ptara = taraAsP[indexAsP];
                                        pprov = numePAsP[indexAsP];
                                        pNrD = nrDivAsP[indexAsP];
                                        pComb = combatAsP[indexAsP];
                                        cul1 = labAsP[pindex].BackColor;
                                        NumeDInfo.Text = numePAsP[indexAsP];
                                        TaraInfo.Text = taraAsP[indexAsP];
                                        nrDivInfo.Text = nrDivAsP[indexAsP].ToString();
                                        combatInfo.Text = combatAsP[indexAsP].ToString() + "%";
                                    }
                                    else
                                    {
                                        rmap = mapa;
                                        rindex = indexAsP;
                                        rtara = taraAsP[rindex];
                                        NumeDInfo.Text = numePAsP[indexAsP];
                                        TaraInfo.Text = taraAsP[indexAsP];
                                        nrDivInfo.Text = nrDivAsP[indexAsP].ToString();
                                        combatInfo.Text = combatAsP[indexAsP].ToString() + "%";
                                    }
                                }
                TaraInfo.Text = Filter(TaraInfo.Text);
                NumeDInfo.Text = Filter(NumeDInfo.Text);
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {
            e1 = !e1;
            if (e1 == true)
            {
                editDiv.Text = "Ok";
                inputDiv.Visible = true;
                inputDiv.Enabled = true;
            }
            else
            {

                inputDiv.Visible = false;
                inputDiv.Enabled = false;
                editDiv.Text = "edit";
                if (inputDiv.Text != "")
                {
                    nrDivInfo.Text = inputDiv.Text;
                    if (pmap == 1)
                    {
                        nrDivE[pindex] = int.Parse(inputDiv.Text);
                        labE[pindex].Text = nrDivE[pindex].ToString();
                        
                    }
                    else
                        if (pmap == 2)
                        {
                            nrDivAm[pindex] = int.Parse(inputDiv.Text);
                            labAm[pindex].Text = nrDivAm[pindex].ToString();
                            
                        }
                        else
                            if (pmap == 3)
                            {
                                nrDivAf[pindex] = int.Parse(inputDiv.Text);
                                labAf[pindex].Text = nrDivAf[pindex].ToString();
                            }
                            else
                                if (pmap == 4)
                                {
                                    nrDivAs[pindex] = int.Parse(inputDiv.Text);
                                    labAs[pindex].Text = nrDivAs[pindex].ToString();
                                   
                                }
                                else
                                    if (pmap == 5)
                                    {
                                        nrDivAsP[pindex] = int.Parse(inputDiv.Text);
                                        labAsP[pindex].Text = nrDivAsP[pindex].ToString();
                                       
                                    }
                }
                inputDiv.Text = "";
            }
            
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            e2 = !e2;
            
             if (e2 == true)
                {
                    inputAtt.Visible = true;
                    inputAtt.Enabled = true;
                    editAtt.Text = "Ok";
                }
                else
                {
                    inputAtt.Visible = false;
                    inputAtt.Enabled = false;
                    editAtt.Text = "edit";
                    if (inputAtt.Text != "")
                    {
                        uNrD = int.Parse(inputAtt.Text);
                        U.Text = utara + "     " + '\n' + "(" + uprov + ")" + '\n' + uNrD.ToString() + '\n' + " ";
                        inputAtt.Text = "";
                    }
                }
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            e3 = !e3;
            if (e3 == true)
            {
                editComb.Text = "Ok";
                inputComb.Visible = true;
                inputComb.Enabled = true;
            }
            else
            {

                inputComb.Visible = false;
                inputComb.Enabled = false;
                editComb.Text = "edit";
                if (inputComb.Text != "")
                {
                    combatInfo.Text = inputComb.Text + "%";

                    if (pmap == 1)
                    {
                        combatE[pindex] = int.Parse(inputComb.Text);
                        
                    }
                    else
                        if (pmap == 2)
                        {
                            combatAm[pindex] = int.Parse(inputComb.Text);
                            
                        }
                        else
                            if (pmap == 3)
                            {
                                combatAf[pindex] = int.Parse(inputComb.Text);
                                
                            }
                            else
                                if (pmap == 4)
                                {
                                    combatAs[pindex] = int.Parse(inputComb.Text);
                                    
                                }
                                else
                                    if (pmap == 5)
                                    {
                                        combatAsP[pindex] = int.Parse(inputComb.Text);
                                        
                                    }
                    int i;
                    for (i = 1; i <= nEuropa; i++)
                    {
                        if (taraE[i] == ptara)
                        {
                            combatE[i] = int.Parse(inputComb.Text);
                        }
                    }
                    for (i = 1; i <= nAmerica; i++)
                    {
                        if (taraAm[i] == ptara)
                        {
                            combatAm[i] = int.Parse(inputComb.Text);
                        }
                    }
                    for (i = 1; i <= nAfrica; i++)
                    {
                        if (taraAf[i] == ptara)
                        {
                            combatAf[i] = int.Parse(inputComb.Text);
                        }
                    }
                    for (i = 1; i <= nAsia; i++)
                    {
                        if (taraAs[i] == ptara)
                        {
                            combatAs[i] = int.Parse(inputComb.Text);
                        }
                    }
                    for (i = 1; i <= nAsiaP; i++)
                    {
                        if (taraAsP[i] == ptara)
                        {
                            combatAsP[i] = int.Parse(inputComb.Text);
                        }
                    }
                }
                inputComb.Text = "";
            }

        }
        
        private void back_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            inputDiv.Enabled = false;
            inputDiv.Visible = false;
            pb.Visible = false;
            Activeaza();
            Back.Visible = false;
            Back.Enabled = false;
            VS.Visible = false;
            VS.Enabled = false;
            Fight.Visible = false;
            Fight.Enabled = false;
            if (rap == true)
            {
                Raport2.Visible = false;
                Raport1.Visible = false;
            }
            if (e1 == true)
            {
                inputDiv.Text = "";
                edit_Click(sender,e);
            }
            if (e2 == true)
            {
                inputAtt.Text = "";
                edit2_Click(sender, e);
            }
            if (e3 == true)
            {
                inputComb.Text = "";
                edit3_Click(sender, e);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void attack_Click(object sender, EventArgs e)
        {
            if (umap != 0)
            {
                P.Visible = true;
                U.Visible = true;
                VS.Visible = true;
                VS.Enabled = true;
                Fight.Visible = true;
                Fight.Enabled = true;
                editAtt.Visible = true;
                editAtt.Enabled = true;
                Bonus1.Visible = true;
                Bonus1.Enabled = true;
                Bonus2.Visible = true;
                Bonus2.Enabled = true;
                BonusTx1.Visible = true;
                BonusTx2.Visible = true;
                Attack.Visible = false;
                Attack.Enabled = false;
                editDiv.Visible = false;
                editDiv.Enabled = false;
                editComb.Visible = false;
                editComb.Enabled = false;
                Back.Visible = false;
                Back.Enabled = false;
                Deaths1.Visible = false;
                Deaths2.Visible = false;
                if (ptara == utara)
                    Fight.Text = "SEND";
                else
                    Fight.Text = "FIGHT!";


                U.Text = Filter(utara)+"     " + '\n' + "(" + Filter(uprov) + ")" + '\n' + uNrD.ToString() + '\n'+" ";
                P.Text = Filter(ptara)+"     " + '\n' + "(" + Filter(pprov) + ")" + '\n' + pNrD.ToString() + '\n'+" ";
            }
        }

        private void vs_Click(object sender, EventArgs e)
        {
            P.Visible = false;
            U.Visible = false;
            VS.Visible = false;
            VS.Enabled = false;
            Fight.Visible = false;
            Fight.Enabled = false;
            Attack.Visible = true;
            Attack.Enabled = true;
            editDiv.Visible = true;
            editDiv.Enabled = true;
            editComb.Visible = true;
            editComb.Enabled = true;
            Back.Visible = true;
            Back.Enabled = true;
            Raport1.Enabled = false;
            Raport1.Visible = false;
            Raport2.Enabled = false;
            Raport2.Visible = false;
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            Ascunde();
            pb.Top = 0;
            pb.Left = 0;
            pb.Width = this.Width+2;
            pb.Height = this.Height+2;
            pb.Image = Image.FromFile(@"Resources\credits.jpg");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Visible = true;
            
            Back.Visible = true;
            Back.Enabled = true;
            CreditsInfo.Visible = true;
        }

        void The_Real_Fight()
        {
            int rms1 = 0, rms2 = 0;
            A = uNrD;
            B = pNrD;
            Ca = uComb;
            Cb = pComb;
            Los1 = 0;
            Los2 = 0;
            Win = 0;
            Rounds = rnd.Next(1, 6);
            if (Bonus1.Checked == true)
                Ca = Ca + 10;
            if (Bonus2.Checked == true)
                Cb = Cb + 10;
            Bonus1.Checked = false;
            Bonus2.Checked = false;

            if (A > B && B == 0)
            {
                Win = 1;
            }

            int i;
            for (i = 1; i <= Rounds && Win == 0; i++)
            {
                if (Win == 0)
                {
                    Bulan = rnd.Next(0, 51);
                    if (Los2 < B)
                    {
                        Los2 += (float)(Ca + Bulan) / 100;
                    }
                    else
                    {
                        Los2 = B;
                        Win = 1;
                    }

                }
                if(Win==0)
                {
                    Bulan = rnd.Next(0, 51);
                    if (Los1 < A)
                    {
                        Los1 += (float)(Cb + Bulan) / 100;
                    }
                    else
                    {
                        Los1 = A;
                        Win = 2;
                    }
                }
            }
            if (Los2 >= B)
            {
                Los2 = B;
            }
            if (Los1 >= A)
            {
                Los1 = A;
            }

            if (Los1 - (int)Los1 >= 0.5)
            {
                Los1 = (int)Los1 + 1;
            }
            else
                Los1 = (int)Los1;

            if (Los2 - (int)Los2 >= 0.5)
            {
                Los2 = (int)Los2 + 1;
            }
            else
                Los2 = (int)Los2;
            
            rms1 = (int)(A - Los1);
            rms2 = (int)(B - Los2);
           /* if (rms1 < 0)
                rms1 = 0;
            if (rms2 < 0)
                rms2 = 0;
            */
            if ( B-Los2 > A-Los1)
                Win = 2;
            if ( B-Los2 < A-Los1)
                Win = 1;
            if (B - Los2 == A - Los1)
            {
                Win = rnd.Next(1, 3);
            }

            if (Win == 1 && rms1 == 0)
                rms1 = 1;
            if (Win == 2 && rms2 == 0)
                rms2 = 1;
            Los1 = A - rms1;
            Los2 = B - rms2;

            nrDivInfo.Text=rms2.ToString();

            if (pmap == 1)
            {
                if (Win == 1)
                {
                    taraE[pindex] = utara;
                    combatE[pindex] = uComb;
                    nrDivE[pindex] = rms1;
                    labE[pindex].BackColor = cul2;
                }
                if (Win == 2 )
                {
                    nrDivE[pindex] = rms2;
                }
                labE[pindex].Text = nrDivE[pindex].ToString();
            }
            else
                if (pmap == 2)
                {
                    
                    if (Win == 1)
                    {
                        taraAm[pindex] = utara;
                        combatAm[pindex] = uComb;
                        nrDivAm[pindex] = rms1;
                        labAm[pindex].BackColor = cul2;
                    }
                    if (Win == 2)
                    {
                        nrDivAm[pindex] = rms2;
                    }
                    labAm[pindex].Text = nrDivAm[pindex].ToString();
                }
                else
                    if (pmap == 3)
                    {
                        if (Win == 1)
                        {
                            taraAf[pindex] = utara;
                            combatAf[pindex] = uComb;
                            nrDivAf[pindex] = rms1;
                            labAf[pindex].BackColor = cul2;
                        }
                        if (Win == 2)
                        {
                            nrDivAf[pindex] = rms2;
                        }
                        labAf[pindex].Text = nrDivAf[pindex].ToString();
                    }
                    else
                        if (pmap == 4)
                        {
                            if (Win == 1)
                            {
                                taraAs[pindex] = utara;
                                combatAs[pindex] = uComb;
                                nrDivAs[pindex] = rms1;
                                labAs[pindex].BackColor = cul2;
                            }
                            if (Win == 2)
                            {
                                nrDivAs[pindex] = rms2;
                            }
                            labAs[pindex].Text = nrDivAs[pindex].ToString();
                        }
                        else
                            if (pmap == 5)
                            {
                                
                                if (Win == 1)
                                {
                                    taraAsP[pindex] = utara;
                                    combatAsP[pindex] = uComb;
                                    nrDivAsP[pindex] = rms1;
                                    labAsP[pindex].BackColor = cul2;
                                }
                                if (Win == 2)
                                {
                                    nrDivAsP[pindex] = rms2;
                                }
                                labAsP[pindex].Text = nrDivAsP[pindex].ToString();
                            }

            if (umap == 1)
            {
                if (Win == 1)
                {
                    nrDivE[uindex] =nrDivE[uindex]- (int)Los1 - rms1;
                }
                if (Win == 2)
                {
                    nrDivE[uindex] = nrDivE[uindex] - (int)A + rms1;
                }
                labE[uindex].Text = nrDivE[uindex].ToString();
            }
            else
                if (umap == 2)
                {
                    if (Win == 1)
                    {
                        nrDivAm[uindex]= nrDivAm[uindex]- (int)Los1 - rms1 ;
                    }
                    if (Win == 2)
                    {
                        nrDivAm[uindex] = nrDivAm[uindex] - (int)A + rms1;
                    }
                    labAm[uindex].Text = nrDivAm[uindex].ToString();
                }
                else
                    if (umap == 3)
                    {
                        if (Win == 1)
                        {
                            nrDivAf[uindex] = nrDivAf[uindex] - (int)Los1 -rms1;
                        }
                        if (Win == 2)
                        {
                            nrDivAf[uindex] = nrDivAf[uindex] - (int)A + rms1;
                        }
                        labAf[uindex].Text = nrDivAf[uindex].ToString();
                    }
                    else
                        if (umap == 4)
                        {
                            if (Win == 1)
                            {
                                nrDivAs[uindex] = nrDivAs[uindex] - (int)Los1 - rms1;
                            }
                            if (Win == 2)
                            {
                                nrDivAs[uindex] = nrDivAs[uindex] - (int)A + rms1;
                            }
                            labAs[uindex].Text = nrDivAs[uindex].ToString();
                        }
                        else
                            if (umap == 5)
                            {
                                if (Win == 1)
                                {
                                    nrDivAsP[uindex] = nrDivAsP[uindex] - (int)Los1 - rms1;
                                }
                                if (Win == 2)
                                {
                                    nrDivAsP[uindex] = nrDivAsP[uindex] - (int)A + rms1;
                                }
                                labAsP[uindex].Text = nrDivAsP[uindex].ToString();
                            }
            
        }

        private void fight_Click(object sender, EventArgs e)
        {
            Bonus1.Visible = false;
            Bonus2.Visible = false;
            Bonus1.Enabled = false;
            Bonus2.Enabled = false;
            BonusTx1.Visible = false;
            BonusTx2.Visible = false;
            Fight.Visible = false;
            Fight.Enabled = false;
            editAtt.Visible = false;
            editAtt.Enabled = false;

            if (utara == ptara)
            {
                U.Visible = false;
                P.Visible = false;
                VS.Visible = false;
                VS.Enabled = false;
                Back.Visible = true;
                Back.Enabled = true;
                Attack.Visible = true;
                Attack.Enabled = true;
                editDiv.Visible = true;
                editDiv.Enabled = true;
                editComb.Visible = true;
                editComb.Enabled = true;
                if (pmap == 1)
                {
                    labE[pindex].Text = (pNrD+uNrD).ToString();
                    nrDivE[pindex] = pNrD + uNrD;
                }
                else
                    if (pmap == 2)
                    {
                        labAm[pindex].Text = (pNrD + uNrD).ToString();
                        nrDivAm[pindex] = pNrD + uNrD;
                    }
                    else
                        if (pmap == 3)
                        {
                            labAf[pindex].Text = (pNrD + uNrD).ToString();
                            nrDivAf[pindex] = pNrD + uNrD;
                        }
                        else
                            if (pmap == 4)
                            {
                                labAs[pindex].Text = (pNrD + uNrD).ToString();
                                nrDivAs[pindex] = pNrD + uNrD;
                            }
                            else
                                if (pmap == 5)
                                {
                                    labAsP[pindex].Text = (pNrD + uNrD).ToString();
                                    nrDivAsP[pindex] = pNrD + uNrD;
                                }
                if (umap == 1)
                {
                    labE[uindex].Text = (nrDivE[uindex] - uNrD).ToString();
                    nrDivE[uindex] = nrDivE[uindex] - uNrD;
                }
                else
                    if (umap == 2)
                    {
                        labAm[uindex].Text = (nrDivAm[uindex] - uNrD).ToString();
                        nrDivAm[uindex] = nrDivAm[uindex] - uNrD;
                    }
                    else
                        if (umap == 3)
                        {
                            labAf[uindex].Text = (nrDivAf[uindex] - uNrD).ToString();
                            nrDivAf[uindex] = nrDivAf[uindex] - uNrD;
                        }
                        else
                            if (umap == 4)
                            {
                                labAs[uindex].Text = (nrDivAs[uindex] - uNrD).ToString();
                                nrDivAs[uindex] = nrDivAs[uindex] - uNrD;
                            }
                            else
                                if (umap == 5)
                                {
                                    labAsP[uindex].Text = (nrDivAsP[uindex] - uNrD).ToString();
                                    nrDivAsP[uindex] = nrDivAsP[uindex] - uNrD;
                                }
            }
            else
            if (uNrD != 0 )
            {
                The_Real_Fight();
                Deaths1.Text = "(-" + Los1.ToString() + ")";
                Deaths2.Text = "(-" + Los2.ToString() + ")";
                Deaths1.Visible = true;
                Deaths2.Visible = true;
                if (Win == 1)
                {
                    Raport1.Text = "Victory!";
                    Raport2.Text = "Defeat!";
                }
                else
                {
                    Raport1.Text = "Defeat!";
                    Raport2.Text = "Victory!";
                }
                Raport1.Visible = true;
                Raport1.Enabled = true;
                Raport2.Visible = true;
                Raport2.Enabled = true;
            }
            if (Win == 1 && B - Los2 != 0)
            {
                VS.Visible = false;
                VS.Enabled = false;
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (Win == 1 && B-Los2!=0)
            {
                if (rap == false)
                {
                    P.Visible = false;
                    U.Visible = false;
                    VS.Visible = false;
                    VS.Enabled = false;
                    Fight.Visible = false;
                    Fight.Enabled = false;
                    Attack.Visible = false;
                    Attack.Enabled = false;
                    editDiv.Visible = false;
                    editDiv.Enabled = false;
                    editComb.Visible = false;
                    editComb.Enabled = false;
                    Back.Visible = true;
                    Back.Enabled = true;
                    Raport1.Top = 0;
                    Raport1.Text = "SURRENDER";
                    Raport2.Top = 0;
                    Raport2.Text = "RETREAT";
                    rap = true;
                }
                else
                {
                    if (ptara == rtara)
                    {
                        Raport2.Text = "";
                        Raport1.Text = "";
                        Raport1.Top = U.Top + 7 * d;
                        Raport2.Top = Raport1.Top;
                        rap = false;
                        Raport2.Enabled = false;
                        Raport2.Visible = false;
                        Raport1.Enabled = false;
                        Raport1.Visible = false;
                        Attack.Visible = true;
                        Attack.Enabled = true;
                        editDiv.Visible = true;
                        editDiv.Enabled = true;
                        editComb.Visible = true;
                        editComb.Enabled = true;
                        if (rmap == 1)
                        {
                            nrDivE[rindex] += (int)(B - Los2);
                            labE[rindex].Text = nrDivE[rindex].ToString();
                            nrDivInfo.Text = nrDivE[rindex].ToString();
                        }
                        else
                            if (rmap == 2)
                            {
                                nrDivAm[rindex] += (int)(B - Los2);
                                labAm[rindex].Text = nrDivAm[rindex].ToString();
                                nrDivInfo.Text = nrDivAm[rindex].ToString();
                            }
                            else
                                if (rmap == 3)
                                {
                                    nrDivAf[rindex] += (int)(B - Los2);
                                    labAf[rindex].Text = nrDivAf[rindex].ToString();
                                    nrDivInfo.Text = nrDivAf[rindex].ToString();
                                }
                                else
                                    if (rmap == 4)
                                    {
                                        nrDivAs[rindex] += (int)(B - Los2);
                                        labAs[rindex].Text = nrDivAs[rindex].ToString();
                                        nrDivInfo.Text = nrDivAs[rindex].ToString();
                                    }
                                    else
                                        if (rmap == 5)
                                        {
                                            nrDivAsP[rindex] += (int)(B - Los2);
                                            labAsP[rindex].Text = nrDivAsP[rindex].ToString();
                                            nrDivInfo.Text = nrDivAsP[rindex].ToString();
                                        }
                    }

                }
             }
        }

        private void Surr_Click(object sender, EventArgs e)
        {
            if (rap==true)
            {
                Raport2.Text = "";
                Raport1.Text = "";
                Raport1.Top = U.Top + 7 * d;
                Raport2.Top = Raport1.Top;
                rap = false;
                Raport2.Enabled = false;
                Raport2.Visible = false;
                Raport1.Enabled = false;
                Raport1.Visible = false;
                Attack.Visible = true;
                Attack.Enabled = true;
                editDiv.Visible = true;
                editDiv.Enabled = true;
                editComb.Visible = true;
                editComb.Enabled = true;
            }
        }

        private void new_G_Click(object sender, EventArgs e)
        {
            StreamReader fe = new StreamReader("Date/Europa.in");
            StreamReader fam = new StreamReader("Date/America.in");
            StreamReader faf = new StreamReader("Date/Africa.in");
            StreamReader fas = new StreamReader("Date/Asia.in");
            StreamReader fasP = new StreamReader("Date/AsiaP.in");
            citire(fe,fam,faf,fas,fasP);
            new_G.Visible = false;
            new_G.Enabled = false;
            load_G.Visible = false;
            load_G.Enabled = false;
            Activeaza();
            fe.Close();
            fam.Close();
            faf.Close();
            fas.Close();
            fasP.Close();
            MessageBox.Show((char)12+" Enjoy! " + (char)12);
        
        }

        private void load_G_Click(object sender, EventArgs e)
        {
            StreamReader fe = new StreamReader("Date/Europa.out");
            StreamReader fam = new StreamReader("Date/America.out");
            StreamReader faf = new StreamReader("Date/Africa.out");
            StreamReader fas = new StreamReader("Date/Asia.out");
            StreamReader fasP = new StreamReader("Date/AsiaP.out");
            citire(fe, fam, faf, fas, fasP);
            new_G.Visible = false;
            new_G.Enabled = false;
            load_G.Visible = false;
            load_G.Enabled = false;
            Activeaza();
            fe.Close();
            fam.Close();
            faf.Close();
            fas.Close();
            fasP.Close();
            MessageBox.Show("Welcome back! :D");
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void save_G_Click(object sender, EventArgs e)
        {
            StreamWriter g = new StreamWriter("Date/Europa.out");
            StreamWriter gam = new StreamWriter("Date/America.out");
            StreamWriter gaf = new StreamWriter("Date/Africa.out");
            StreamWriter gas = new StreamWriter("Date/Asia.out");
            StreamWriter gasP = new StreamWriter("Date/AsiaP.out");

            int i;
            for (i = 1; i <= nEuropa; i++)
            {
                g.WriteLine(xE[i].ToString() + ' ' + yE[i].ToString() + ' ' + taraE[i] + ' ' + nrDivE[i] + ' ' + numePE[i] + ' ' + combatE[i].ToString() + ' ' + HexConverter(labE[i].BackColor));
            }
            g.Close();
            for (i = 1; i <= nAmerica; i++)
            {
                gam.WriteLine(xAm[i].ToString() + ' ' + yAm[i].ToString() + ' ' + taraAm[i] + ' ' + nrDivAm[i] + ' ' + numePAm[i] + ' ' + combatAm[i].ToString() + ' ' + HexConverter(labAm[i].BackColor));
            }
            gam.Close();
            for (i = 1; i <= nAfrica; i++)
            {
                gaf.WriteLine(xAf[i].ToString() + ' ' + yAf[i].ToString() + ' ' + taraAf[i] + ' ' + nrDivAf[i] + ' ' + numePAf[i] + ' ' + combatAf[i].ToString() + ' ' + HexConverter(labAf[i].BackColor));
            }
            gaf.Close();
            for (i = 1; i <= nAsia; i++)
            {
                gas.WriteLine(xAs[i].ToString() + ' ' + yAs[i].ToString() + ' ' + taraAs[i] + ' ' + nrDivAs[i] + ' ' + numePAs[i] + ' ' + combatAs[i].ToString() + ' ' + HexConverter(labAs[i].BackColor));
            }
            gas.Close();
            for (i = 1; i <= nAsiaP; i++)
            {
                gasP.WriteLine(xAsP[i].ToString() + ' ' + yAsP[i].ToString() + ' ' + taraAsP[i] + ' ' + nrDivAsP[i] + ' ' + numePAsP[i] + ' ' + combatAsP[i].ToString() + ' ' + HexConverter(labAsP[i].BackColor));
            }
            gasP.Close();
            MessageBox.Show("Succesfully saved! ");
        }
    }
}
ss
