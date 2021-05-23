using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Items.SelectedItem.ToString() == "Sweet Item 1")

            {
                txt_price.Text = "50";
            }
            else if (cmb_Items.SelectedItem.ToString() == "Sweet Item 2")
            {
                txt_price.Text = "100";
            }
            else if (cmb_Items.SelectedItem.ToString() == "Sweet Item 3")
            {
                txt_price.Text = "150";
            }
            else if (cmb_Items.SelectedItem.ToString() == "Nimko Item 1")
            {
                txt_price.Text = "200";
            }
            else if (cmb_Items.SelectedItem.ToString() == "Nimko Item 2")
            {
                txt_price.Text = "250";
            }
            else if (cmb_Items.SelectedItem.ToString() == "Nimko Item 3")
            {
                txt_price.Text = "300";
            }
            else
            {
                txt_price.Text = "0";
            }

            txt_qty.Text = "";
            txt_total.Text = "";

        }


        private void Select_Items_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            cmb_Items.Items.Clear();
            cmb_Items.Items.Add("Sweet Item 1");
            cmb_Items.Items.Add("Sweet Item 2");
            cmb_Items.Items.Add("Sweet Item 3");
        }


        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            cmb_Items.Items.Clear();
            cmb_Items.Items.Add("Nimko Item 1");
            cmb_Items.Items.Add("Nimko Item 2");
            cmb_Items.Items.Add("Nimko Item 3");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_Items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            //this will not parse the items to the list ,so we need  to create an object,
            //of array using listviewitem.

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

            //for total price

            txt_sub.Text = (Convert.ToString(txt_sub.Text) + Convert.ToString(txt_total.Text)).ToString();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (txt_discount.Text.Length > 0)
            {

                txt_amount.Text = (Convert.ToInt32(txt_sub.Text) - Convert.ToInt32(txt_discount.Text)).ToString();
            }

        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {


        }

        private void text_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {

                txt_balance.Text = (Convert.ToInt16(txt_paid.Text) - Convert.ToInt16(txt_amount.Text)).ToString();
            }
        }

        private void text_bal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {


                        txt_sub.Text = (Convert.ToInt32(txt_sub.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }
    }
}
