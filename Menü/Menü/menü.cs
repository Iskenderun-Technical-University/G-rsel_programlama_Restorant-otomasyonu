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
    public partial class menü : Form
    {
        public menü()
        {
            InitializeComponent();
        }

        private void menü_Load(object sender, EventArgs e)
        {
           

            


        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem ekle = new ListViewItem(textBox1.Text);
            listView1.Items.Add(ekle);

        }

        private void Ürünler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                item.Remove();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem ekle = new ListViewItem(textBox2.Text);
            ekle.SubItems.Add(textBox3.Text);
            listView2.Items.Add(ekle);
        }
    }
}
