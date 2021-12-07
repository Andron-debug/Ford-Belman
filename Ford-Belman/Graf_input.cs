using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ford_Belman
{
    public partial class Graf_input : Form
    {
        TextBox[,] textBoxes;
        int vertex;
        public Graf_input(int v)
        {
            InitializeComponent();
            vertex = v;
        }

        private void Cayley_table_Load(object sender, EventArgs e)
        {
            textBoxes = new TextBox[vertex, vertex];
            Graf.ColumnCount = vertex + 1;
            Graf.RowCount =     vertex + 1;
            for (int i = 0; i < vertex; i++)
            {
                //Заполнение 0 строки
                Label l = new Label();
                l.Width = 10 * i.ToString().Length;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.Height = 22;
                l.Text = i.ToString();
                l.Height = 22;
                Graf.Controls.Add(l, 0, i + 1);

                //Заполнение 0 столбца
                Label l2 = new Label();
                l2.TextAlign = ContentAlignment.MiddleCenter;
                l2.Text = i.ToString();
                Graf.Controls.Add(l2, i + 1, 0);
            }
            // Заполнение таблицы
            for (int i = 1; i < vertex + 1; i++)
                for (int j = 1; j < vertex + 1; j++)
                {
                    textBoxes[i - 1, j - 1] = new TextBox();
                    Graf.Controls.Add(textBoxes[i - 1, j - 1], j, i);
                }

            foreach (ColumnStyle s in Graf.ColumnStyles) s.SizeType = SizeType.AutoSize;
            TextBox lt = textBoxes[vertex - 1, vertex - 1];
            if (lt.Location.X + lt.Width + 35 > 350)
                this.Width = lt.Location.X + lt.Width + 35;
            else
                this.Width = 400;
            this.Height = lt.Location.Y + lt.Height + 200;

        }
        /*
         Алгоритм Форда-Беллмана

            Исходные данные, определяемые пользователем:

            Пользователь задает взвешенный орграф. Веса — произвольные вещественные числа. Способ ввода — по усмотрению разработчика.

            Пользователь определяет вершину–начало (источник).

            Результат работы программы:

            Вычисляются расстояния и кратчайшие пути от источника до всех остальных вершин орграфа. В случае, если таковых нет, выдается соответствующая диагностика (Здесь необходимо различать случай, когда в соответствующей компоненте орграфа есть контуры отрицательной длины, и случай, когда нет достижимости из источника соответствующей вершины).

            Для вычисления расстояний необходимо использовать алгоритм Форда-Беллмана
         */
        private void Next_Click(object sender, EventArgs e)
        {
            double[,] graf = new double[vertex, vertex];
            bool ok = true;
            try
            {
                for (int i = 0; i< vertex; i++)
                    for(int j = 0; j<vertex; j++)
                    {
                        if ((is_graf.Checked) && (textBoxes[i, j].Text != textBoxes[j, i].Text)) throw new ApplicationException();
                        if ((i != j) && (textBoxes[i, j].Text != ""))
                            graf[i, j] = Convert.ToDouble(textBoxes[i, j].Text);
                        else if (i == j) graf[i, j] = 0;
                        else if (textBoxes[i, j].Text == "") graf[i, j] = double.PositiveInfinity;
                    }
            }
            catch (ApplicationException ex)
            {

                DialogResult result = MessageBox.Show("Матрица не симетрична! Провости симметризацию?", "Ошибка ввода", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) simertr();
                else ok = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ok = false;
            }
            if (ok)
            {
            }
        }

        private void Cayley_table_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(vertex);
            f.Show();
            this.Hide();
        }

       

        private void clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < vertex; i++)
                for (int j = 0; j < vertex; j++)
                    textBoxes[i, j].Text = "";
        }



        private void simetr_Click(object sender, EventArgs e)
        {
            simertr();
        }
        void simertr()
        {
            for (int i = 0; i < vertex; i++)
                for (int j = i; j < vertex; j++)
                    textBoxes[j, i].Text = textBoxes[i, j].Text;
        }
    }
}
