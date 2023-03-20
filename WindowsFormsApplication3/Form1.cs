using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class WishList1 : Form
    {
        public WishList1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Wishlist.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Clear(); // Clear items
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Wishlist.Items.Count);  // Counting the items
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // List of items
            Wishlist.Items.Add("Hamburger");
            Wishlist.Items.Add("Footlong");
            Wishlist.Items.Add("Beefsteak");
            Wishlist.Items.Add("Good items");
            Wishlist.Items.Add("Hamburger w/ egg");
            Wishlist.Items.Add("Hotdogs");
            Wishlist.Items.Add("Softdrinks");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wishlist.Sorted = true; // For sorting
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // For closing the program
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Selection
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Shows the count
        }
    }
}
