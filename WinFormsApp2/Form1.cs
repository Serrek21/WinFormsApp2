using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = new (TextBox t, string c, string q)[]
            {
                (textBox1, "3", "Скільки кутів в трикутника"),
                (textBox2, "46", "Скільки хромосом в людей"),
                (textBox3, "90", "Скільки градусів має 1 кут квадрата"),
                (textBox4, "3", "В скільки починається ранок"),
                (textBox5, "Юсейн Болт", "Сама шквидка людина в світі"),
                (textBox6, "Синій кит", "Сама велика тварина в світі"),
                (textBox7, "Султан Косен", "Хто найбільша людина в світі"),
                (textBox8, "4", "Скільки кутів в ромба"),
                (textBox9, "Персонаж", "Хто такий тайлер дерден"),
                (textBox10, "44", "Скільки хромосом в жаб")
            };

            int count = 0;
            string w = "";

            for (int i = 0; i < a.Length; i++)
            {
                var (t, c, q) = a[i];
                if (t.Text == c)
                {
                    count++;
                }
                else
                {
                    w += $"{i + 1}. Запитання: {q}\nНеправильно\nВаша відповідь: {t.Text}\nПравильна відповідь: {c}\n\n";
                }
            }

            if (!string.IsNullOrWhiteSpace(w))
            {
                MessageBox.Show(w);
            }

            MessageBox.Show($"Ви маєте {count} правильних відповідей.");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
