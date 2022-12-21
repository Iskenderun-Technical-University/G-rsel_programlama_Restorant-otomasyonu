using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Menü
{
    public partial class menü : Form
    {
        public menü()
        {
            InitializeComponent();
        }
        int total = 0;
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
            ekle.SubItems.Add("0");
            listView1.Items.Add(ekle);

        }

        private void Ürünler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    if (listView1.SelectedItems[i].Selected)
                    {
                        testmasa.Text = listView1.SelectedItems[i].Text;
                    }
                }
            }
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
            if (listView2.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView2.SelectedItems.Count; i++)
                {
                    if (listView2.SelectedItems[i].Selected)
                    {
                        if (listView1.SelectedItems.Count > 0)
                        {
                            for (int y = 0;y < listView1.SelectedItems.Count; y++)
                            {
                                if (listView1.SelectedItems[y].Selected)
                                {
                                    total += Convert.ToInt32(listView2.SelectedItems[i].SubItems[1].Text);                                    
                                }
                            }
                        }
                        
                        //test1.Text = listView2.SelectedItems[i].SubItems[1].Text;
                    }
                }
            }

            // Output the price to TextBox1.

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListViewItem ekle = new ListViewItem(textBox2.Text);
            ekle.SubItems.Add(textBox3.Text);
            listView2.Items.Add(ekle);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                var checkTotal = Convert.ToInt32(item.SubItems[1].Text);
               
                if (checkTotal > 0)
                {
                    if (listView2.SelectedItems.Count > 0)
                    {
                        for (int i = 0; i < listView2.SelectedItems.Count; i++)
                        {
                            if (listView2.SelectedItems[i].Selected)
                            {
                                checkTotal += Convert.ToInt32(listView2.SelectedItems[i].SubItems[1].Text);                                
                            }
                        }
                    }
                    item.SubItems[1].Text = checkTotal.ToString();
                }
                else
                {
                    item.SubItems[1].Text = total.ToString();
                    total = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
