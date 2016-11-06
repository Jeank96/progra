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
            
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                
                string selected = Form1.selectedStatic;
                DataSet cliente = Form1.cliente;
                

                SqlDataAdapter agregar_info_carrito = new SqlDataAdapter("select * from carrito", conn);
                SqlDataAdapter sumar_existencias = new SqlDataAdapter("SELECT SUM(precio_de_venta_unitario) FROM carrito where codigo_cliente = 0", conn);



                DataSet newdataset = new DataSet();
                DataSet newdataset1 = new DataSet();

                agregar_info_carrito.Fill(cliente);
                sumar_existencias.Fill(newdataset);



                dataGridView2.DataSource = cliente.Tables[0];
                dataGridView4.DataSource = newdataset.Tables[0];

                
                string identificador_pedido = DateTime.Now.ToString("mmss" + "2016");
                string fecha_del_pedido = DateTime.Now.ToString("ddMMyyyy");
                string codigo_cliente = this.dataGridView1.Rows[0].Cells[3].Value.ToString();
                string condicion_de_pago = this.dataGridView2.Rows[0].Cells[0].Value.ToString();
                string identificador_personal_asignado = "2502";
                string fecha_estimada_entrega = DateTime.Now.AddDays(7).ToString("ddMMyyyy");
                string cantidad_pedida = "Null";
                string precio_de_venta_unitario = "Null";
                string descuento = "Null";
                string impuesto_de_ventas = "Null";
                string precio_total = this.dataGridView4.Rows[0].Cells[0].Value.ToString();
                string estado_del_pedido = "REGISTRADO";
                string descripcion = "Null";


                SqlCommand insertar_pedido = new SqlCommand("Insert into PEDIDOS values (" + identificador_pedido + ","
                                                                                           + fecha_del_pedido + ","
                                                                                           + codigo_cliente + ","
                                                                                           + "'" + condicion_de_pago + "'" + "," 
                                                                                           + identificador_personal_asignado + ","
                                                                                           + fecha_estimada_entrega + ","
                                                                                           + cantidad_pedida + ","
                                                                                           + precio_de_venta_unitario + ","
                                                                                           + descuento + ","
                                                                                           + impuesto_de_ventas + ","
                                                                                           + precio_total + ","
                                                                                           + "'" + estado_del_pedido + "'" + ","
                                                                                           + descripcion 
                                                                                           + ")", conn);
                conn.Open();


                insertar_pedido.ExecuteNonQuery();
                /*Enviar correo*/
                conn.Close();
            }
        }    
    }
}


        


    
