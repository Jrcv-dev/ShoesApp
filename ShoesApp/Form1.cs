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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var capaBussines = new Shoes_Bussines.CapaNegocio();
            var nombre = textBox2.Text;
            var id = int.Parse(textBox1.Text);
            var lista = capaBussines.GetProduct(id, nombre);
            dataGridView1.Rows.Clear();
            foreach (var item in lista)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.id });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Tittle });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Descripcion });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PrecioCliente});
                dataGridView1.Rows.Add(row);
            }

        }
    }
}
