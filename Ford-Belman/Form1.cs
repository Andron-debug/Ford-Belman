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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int v)
        {
            InitializeComponent();
            vertex_textBox.Text = v.ToString();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            try
            {
                int v = Convert.ToInt32(vertex_textBox.Text);
                if (v <= 0) throw new ApplicationException("Количество вершин должно быть больше 0");
                Form f = new Graf_input(v);
                f.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
