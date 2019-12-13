using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace ShoesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (textBox1.Text == null || textBox1.Text == "" || textBox2.Text == "" || textBox2.Text == null)
            {
                button4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            button4.Visible = true;
            var capaBussines = new Shoes_Bussines.CapaNegocio();
            var nombre = textBox2.Text;
            bool res = int.TryParse(textBox1.Text, out id);
            var lista = capaBussines.GetProduct(id, nombre);
            if(lista.Count == 0)
            {
                MessageBox.Show("El producto fue borrado de la bd o nunca existio.");
            }
            dataGridView1.Rows.Clear();
            foreach (var item in lista)
            {
                if (item.IsEnabled == false)
                {
                    MessageBox.Show("El producto esta descontinuado.");
                }
                else
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.id });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Tittle });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Descripcion });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioCliente });
                    dataGridView1.Rows.Add(row);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var capBussines = new Shoes_Bussines.CapaNegocio();
            var nombre = textBox2.Text;
            var id = int.Parse(textBox1.Text);
            var estado = capBussines.DisabledProduct(id, nombre);
            if(estado == true)
            {
                MessageBox.Show("El producto ha sido deshabilitado");
            }
            else
            {
                MessageBox.Show("A ocurrido un error al intentar deshabilitar el producto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(int.Parse(textBox1.Text));
            f3.ShowDialog();
        }
    }
}
