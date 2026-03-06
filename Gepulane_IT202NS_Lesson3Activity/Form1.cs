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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Comfee, cisco_fee, book_fee, SAP_fee;
            int Lec_count, Lab_count;
            Lec_count = 0;
            Lab_count = 0;

            cisco_fee = 4500;
            book_fee = 450;
            SAP_fee = 2000;

            if (textBox27.Text != null) { Lec_count += 1; };
            if (textBox36.Text != null) { Lec_count += 1; };
            if (textBox48.Text != null) { Lec_count += 1; };
            if (textBox44.Text != null) { Lec_count += 1; };
            if (textBox84.Text != null) { Lec_count += 1; };
            if (textBox76.Text != null) { Lec_count += 1; };
            if (textBox68.Text != null) { Lec_count += 1; };

            if (textBox31.Text != null) { Lab_count += 1; };
            if (textBox35.Text != null) { Lab_count += 1; };
            if (textBox51.Text != null) { Lab_count += 1; };
            if (textBox43.Text != null) { Lab_count += 1; };
            if (textBox83.Text != null) { Lab_count += 1; };
            if (textBox75.Text != null) { Lab_count += 1; };
            if (textBox67.Text != null) { Lab_count += 1; };

            double Total;
            Total = Lec_count * 1500 + Lab_count * 2500;
            TotalTuitionFee.Text = Total.ToString();
            Comfee = Lab_count * 2500;

            ComLabFee.Text = Comfee.ToString();
            CiscoFee.Text = cisco_fee.ToString();
            BookletFee.Text = book_fee.ToString();
            SAPFee.Text = SAP_fee.ToString();

            double other_fee;
            other_fee = Comfee + cisco_fee + book_fee + SAP_fee;
            TotalOtherFee.Text = other_fee.ToString();

            TotalTuitionNFees.Text = (other_fee + Total).ToString(); ;
            MethodPayment.Text = "Installment";

            double Install, DP;
            Install = 50;
            DP = 8000;

            InstallCharge.Text = Install.ToString();
            Downpayment.Text = DP.ToString();

            double divide_to_three, total_all;
            total_all = other_fee + Total;
            divide_to_three = Math.Round(total_all/3, 2);
            First.Text = divide_to_three.ToString();
            Second.Text = divide_to_three.ToString();
            Third.Text = divide_to_three.ToString();



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 24; i <= 87; i++)
            {
                Control[] found = this.Controls.Find("textBox" + i, true);
                if (found.Length > 0 && found[0] is TextBox)
                {
                    ((TextBox)found[0]).Clear();
                }
            }
        }
    }
}
