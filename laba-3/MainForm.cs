using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3
{ 
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            operationBox.Text = "+"; //операция при запуске по умолчанию для предотвращения ситуаций, когда юзер не выберет её, и в итоге вылезает не то, что ожидалось
            this.BackColor = Color.White; //фон по умолчанию
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //вывод справки перед стартом программы
            MessageBox.Show("Множество целых чисел: \n 1) объединение двух множеств (как сумма множеств), \n 2) пересечение двух множеств (как произведение множеств), \n 3) разность двух множеств, \n 4) добавление элемента к множеству (как сумма с числом), \n 5) удаление элемента из множества (как разность с числом)", "Справка");
        }

        private void operationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logic.Calc(setBox1, setBox2, checkBox1, checkBox2, operationBox, resultBox); //пересчёт результата при изменении операции юзером
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Logic.Calc(setBox1, setBox2, checkBox1, checkBox2, operationBox, resultBox); //пересчёт результата при изменении множества на число и наоборот юзером
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Logic.Calc(setBox1, setBox2, checkBox1, checkBox2, operationBox, resultBox); //пересчёт результата при изменении множества на число и наоборот юзером
        }

        private void setBox1_TextChanged(object sender, EventArgs e)
        {
            Logic.Calc(setBox1, setBox2, checkBox1, checkBox2, operationBox, resultBox); //пересчёт результата при изменении множества юзером
        }

        private void setBox2_TextChanged(object sender, EventArgs e)
        {
            Logic.Calc(setBox1, setBox2, checkBox1, checkBox2, operationBox, resultBox); //пересчёт результата при изменении множества юзером
        }

        private void button1_Click(object sender, EventArgs e) //вывод нового окна при выборе настроек
        {
            FormSettings FormSettings = new FormSettings();
            FormSettings.Show();
        }

        private void button2_Click_1(object sender, EventArgs e) //стирание результатов и исходных данных при нажатии на соответствующую кнопку
        {
            setBox1.Text = "";
            setBox2.Text = "";
            resultBox.Text = "";
        }
    }


    public class Set
    {
        private double[] userarray;
        public Set(double[] arr)
        {
            this.userarray = arr;
        }
        public Set(string str) //ищет в строке цифры, чтобы записать их в массив с помощью регулярных выражений
        {
            this.userarray = Regex.Matches(str, @"\d+")
                .Cast<Match>()
                .Select(x => double.Parse(x.ToString()))
                .ToArray();
        }
        public override string ToString() //переопределение операции перевода в string
        {
            return String.Join(" ", this.userarray);
        }

        public static Set operator +(Set a, Set b) //переопределение операции +
        {
            IEnumerable<double> result = a.userarray.Union(b.userarray);
            return new Set(result.ToArray());
        }
        public static Set operator *(Set a, Set b) //переопределение операции *
        {
            IEnumerable<double> result = a.userarray.Intersect(b.userarray);
            return new Set(result.ToArray());
        }
        public static Set operator -(Set a, Set b) //переопределение операции -
        {
            IEnumerable<double> result = a.userarray.Except(b.userarray);
            return new Set(result.ToArray());
        }
        public override bool Equals(object obj) //переопределение сравнения
        {
            var B = obj as Set;
            if (B == null) return false;
            for (int i = 0; i < this.userarray.Length; i++)
            {
                if (this.userarray[i] != B.userarray[i]) return false;
            }
            return true;
        }

        public override int GetHashCode() //это предложил сделать Intellisense
        {
            return base.GetHashCode();
        }
    }

    public class Logic
    {
        public static void Calc(MaskedTextBox setBox1, MaskedTextBox setBox2, CheckBox checkBox1, CheckBox checkBox2, ComboBox operationBox, TextBox resultBox) //присваиваем значения из текстбокса и вызываем методы для подсчёта результата, его вывода
        {
            Set a = Logic.InitSet(setBox1, checkBox1.Checked);
            Set b = Logic.InitSet(setBox2, checkBox2.Checked);
            string operation = operationBox.Text;

            Logic.PrintResult(Logic.GetResult(a, b, operation), resultBox); //вывод в текстбокс
        }
        public static Set GetResult(Set a, Set b, string operation) //подсчёт с помощью переопределённых операций, которые программа определяет сама по выбранным аргументам
        {
            switch (operation)
            {
                case "+": return a + b;
                case "*": return a * b;
                case "-": return a - b;
                default: return a + b;
            }
        }

        public static void PrintResult(Set result, TextBox output) //вывод результата в текстбокс
        {
            output.Text = result.ToString();
        }
        public static Set InitSet(MaskedTextBox input, bool isNumber) //проверяет на число - если истина, то убирает все ошибочные пробелы между введёнными юзером символами
        {
            string set = input.Text.Trim();

            if (isNumber)
            {
                set = set.Replace(" ", "");
            }

            return new Set(set); //возвращает число или множество
        }
    }
}
