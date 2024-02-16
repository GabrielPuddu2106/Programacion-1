using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_2
{
    public partial class Cambios : Form
    {
        public Cambios()
        {
            InitializeComponent();
        }

        private void Cambios_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if( String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("No se aceptan espacios en blanco");

            }
            else
            {
                double pedir = double.Parse(maskedTextBox1.Text);
                double conversion;
                if(treeView1.Nodes.Equals("tasa cambios"))
                {
                    if (treeView1.Nodes.Equals("Comprar"))
                    {
                        if (treeView1.Nodes.Equals("dolares"))
                        {
                            conversion = pedir * 36.99;
                            textBox1.Text = pedir.ToString();
                        }

                        else if (treeView1.Nodes.Equals("euros"))
                        {
                            conversion = (pedir * 1.72);
                            textBox1.Text = pedir.ToString();
                        }
                        
                    }

                    if (treeView1.Nodes.Equals("vender"))
                    {
                        if (treeView1.Nodes.Equals("dolares"))
                        {
                            conversion = pedir * 36.10;
                            textBox1.Text = pedir.ToString();
                        }

                        if (treeView1.Nodes.Equals("euros"))
                        {
                            conversion = pedir * 1.0270;
                            textBox1.Text = pedir.ToString();
                        }
                    }
                }
            }
        }
    }
}
