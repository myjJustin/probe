using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace probe
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ausgabeText;

            if (this.radioButton1.Checked == true)
                ausgabeText = "Männlich";
            else
                ausgabeText = "Weiblich";

            if (this.checkBox1.Checked == true)
                ausgabeText += ", Vollzeit";
            if (this.checkBox2.Checked == true)
                ausgabeText += ", Teilzeit";
            if (this.checkBox3.Checked == true)
                ausgabeText += ", Arbeitslos/Suchend";
            if (this.checkBox4.Checked == true)
                ausgabeText += ", Schüler/in";
            if (numericUpDown1.Value >= 18)
                ausgabeText += ", du bist Volljährig";
            else
                ausgabeText += ", du bist nicht Volljährig";
            MessageBox.Show(ausgabeText);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            WhenEnter(textBox1, "Name");
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            WhenLeave(textBox1, "Name");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            WhenEnter(textBox2,"Vorname");
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            WhenLeave(textBox2, "Vorname");
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            WhenEnter(textBox3, "Email");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            WhenLeave(textBox3, "Email");
        }
        void WhenEnter (TextBox eingabe1,string name)
        {
            //löscht die Zeile
            if (eingabe1.Text == name) 
            {
                eingabe1.Text = "";
                eingabe1.ForeColor = Color.Black;
            }
        }
        void WhenLeave(TextBox eingabe1,string name)
        {
            //Fügt den namen ein 
            if (eingabe1.Text == "")
            {
                eingabe1.Text = name;
                eingabe1.ForeColor = Color.Gray;
            }
        } 
    }
}
