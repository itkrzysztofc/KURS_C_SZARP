using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B02_Lista_zkupow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //pasek postępu na samej górze apki
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                if (textBox1.Text.Length > 0)
                {
                    if (listBox1.Items.Contains(textBox1.Text))
                    {
                        DialogResult = MessageBox.Show("Element już istnieje na liście","Uwaga",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(DialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                    listBox1.Items.Add(textBox1.Text);
                    AktualizujPasek();
                    textBox1.Text = "";//czyści texBox1 po użyciu przycisku
                }
                else
                {
                    MessageBox.Show("Nic nie wpisano", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lista jest zapełmniona", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AktualizujPasek()
        {
            int i = listBox1.Items.Count;//licznik wpisanych pozycji
            progressBar1.Value = i * 10;//postęp paska o 10%
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
                AktualizujPasek();
            }
            else
            {
                MessageBox.Show("Brak zaznaczonego elementu","Bład",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            AktualizujPasek();
            textBox1.Text = "";
        }
        //Zadanie do własnego wykonania: Zmodyfikuj zachowanie przycisku ‘Wyczyść’, aby spytać użytkownika, czy na pewno chce wyczyścić listę.

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
