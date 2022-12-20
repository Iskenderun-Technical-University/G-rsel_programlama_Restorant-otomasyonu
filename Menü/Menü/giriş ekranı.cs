using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                Console.WriteLine("Giriş Başarılı");
                this.Hide();
                menü menu = new menü();
                menu.Show();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
        }

    }
}
