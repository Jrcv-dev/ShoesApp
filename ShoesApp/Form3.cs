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
    public partial class Form3 : Form
    {
        public int ID;
        public Form3(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var capBussines = new Shoes_Bussines.CapaNegocio();
            var listColors = capBussines.ObtenerColores();
            textBox2.Text = ID.ToString();
            foreach (var item in listColors)
            {
                comboBox1.Items.Add(item.Name);
            }
            var listSizes = capBussines.ObtenerTallas();
            foreach (var item in listSizes)
            {
                comboBox2.Items.Add(item.Code);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var capBussines = new Shoes_Bussines.CapaNegocio();
            Productos p = new Productos();
            p.id = int.Parse(textBox2.Text);
            p.Nombre = textBox1.Text;
            var Color = comboBox1.Text;
            if(Color == "Azul")
            {
                p.idColor = 1;
            }else if(Color == "Rojo")
            {
                p.idColor = 2;
            }else if(Color == "Verde")
            {
                p.idColor = 3;
            }else if(Color == "Negro")
            {
                p.idColor = 4;
            }else if(Color == "Blanco")
            {
                p.idColor = 5;
            }
            p.Descripcion = richTextBox1.Text;
            var estado = capBussines.UpdateProduct(p);
            if(estado == false)
            {
                MessageBox.Show("No se actualizo el producto");
            }
            else
            {
                MessageBox.Show("El producto ha sido actualizado");
            }
        }
    }
}
