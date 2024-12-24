using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double getPurchase(int pCurrent, int plast, double price)
        {
            double purchase = (pCurrent - plast) * price;
            return purchase;
        }

        private void Form1_load(object sender, EventArgs e)
        {
            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPrice.Text = "0";
            txtPurchase.Text = "0";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text != "" && txtLast.Text != "" && txtPrice.Text != "") //если поля заполнены
            {
                int pCurrent = Convert.ToInt32(txtCurrent.Text);
                int pLast = Convert.ToInt32(txtLast.Text);
                double pPrice = Convert.ToDouble(txtPrice.Text);
                if (pCurrent >= pLast) //проверка, что текущее значение >= предыдущего
                {
                    double purchase = getPurchase(pCurrent, pLast, pPrice);
                    txtPurchase.Text = purchase.ToString();
                }
                else
                {
                    MessageBox.Show("Текущее значение должно быть предыдущего", "Внимание:");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtAdress.Text != "" && int.Parse(txtPurchase.Text) != 0)
            {
                MessageBox.Show($"Платеж{txtPurchase.Text} принят! \n Плательщик {txtLastName.Text} {txtFirstName.Text}");
            }
            else
            {
                if (txtLastName.Text == "")
                {
                    MessageBox.Show("Заполните фамилию!", "Внимание:");
                }
                if (txtFirstName.Text =="")
                {
                    MessageBox.Show("Заполните имя!", "Внимание:");
                }
                if(txtAdress.Text =="")
                {
                    MessageBox.Show("Заполните адрес!", "Внимание:");
                }
                if (int.Parse(txtPurchase.Text) == 0)
                {
                    MessageBox.Show("Заполните оплату!", "Внимание:");
                }

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = '\0';
            }
        }

        private void txtCurrent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаем поля и устанавливаем значение 0
            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPrice.Text = "0.00";
            txtPurchase.Text = "0.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}