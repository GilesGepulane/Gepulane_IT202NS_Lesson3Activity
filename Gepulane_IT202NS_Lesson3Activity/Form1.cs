using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gepulane_IT202NS_Lesson3Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1");
            dataGridView1.Rows.Add("2");
            dataGridView1.Rows.Add("3");
            dataGridView1.Rows.Add("4");
            dataGridView1.Rows.Add("5");
            dataGridView1.Rows.Add("6");
            dataGridView1.Rows.Add("7");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
