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
                (textBox1, "3", "������ ���� � ����������"),
                (textBox2, "46", "������ �������� � �����"),
                (textBox3, "90", "������ ������� �� 1 ��� ��������"),
                (textBox4, "3", "� ������ ���������� �����"),
                (textBox5, "����� ����", "���� ������� ������ � ���"),
                (textBox6, "���� ���", "���� ������ ������� � ���"),
                (textBox7, "������ �����", "��� �������� ������ � ���"),
                (textBox8, "4", "������ ���� � �����"),
                (textBox9, "��������", "��� ����� ������ ������"),
                (textBox10, "44", "������ �������� � ���")
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
                    w += $"{i + 1}. ���������: {q}\n�����������\n���� �������: {t.Text}\n��������� �������: {c}\n\n";
                }
            }

            if (!string.IsNullOrWhiteSpace(w))
            {
                MessageBox.Show(w);
            }

            MessageBox.Show($"�� ���� {count} ���������� ��������.");
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
