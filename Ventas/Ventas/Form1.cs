using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //categorias 
            var categoria1 = new Categoria();
            categoria1.Id = 1;
            categoria1.Nombre = "Celulares";

            var categoria2 = new Categoria();
            categoria2.Id = 1;
            categoria2.Nombre = "Articulo";

            //Productos
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Celular";
            producto1.Precio = 10000;
            producto1.Categoria = categoria1;

            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Television";
            producto2.Precio = 10000;
            producto2.Categoria = categoria1;

            Producto producto3 = new Producto();
            producto3.Id = 2;
            producto3.Descripcion = "Audifonos";
            producto3.Precio = 1000;
            producto3.Categoria = categoria2;


            var listadeproductos = new List<Producto>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            foreach (var p in listadeproductos)
            {
                MessageBox.Show(p.Categoria.Nombre + " " + p.Descripcion);
            }
 
        }
    }
}
