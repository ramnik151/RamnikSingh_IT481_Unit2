using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace RamnikSingh_IT481_Unit2
{
    public partial class Form1 : Form

    {
        db1 database;
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            button3.Click += new EventHandler(button3_Click);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new db1("Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;Server=RAMNIK-SURFACE\\SQLEXPRESS");
            MessageBox.Show("Connection information sent");
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database = new db1("Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;Server=RAMNIK-SURFACE\\SQLEXPRESS");
            String count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            database = new db1("Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;Server=RAMNIK-SURFACE\\SQLEXPRESS");
            string names = database.getCompanyNames();
            MessageBox.Show(names, "company names");
        }
 
    }
}
