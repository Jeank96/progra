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
using System.Net;
using System.Net.Mail;

namespace Proyecto_2_sistema_de_ventas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public class Correo
        {
            MailMessage correos = new MailMessage();
            SmtpClient envios = new SmtpClient();

            public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario)
            {
                try
                {
                    correos.To.Clear();
                    correos.Body = "";
                    correos.Subject = "";
                    correos.Body = mensaje;
                    correos.Subject = asunto;
                    correos.IsBodyHtml = true;
                    correos.To.Add(destinatario.Trim());
                    /*
                    if (ruta.Equals("") == false)
                    {
                        System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                        correos.Attachments.Add(archivo);
                    }
                    */
                    correos.From = new MailAddress(emisor);
                    envios.Credentials = new NetworkCredential(emisor, password);

                    //Datos importantes no modificables para tener acceso a las cuentas

                    envios.Host = "smtp.gmail.com";
                    envios.Port = 587;
                    envios.EnableSsl = true;

                    envios.Send(correos);
                    MessageBox.Show("El mensaje fue enviado correctamente " + destinatario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    Correo clase_correo = new Correo();
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
                    string fecha_del_pedido = DateTime.Now.ToString("dd-MM-yyyy");
                    string codigo_cliente = this.dataGridView1.Rows[0].Cells[3].Value.ToString();
                    string condicion_de_pago = this.dataGridView2.Rows[0].Cells[0].Value.ToString();
                    string identificador_personal_asignado = "2502-EJECUTIVO DE VENTAS";
                    string fecha_estimada_entrega = DateTime.Now.AddDays(7).ToString("dd-MM-yyyy");
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
                    clase_correo.enviarCorreo("sistemaventas123@gmail.com", "bases123", "Identificador de pedido: " + identificador_pedido + "\n" +
                                                                                        "Fecha del pedido: " + fecha_del_pedido + "\n" +
                                                                                        "Codigo del cliente: " + codigo_cliente + "\n" +
                                                                                        "Condicion de pago: " + condicion_de_pago + "\n" +
                                                                                        "Identificador personal asignado: " + identificador_personal_asignado + "\n" +
                                                                                        "Fechas de entrega estimada: " + fecha_estimada_entrega + "\n" +
                                                                                        "Cantidad pedida: " + cantidad_pedida + "\n" +
                                                                                        "Precio de venta por unidad: " + precio_de_venta_unitario + "\n" +
                                                                                        "Descuento aplicado: " + descuento + "\n\r" +
                                                                                        "Impuesto de ventas aplicado: " + impuesto_de_ventas + "\n" +
                                                                                        "Precio total: " + precio_total + "\n" +
                                                                                        "Estado del pedido: " + estado_del_pedido + "\n" +
                                                                                        "Descripcion de los articulos: " + descripcion, "Pedido Registrado", "megavalmo@gmail.com");
                    conn.Close();
                }
            }    
        }
    }


        


    
