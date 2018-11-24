using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigFileReader
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            var f = new StreamReader(textBox1.Text);
            int n = 0;
            int ini = 0;
            int MAX = (int)numericUpDown2.Value;
            while (!f.EndOfStream)
            {
                string linia = f.ReadLine();
                ini++;
                if (ini < numericUpDown1.Value)
                    continue;
                textBox2.AppendText(linia + Environment.NewLine);
                n++;
                if (n >= MAX)
                    break;
            }
            f.Close();
        }
    }
}
