using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190503
{
    public partial class Form1 : Form
    {

        public double first_number;
        public string yon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (tb.Text.Equals(null))
            {
                tb1.Text = btn.Text;
            }
            else
            {
                tb.Text = tb.Text + btn.Text;
            }

            if (tb1.Text.Equals(null))
            {
                tb1.Text = btn.Text;
            }
            else
            {
                tb1.Text = tb1.Text + btn.Text;
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                first_number = double.Parse(tb.Text);
                yon = "*";
                tb.Text = null;
                tb1.Text = tb1.Text + "*";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            char[] charry = tb1.Text.ToString().ToCharArray();

            if (charry[charry.Length - 1].ToString().Equals(yon))
            {
                MessageBox.Show("마지막은 숫자를 입력하시오");
                return;
            }

            if (yon != null)
            {

                if (yon.Equals("*"))
                {
                    tb.Text = (first_number * double.Parse(tb.Text)).ToString();
                }
                else if (yon.Equals("/"))
                {
                    tb.Text = (first_number / double.Parse(tb.Text)).ToString();
                }
                else if (yon.Equals("+"))
                {
                    tb.Text = (first_number + double.Parse(tb.Text)).ToString();
                }
                else if (yon.Equals("-"))
                {
                    tb.Text = (first_number - double.Parse(tb.Text)).ToString();
                }
            }

            if (yon == null)
            {
                MessageBox.Show("연산자를 입력하시오");
                //return btneq_Click;
            }


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                first_number = double.Parse(tb.Text);
                yon = "/";
                tb.Text = null;
                tb1.Text = tb1.Text + "/";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                first_number = double.Parse(tb.Text);
                yon = "+";
                tb.Text = null;
                tb1.Text = tb1.Text + "+";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                first_number = double.Parse(tb.Text);
                yon = "-";
                tb.Text = null;
                tb1.Text = tb1.Text + "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tb.Text = null;
            tb1.Text = null;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
