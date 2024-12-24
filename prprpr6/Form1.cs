using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oplata_tovara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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



        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCurrent.Text) && !string.IsNullOrWhiteSpace(txtLast.Text) && txtbonusCard.SelectedItem != null)
            {
                
                    // Преобразование значений из текстовых полей
                    int pCurrent = Convert.ToInt32(txtCurrent.Text);
                    int pLast = Convert.ToInt32(txtLast.Text);
                string bonus_card = txtbonusCard.SelectedItem.ToString();  

                if (pCurrent > 0 && pLast > 0)
                {
                    // Расчет скидки
                    double discountPercent = 0;
                    if (bonus_card == "нет")
                    {
                        discountPercent = 0;
                    }
                    else if (bonus_card == "обычная")
                    {
                        discountPercent = 1;
                    }
                    else if (bonus_card == "золотая")
                    {
                        discountPercent = 5;
                    }
                    else if (bonus_card == "платиновая")
                    {
                        discountPercent = 10;
                    }

                    // Расчет итоговой стоимости
                    double totalCost = pCurrent * pLast; // Общая стоимость
                    double discount = (totalCost * discountPercent) / 100; // Скидка
                    double finalCost = totalCost - discount; // Итоговая стоимость с учетом скидки

                    // Отображение результата
                    txtPurchase.Text = finalCost.ToString();
                }
                else
                {
                    MessageBox.Show("Текущая и последняя стоимость должны быть больше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                }
        }

            private void txtPurchase_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbonusCard.Text = "нет";
            txtCurrent.Text = "0";
            txtLast.Text = "0";
            txtPurchase.Text = "0";
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtModel.Text != "" && int.Parse(txtPurchase.Text) != 0)

            {
                MessageBox.Show($"Оплата прощда успешна {dateTimePicker1.Text} ! \n Товар  {txtModel.Text} {txtFirstName.Text} К оплате {txtPurchase.Text} руб. ");
            }
            else
            {
                if (txtLastName.Text == "")

                    MessageBox.Show("Заполните производителя!");
                if (txtFirstName.Text == "")

                    MessageBox.Show("Заполните марку ");
                if (txtModel.Text == "")

                    MessageBox.Show("Заполните модель!");
            }
            if (int.Parse(txtPurchase.Text) == 0)

                MessageBox.Show("Вычеслите оплату !");

        }

        // Ограничение ввода только цифр
        private void txtPricePerUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtLastName.Text = "";
            txtLastName.Text = "";
            txtModel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

