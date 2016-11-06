using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_2_sistema_de_ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                //condicion de pago
                string SKU = this.textBox1.Text;
                string Descripcion = this.textBox2.Text;
                string Costo_unitario = this.textBox3.Text;
                string Precio_de_venta_unitario = this.textBox4.Text;
                string Existencias_en_el_inventario_internacional = this.textBox5.Text;
                string impuesto_de_ventas = this.textBox6.Text;

                
                SqlCommand insercion_productos = new SqlCommand("Insert into CATALOGO_DE_PRODUCTOS values (" + SKU + "," + " ' "+ Descripcion + " ' " + "," + Costo_unitario + "," + Precio_de_venta_unitario + "," + Existencias_en_el_inventario_internacional + "," + impuesto_de_ventas + ")", conn);
                
                //("Insert into CATALOGO_DE_PRODUCTOS(SKU, descripción_del_producto, costo_unitario, precio_de_venta_unitario, existencias_en_inventario, impuesto_de_ventas) values (" + SKU + "," + Descripcion + "," + Costo_unitario + "," + Precio_de_venta_unitario + "," + Existencias_en_el_inventario_internacional + "," + impuesto_de_ventas + ")", conn);

                conn.Open();
                insercion_productos.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                SqlDataAdapter consulta_productos = new SqlDataAdapter("SELECT * FROM CATALOGO_DE_PRODUCTOS", conn);

                conn.Open();


                DataSet newdataset = new DataSet();



                consulta_productos.Fill(newdataset);


                dataGridView1.DataSource = newdataset.Tables[0];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                string SKU = this.textBox7.Text;
                SqlCommand borrar_producto = new SqlCommand("Delete from CATALOGO_DE_PRODUCTOS where SKU = " + SKU, conn);
                conn.Open();
                borrar_producto.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
