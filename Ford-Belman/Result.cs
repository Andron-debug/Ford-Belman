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
        List<int>[] weys;
        public Result(double[] d, int s, List<int>[] w)
        {
            InitializeComponent();
            D = d;
            start = s;
            weys = w;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (weys != null)
            {
                result_textBox.Text = $"Расстояния от {start} до {Environment.NewLine}";
            for (int i = 0; i < D.Length; i++)
                if (D[i] != double.PositiveInfinity)
                    result_textBox.Text += $"{i}: {D[i]}{Environment.NewLine}";
                else
                    result_textBox.Text += $"{i}: Вершина не достижима{Environment.NewLine}";
            
                result_textBox.Text += $"Кротчайшие пути {start} до {Environment.NewLine}";
                for (int i = 0; i < D.Length; i++)
                    if (D[i] != double.PositiveInfinity)
                    {
                        result_textBox.Text += $"{i}: ";
                        foreach (int v in weys[i])
                            result_textBox.Text += $"{v} ";
                        result_textBox.Text += Environment.NewLine;
                    }
                    else
                        result_textBox.Text += $"{i}: Вершина не достижима{Environment.NewLine}";

            }else
            {
                result_textBox.Text += "Граф (орграф) содержит цыклы отрицательной длинны";
            }

        }
    }
}
