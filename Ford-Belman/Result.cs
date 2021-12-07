using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ford_Belman
{
    public partial class Result : Form
    {
        private double[] D;
        int start;
        public Result(double[] d, int s)
        {
            InitializeComponent();
            D = d;
            start = s;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            result_textBox.Text = $"Расстояния от {start} до {Environment.NewLine}";
            for (int i = 0; i < D.Length; i++)
                if (D[i] != double.PositiveInfinity)
                    result_textBox.Text += $"{i}: {D[i]}{Environment.NewLine}";
                else
                    result_textBox.Text += $"{i}: Вершина не достижима{Environment.NewLine}";
        }
    }
}
