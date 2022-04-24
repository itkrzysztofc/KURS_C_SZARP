using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B03_Gra_OXOXO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //zmienne początkowe ------
        bool gracz1 = true;//zaczyna grę gracz 1
        int ruch = 0; //ile ruchów wykonano
        private void button1_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if(ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void Sprawdz()
        {
            if(btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                Wygrana();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                Wygrana();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                Wygrana();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                Wygrana();
            }
            else if(ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Zwycięstwo!!!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            if (gracz1)
            {
                wynikO.Text = (int.Parse(wynikO.Text)).ToString();
            }
            else
            {
                wynikX.Text = (int.Parse(wynikX.Text)).ToString();
            }
            Restartuj();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restartuj();
            wynikO.Text = "0";
            wynikX.Text = "0";
            lblGracz.Text = "0";
            gracz1 = true;
        }

        private void Restartuj()
        {
            //sposób 1 
            //btn1.Text = ""; ...
            ruch = 0;
            //sposób 2 tablica przycisków
            Button[] all = new Button[9]; //knstruktor tablicy przycisków
            all[0] = btn1; all[1] = btn2; all[2] = btn3;
            all[3] = btn4; all[4] = btn5; all[5] = btn6;
            all[6] = btn7; all[7] = btn8; all[8] = btn9;
            foreach(Button b in all)
            {
                b.Enabled = true; //włączamy dostępność przycisków prze resecie
                b.Text = "";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ruch++;
            //funkcja IF
            ((Button)sender).Text = gracz1 ? "0" : "X";
            ((Button)sender).Enabled = false;
            if (ruch > 4)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblGracz.Text = gracz1 ? "O" : "X";
        }
    }
}
