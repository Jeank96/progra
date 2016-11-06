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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                string SKU = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                SqlCommand borrar_producto = new SqlCommand("Delete from carrito where SKU = " + SKU, conn);
                conn.Open();
                borrar_producto.ExecuteNonQuery();
                conn.Close();
            }
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

        }

        private void button2_Click(object sender, EventArgs e)

        {
            /*
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                
                string identificador_pedido =;
                string fecha_del_pedido =;
                string codigo_cliente =;
                string condicion_de_pago =;
                string identificador_personal_asignado =;
                string fecha_estimada_entrega =;
                string cantidad_pedida =;
                string precio_de_venta_unitario =;
                string descuento =;
                string impuesto_de_ventas =;
                string precio_total =;
                string estado_del_pedido =;
                string descripcion =;
                

                SqlCommand insertar_pedido = new SqlCommand("Insert into PEDIDOS values (" + identificador_pedido + "," + fecha_del_pedido + "," + codigo_cliente + "," + condicion_de_pago + ","+ identificador_personal_asignado + "," + fecha_estimada_entrega + "," + cantidad_pedida + "," + precio_de_venta_unitario + "," + descuento + "," + impuesto_de_ventas + "," + precio_total + "," + estado_del_pedido + "," + descripcion +")", conn);
                conn.Open();


                insertar_pedido.ExecuteNonQuery();

                conn.Close();

            }
        }
        */
        }
    }
}


        


    
