using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3
{
    public partial class FormSettings : Form
    {
        readonly FormCollection F = Application.OpenForms; //для передачи индекса формы, чтобы иметь возможность менять бэкколор

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (F[0].BackColor == ColorTranslator.FromHtml("#363636")) //при запуске проверяет цвет главного окна и ставит галочку у тёмного фона, если он включен
            {
                radioButton2.Checked = true; //по умолчанию true стоит у первой кнопки, тут происходит замена
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) //при выборе фона происходит перекрас окон
        {
            F[0].BackColor = Color.White;
            F[1].BackColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        {
            //при выборе фона происходит перекрас окон, здесь мне удобнее и быстрее было найти и использовать конвертацию из html-имени цвета
            F[0].BackColor = ColorTranslator.FromHtml("#363636");
            F[1].BackColor = ColorTranslator.FromHtml("#363636");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //вывод справки при нажатии на кнопку
            MessageBox.Show("Множество целых чисел: \n 1) объединение двух множеств (как сумма множеств), \n 2) пересечение двух множеств (как произведение множеств), \n 3) разность двух множеств, \n 4) добавление элемента к множеству (как сумма с числом), \n 5) удаление элемента из множества (как разность с числом)", "Справка");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //для перехода по ссылке
        {
            this.linkLabel1.LinkVisited = true; //ссылка после нажатия отображается как посещённая

            System.Diagnostics.Process.Start("http://olive.tealeaf.su"); //открытие браузера и страницы в сети Интернет
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //для перехода по ссылке
        {
            this.linkLabel2.LinkVisited = true; //ссылка после нажатия отображается как посещённая

            System.Diagnostics.Process.Start("http://olive.tealeaf.su/labs/custom-type.html"); //открытие браузера и страницы в сети Интернет
        }
    }
}
