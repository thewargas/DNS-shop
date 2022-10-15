using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopLav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt1.Text = ("В корзине нет товаров");
        }
        public int s, summ, skidka;

        private void btnof_Click(object sender, EventArgs e)
        {
            if (summ > 0)
            {
                Form2 frm = new Form2();
                this.Hide();
                switch (summ)
                {
                    case 0:
                        txt1.Text = ("В корзине нет товаров");
                        break;
                    case 1:
                        frm.labelkor.Text = ("В заказе " + summ + " товар на сумму " + s.ToString("#,#") + " ₽");
                        break;
                    case 2:
                        frm.labelkor.Text = ("В заказе " + summ + " товара на сумму " + s.ToString("#,#") + " ₽");
                        break;
                    case 3:
                        frm.labelkor.Text = ("В заказе " + summ + " товара на сумму " + s.ToString("#,#") + " ₽"); // Можно было бы ограничиться 3-мя case'ами, но нужен реляционный шаблон, который не доступен в моей версии(case > 1 && < 5)
                        break;
                    case 4:
                        frm.labelkor.Text = ("В заказе " + summ + " товара на сумму " + s.ToString("#,#") + " ₽"); // Можно было бы ограничиться 3-мя case'ами, но нужен реляционный шаблон, который не доступен в моей версии(case > 1 && < 5)
                        break;
                    default:
                        frm.labelkor.Text = ("В заказе " + summ + " товаров на сумму " + s.ToString("#,#") + " ₽");
                        break;


                }
                int p = 20;
                int h = 0;
                int t;
                t = ((int)num1.Value * 59999) + ((int)num2.Value * 59999) + ((int)num3.Value * 109999) + ((int)num4.Value * 149999);
                frm.labeltov.Text = t.ToString("#,#") + " ₽";
                frm.labelskid.Text = "";
                skidka = s / 10;
                frm.labelskidon.Text = Convert.ToString(s - skidka) + " ₽";
                frm.labelpromo.Text = "-" + skidka.ToString("#,#") + " ₽";
                frm.labelic.Text = s.ToString("#,#") + " ₽";
                if ((int)num1.Value > 0)
                {
                    p += 80;
                    frm.panel1.Size = new System.Drawing.Size(300, p);
                    frm.labelim.Text += ("Видеокарта GIGABYTE GeForce RTX 3050 \nGAMING OC [GV-N3050GAMING OC-8GD] \n"
                        + (int)num1.Value + " шт. x 54 999 ₽ \n\n");
                    h += ((int)num1.Value * 5000);

                }
                if ((int)num2.Value > 0)
                {
                    p += 80;
                    frm.panel1.Size = new System.Drawing.Size(300, p);
                    frm.labelim.Text += ("Видеокарта ASUS GeForce RTX 3060 \nGAMING OC [GV-N3060GAMING OC-12GD] \n"
                        + (int)num2.Value + " шт. x 59 999 ₽ \n\n");
                }
                if ((int)num3.Value > 0)
                {
                    p += 80;
                    frm.panel1.Size = new System.Drawing.Size(300, p);
                    frm.labelim.Text += ("Видеокарта GIGABYTE GeForce RTX 3070 \nGAMING OC [GV-N3070GAMING OC-12GD] \n"
                        + (int)num3.Value + " шт. x 99 999 ₽ \n\n");
                    h += ((int)num3.Value * 10000);
                }
                if ((int)num4.Value > 0)
                {
                    p += 80;
                    frm.panel1.Size = new System.Drawing.Size(300, p);
                    frm.labelim.Text += ("Видеокарта GIGABYTE GeForce RTX 3080 \nGAMING OC [GV-N3080GAMING OC-24GD] \n"
                        + (int)num4.Value + " шт. x 149 999 ₽ \n\n");
                }
                frm.labelskid.Text = "-" + h.ToString("#,#") + " ₽";
                frm.ShowDialog();
                this.Show();
                frm.Dispose();
            } else
            {
                txt1.Text = ("В корзине нет товаров! Выберите товар.");
                txt1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            summ = (int)num1.Value + (int)num2.Value + (int)num3.Value + (int)num4.Value;
            s = ((int)num1.Value * 54999) + ((int)num2.Value * 59999) + ((int)num3.Value * 99999) + ((int)num4.Value * 149999);
            txt1.Text = ("В корзине нет товаров! Выберите товар.");
            txt1.ForeColor = System.Drawing.Color.Black;
            switch (summ)
            {
                case 0:
                    txt1.Text = ("В корзине нет товаров");
                    break;
                case 1:
                    txt1.Text = (summ + " товар на сумму " + s.ToString("#,#") + " ₽");
                    break;
                case 2:
                    txt1.Text = (summ + " товара на сумму " + s.ToString("#,#") + " ₽");
                    break;
                case 3:
                    txt1.Text = (summ + " товара на сумму " + s.ToString("#,#") + " ₽"); // Можно было бы ограничиться 3-мя case'ами, но нужен реляционный шаблон, который не доступен в моей версии(case > 1 && < 5)
                    break;
                case 4:
                    txt1.Text = (summ + " товара на сумму " + s.ToString("#,#") + " ₽"); // Можно было бы ограничиться 3-мя case'ами, но нужен реляционный шаблон, который не доступен в моей версии(case > 1 && < 5)
                    break;
                default:
                    txt1.Text = (summ + " товаров на сумму " + s.ToString("#,#") + " ₽");
                    break;


            }

        }
    }
}
