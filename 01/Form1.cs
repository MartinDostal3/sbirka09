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

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
           
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            // Vytvořit textový soubor
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                int n = int.Parse(textBox1.Text);
               
                for (int i = 1; i <= n; i++)
                {
                    string line = new string('*', i);
                    sw.WriteLine(line);
                }
            }

            MessageBox.Show("Soubor úspěšně vytvořen!");
        }
    }
}
