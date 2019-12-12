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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var capEntities = new Entities.Productos();
            var capBussines = new Shoes_Bussines.CapaNegocio();
            Productos agregarProducto = new Productos();
            agregarProducto.idType = int.Parse(numericUpDown1.Text);
            agregarProducto.idColor = int.Parse(numericUpDown2.Text);
            agregarProducto.idBrand = int.Parse(numericUpDown3.Text);
            agregarProducto.idProvider = int.Parse(numericUpDown4.Text);
            agregarProducto.idCatalog = int.Parse(numericUpDown5.Text);
            agregarProducto.Tittle = textBox1.Text;
            agregarProducto.Nombre = textBox2.Text;
            agregarProducto.Descripcion = textBox3.Text;
            agregarProducto.Observaciones = textBox4.Text;
            agregarProducto.PrecioDistribuidor = decimal.Parse(textBox5.Text);
            agregarProducto.PrecioCliente = int.Parse(textBox6.Text);
            agregarProducto.PrecioMiembro = int.Parse(textBox7.Text);
            if(textBox8.Text == "0")
            {
                agregarProducto.IsEnabled = false;
                label16.Hide();
            }else if( textBox8.Text == "1")
            {
                agregarProducto.IsEnabled = true;
                label16.Hide();
            }
            else
            {
                label16.Text = "Ingrese un 0 si es descontinuado y 1 si esta en existencia.";
            }
            agregarProducto.Keywords = textBox9.Text;
            agregarProducto.DateUpdate = dateTimePicker1.Value.Date;
            var estado = capBussines.InsertIntoTable(agregarProducto);
            if(estado == true)
            {
                label17.Text = "El producto se ha insertado correctamente";
            }
            else
            {
                label17.Text = "No se pudo, ya fue";
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            label17.Text = "";
        }
    }
}
