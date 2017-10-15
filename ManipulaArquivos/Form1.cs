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

namespace ManipulaArquivos
{
    public partial class Form1 : Form
    {
        String arquivo = @"d:\enem3.html";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(arquivo))
            {
                MessageBox.Show("ARquivo existe");
            }
            else
            {
                MessageBox.Show("ARquivo não existe");
                // Create a file to write to.
                StreamWriter sw = File.CreateText(arquivo);
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                    sw.Close();
                }
            }
        }
    }
}
