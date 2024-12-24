using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ras4et_kom_uslug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPrice.Text = "0";
            txtPurchase.Text = "0";
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCurrent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private double getPurchase(int pCurrnet, int pLast, double price)
        {
            double pruchase = (pCurrnet - pLast) * price;
            return pruchase;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCurrent.Text != "" && txtLast.Text != "" && txtPrice.Text != "")
            {
                int pCurrent = Convert.ToInt32(txtCurrent.Text);
                int pLast = Convert.ToInt32(txtLast.Text);
                double pPrice = Convert.ToInt32(txtPrice.Text);


                if (pCurrent >= pLast)
                {
                    double purchase = getPurchase(pCurrent, pLast, pPrice);
                    txtPurchase.Text = purchase.ToString();
                }


                else
                {

                    MessageBox.Show("Текущее занчение должно быть больше предыдущего");
                }
            }

        }

        private void txtPurchase_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtAdress.Text != "" && int.Parse(txtPurchase.Text) != 0)

            {
                MessageBox.Show($"Платеж {dateTimePicker1.Text} принят ! \n Платильщик {txtLastName.Text} {txtFirstName.Text} ");
            }
            else
            {
                if (txtLastName.Text == "")

                    MessageBox.Show("Заполните фамилию!");
                if (txtFirstName.Text == "")

                    MessageBox.Show("Заполните имя ");
                if (txtAdress.Text == "")

                    MessageBox.Show("Заполните адресс!");
            }
            if (int.Parse(txtPurchase.Text) == 0)

                MessageBox.Show("Вычеслите оплату !");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtCurrent_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.KeyChar = '\0';

                label8.Text = "Разрешины только цифры !";
            }
            else
                label8.Text = "";
            
                

        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar!= (char)Keys.Back && e.KeyChar!= '.')
            {
                e.KeyChar = '\0';
                label9.Text = "Разрешины только цифры !";
            }
            else
                label9.Text = "";

        

    }
        private void button2_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtAdress.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    } 
   
}