using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLav
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelsam.Text = "Самовывоз\nиз 1 магазина DNS";
            labelpan3.Text = "Часы работы:\n 18:30 - 21:40";
            labelopl2.Text = "Оплата наличными в\nпункте самовывоза";
            labelopl4.Text = "Оплата картой в\nпункте самовывоза";
            labelpan8.Hide();
            txtpromo.Hide();
            btnpromo.Hide();
            labelpan9.Hide();
            labelpan9.Text = "";
            comboBox1.Size = new System.Drawing.Size(151, 21);
            DateTime current = DateTime.Now;
            int day = current.Day;
            int month = current.Month;
            int hour = current.Hour;
            comboBox2.Items.AddRange(new object[] {
            "Сегодня, " + day + " " + (DateTime.Now.ToString("MMM")),
            "Завтра, " + (day + 1) + " " + (DateTime.Now.ToString("MMM"))});
            comboBox2.Text = "Сегодня, " + day + " " + (DateTime.Now.ToString("MMM"));
            comboBox3.Text = (hour + 1) + ":00-" + (hour + 3) + ":00 бесплатно";
            labelitog3.Hide();
            labelpromo.Hide();

        }
        // Когда курсор на кнопке (кнопка самовывоза)
        private void btnsam_MouseEnter(object sender, EventArgs e)
        {
            labelsam.Enabled = false;
            labelsam2.Enabled = false;
            picsam.Enabled = false;
            labelsam.BackColor = Color.FromArgb(217, 217, 217);
            labelsam2.BackColor = Color.FromArgb(217, 217, 217);
            picsam.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Когда курсора нет на кнопке (кнопка самовывоза)
        private void btnsam_MouseLeave(object sender, EventArgs e)
        {
            labelsam.Enabled = true;
            labelsam2.Enabled = true;
            picsam.Enabled = true;
            labelsam.BackColor = System.Drawing.SystemColors.Control;
            labelsam2.BackColor = System.Drawing.SystemColors.Control;
            picsam.BackColor = System.Drawing.SystemColors.Control;
        }
        // Когда курсор на кнопке (кнопка доставки)
        private void btndos_MouseEnter(object sender, EventArgs e)
        {
            labeldos.Enabled = false;
            labeldos2.Enabled = false;
            picdos.Enabled = false;
            labeldos.BackColor = Color.FromArgb(217, 217, 217);
            labeldos2.BackColor = Color.FromArgb(217, 217, 217);
            picdos.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Когда курсора нет на кнопке (кнопка доставки)
        private void btndos_MouseLeave(object sender, EventArgs e)
        {
            labeldos.Enabled = true;
            labeldos2.Enabled = true;
            picdos.Enabled = true;
            labeldos.BackColor = System.Drawing.SystemColors.Control;
            labeldos2.BackColor = System.Drawing.SystemColors.Control;
            picdos.BackColor = System.Drawing.SystemColors.Control;
        }
        // Нажатие на кнопку доставки
        private void btndos_Click(object sender, EventArgs e)
        {
            btndos.ForeColor = Color.FromArgb(255, 128, 0);
            btnsam.ForeColor = Color.FromArgb(64, 64, 64);
            panelscnd.Location = new System.Drawing.Point(22, 174);
            panelfst.Location = new System.Drawing.Point(818, 174);
            labelopl2.Text = "Оплата наличными\nкурьеру";
            labelopl4.Text = "Оплата картой курьеру";
        }
        // Нажатие на кнопку самовывоза
        private void btnsam_Click(object sender, EventArgs e)
        {
            btnsam.ForeColor = Color.FromArgb(255, 128, 0);
            btndos.ForeColor = Color.FromArgb(64, 64, 64);
            panelfst.Location = new System.Drawing.Point(22, 174);
            panelscnd.Location = new System.Drawing.Point(818, 174);
            labelopl2.Text = "Оплата наличными в\nпункте самовывоза";
            labelopl4.Text = "Оплата картой в\nпункте самовывоза";

        }
        // Нажатие/зажатие на кнопку самовывоза (замена фона)
        private void btnsam_MouseDown(object sender, MouseEventArgs e)
        {
            
            labelsam.BackColor = Color.FromArgb(229, 229, 229);
            labelsam2.BackColor = Color.FromArgb(229, 229, 229);
            picsam.BackColor = Color.FromArgb(229, 229, 229);
        }
        // Нажатие/зажатие на кнопку доставка (замена фона)
        private void btndos_MouseDown(object sender, MouseEventArgs e)
        {
            labeldos.BackColor = Color.FromArgb(229, 229, 229);
            labeldos2.BackColor = Color.FromArgb(229, 229, 229);
            picdos.BackColor = Color.FromArgb(229, 229, 229);
        }
        // Отпускание нопки самовывоза (замена фона)
        private void btnsam_MouseUp(object sender, MouseEventArgs e)
        {
            labelsam.BackColor = Color.FromArgb(217, 217, 217);
            labelsam2.BackColor = Color.FromArgb(217, 217, 217);
            picsam.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Отпускание нопки достаки (замена фона)
        private void btndos_MouseUp(object sender, MouseEventArgs e)
        {
            labeldos.BackColor = Color.FromArgb(217, 217, 217);
            labeldos2.BackColor = Color.FromArgb(217, 217, 217);
            picdos.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Когда курсор на кнопке (кнопка оплата наличными)
        private void btnnal_MouseEnter(object sender, EventArgs e)
        {
            labelopl.Enabled = false;
            labelopl2.Enabled = false;
            labelopl.BackColor = Color.FromArgb(217, 217, 217);
            labelopl2.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Когда курсор не на кнопке (кнопка оплата наличными)
        private void btnnal_MouseLeave(object sender, EventArgs e)
        {
            labelopl.Enabled = true;
            labelopl2.Enabled = true;
            labelopl.BackColor = System.Drawing.SystemColors.Control;
            labelopl2.BackColor = System.Drawing.SystemColors.Control;
        }
        // Нажатие/зажатие на кнопку оплаты наличными (замена фона)
        private void btnnal_MouseDown(object sender, MouseEventArgs e)
        {
            labelopl.BackColor = Color.FromArgb(229, 229, 229);
            labelopl2.BackColor = Color.FromArgb(229, 229, 229);

        }
        // Отпускание нопки оплаты наличными (замена фона)
        private void btnnal_MouseUp(object sender, MouseEventArgs e)
        {
            labelopl.BackColor = Color.FromArgb(217, 217, 217);
            labelopl2.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Нажатие на кнопку наличной оплаты
        private void btnnal_Click(object sender, EventArgs e)
        {
            btnnal.ForeColor = Color.FromArgb(255, 128, 0);
            btnkart.ForeColor = Color.FromArgb(64, 64, 64);
        }
        // Когда курсор на кнопке (кнопка оплата картой)
        private void btnkart_MouseEnter(object sender, EventArgs e)
        {
            labelopl3.Enabled = false;
            labelopl4.Enabled = false;
            labelopl3.BackColor = Color.FromArgb(217, 217, 217);
            labelopl4.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Когда курсор не на кнопке (кнопка оплата картой)
        private void btnkart_MouseLeave(object sender, EventArgs e)
        {
            labelopl3.Enabled = true;
            labelopl4.Enabled = true;
            labelopl3.BackColor = System.Drawing.SystemColors.Control;
            labelopl4.BackColor = System.Drawing.SystemColors.Control;
        }
        // Нажатие/зажатие на кнопку оплаты картой (замена фона)
        private void btnkart_MouseDown(object sender, MouseEventArgs e)
        {
            labelopl3.BackColor = Color.FromArgb(229, 229, 229);
            labelopl4.BackColor = Color.FromArgb(229, 229, 229);
        }
        // Отпускание нопки оплаты картой (замена фона)
        private void btnkart_MouseUp(object sender, MouseEventArgs e)
        {
            labelopl3.BackColor = Color.FromArgb(217, 217, 217);
            labelopl4.BackColor = Color.FromArgb(217, 217, 217);
        }
        // Нажатие на кнопку оплаты картой
        private void btnkart_Click(object sender, EventArgs e)
        {
            btnkart.ForeColor = Color.FromArgb(255, 128, 0);
            btnnal.ForeColor = Color.FromArgb(64, 64, 64);
        }
        // Проверка на нажатие кнопки промкод
        private void promo_CheckedChanged(object sender, EventArgs e)
        {
            if (promo.Checked)
            {
                labelpan8.Show();
                txtpromo.Show();
                btnpromo.Show();
                labelpan9.Show();
            }
            else
            {
                labelpan8.Hide();
                txtpromo.Hide();
                btnpromo.Hide();
                labelpan9.Hide();    
            }
        }
        // Нажатие на кнопку применить промокод
        private void btnpromo_Click(object sender, EventArgs e)
        {
            string zam = "";
            zam = labelic.Text;
            if (txtpromo.Text == "NEW10")
            {
                labelpan9.Text = "Вы успешно применили промокод на 10%";
                labelpan9.ForeColor = Color.FromArgb(3, 192, 60);
                labelitog3.Show();
                labelpromo.Show();
                labelic.Text = labelskidon.Text;
            }
            else
            {
                labelpan9.Text = "Данного промокода не существует!";
                labelpan9.ForeColor = Color.FromArgb(255, 0, 0);
                labelitog3.Hide();
                labelpromo.Hide();
                if (zam != "")
                {
                    labelic.Text = zam;
                }
            }
        }



        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Size = new System.Drawing.Size(151, 21);
            }
            else
            {
                comboBox1.Size = new System.Drawing.Size(151, 150);
            }
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox1.Size = new System.Drawing.Size(151, 21);
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            DateTime current = DateTime.Now;
            int day = current.Day;
            int month = current.Month;
            int hour = current.Hour;
            if (comboBox2.Text == "Завтра, " + (day + 1) + " " + (DateTime.Now.ToString("MMM")))
            {
                hour = 9;
                comboBox3.Text = (hour + 1) + ":00-" + (hour + 3) + ":00 бесплатно";
            } else
            {
                comboBox3.Text = (hour + 1) + ":00-" + (hour + 3) + ":00 бесплатно";
            }
            for (int i = hour + 1; i <= 20; i++)
            {
                comboBox3.Items.AddRange(new object[] {
            i + ":00-" + (i+2) + ":00 бесплатно"});
            }
        }

    }
}
