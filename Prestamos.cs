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
    public partial class Prestamos : Form
    {
        private int indice = 0;
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCuota.Text) || comboPlazo.SelectedIndex == -1 || ComboTipoPrestamo.SelectedIndex == -1)
            {

                MessageBox.Show("No se aceptan espacios en blancos");
            }
            else
            {


                if (ComboTipoPrestamo.SelectedItem.Equals("Vehiculo Nuevo"))
                {
                    if (double.Parse(txtCuota.Text) < 12000 || double.Parse(txtCuota.Text) > 36000)
                    {
                        MessageBox.Show("No se aceptan valores menores a 12,000 y valores mayores 36,000");
                    }
                    else
                    {

                        if (comboPlazo.SelectedItem.Equals("36s"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 36;

                            double calculo = cuota / 36;
                            double porcentaje = 12 * 0.18;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(36);
                            for (int i = 0; i < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                        if (comboPlazo.SelectedItem.Equals("48s"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 48;

                            double calculo = cuota / 48;
                            double porcentaje = 12 * 0.18;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(48);
                            for (int i = 0; i < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                        if (comboPlazo.SelectedItem.Equals("60ss"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 60;

                            double calculo = cuota / 60;
                            double porcentaje = 12 * 0.18;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(60);

                            for (int i = 0; 1 < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                        if (comboPlazo.SelectedItem.Equals("72"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 72;

                            double calculo = cuota / 72;
                            double porcentaje = 12 * 0.18;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(72);

                            for (int i = 0; 1 < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                    }

                }
                if (ComboTipoPrestamo.SelectedItem.Equals("Vehiculo Usado"))
                {
                    if (double.Parse(txtCuota.Text) < 1000 || double.Parse(txtCuota.Text) > 25000)
                    {
                        MessageBox.Show("No se aceptan valores menores a 12,000 y valores mayores 36,000");
                    }
                    else
                    {

                        if (comboPlazo.SelectedItem.Equals("36s"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 36;

                            double calculo = cuota / 36;
                            double porcentaje = 12 * 0.12;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(36);
                            for (int i = 0; i < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                        if (comboPlazo.SelectedItem.Equals("48s"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 48;

                            double calculo = cuota / 48;
                            double porcentaje = 12 * 0.12;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(48);
                            for (int i = 0; i < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                        if (comboPlazo.SelectedItem.Equals("60ss"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 60;

                            double calculo = cuota / 72;
                            double porcentaje = 12 * 0.12;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(60);

                            for (int i = 0; 1 < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                        if (comboPlazo.SelectedItem.Equals("72"))
                        {
                            double cuota = double.Parse(txtCuota.Text);
                            double plazo = 72;

                            double calculo = cuota / 72;
                            double porcentaje = 12 * 0.12;
                            double total = calculo + porcentaje;
                            textBox1.Text = total.ToString();

                            indice = dataGridView1.Rows.Add(72);

                            for (int i = 0; 1 < plazo; i++)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                                dataGridView1.Rows[i].Cells[1].Value = (cuota - total) - (i / cuota);
                                dataGridView1.Rows[i].Cells[2].Value = porcentaje;
                                dataGridView1.Rows[i].Cells[3].Value = cuota - total - (i * plazo);
                            }
                        }

                    }





                }
            }
        }

        private void txtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {

                if (txtCuota.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            else if (txtCuota.Text.Contains("."))
            {
                string[] parts = txtCuota.Text.Split('.');
                if (parts.Length > 1 && parts[1].Length >= 2)
                {
                    e.Handled = true;
                }
            }
        }
    }
}

