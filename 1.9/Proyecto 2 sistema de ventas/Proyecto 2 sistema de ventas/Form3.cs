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
using iTextSharp.text;  
using iTextSharp.text.pdf;
using System.IO;

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

            public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
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
                    
                    if (ruta.Equals("") == false)
                    {
                        System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                        correos.Attachments.Add(archivo);
                    }
                    
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

        public class PDF
        {
            public void generarDocumentoPdf(string identificador_pedido_par, string fecha_del_pedido_par, string codigo_cliente_par, string condicion_de_pago_par, string fecha_estimada_entrega_par, string cantidad_pedida_par, string precio_de_venta_unitario_par, string descuento_par, string impuesto_de_ventas_par, string precio_total_par, string estado_del_pedido_par, string descripcion_par)
            {
                try
                {
                // Creamos el documento con el tamaño de página tradicional
                Document doc = new Document(PageSize.LETTER);
                // Indicamos donde vamos a guardar el documento

                if (estado_del_pedido_par == "REGISTRADO")
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\\Users\\Allan\\Documents\\universidad\\registradas\\" + "Numero de pedido" + identificador_pedido_par + ".pdf", FileMode.Create));
                    // Le colocamos el título y el autor
                    // **Nota: Esto no será visible en el documento
                    doc.AddTitle("Facturas");
                    doc.AddCreator("Allan");
                    writer.Close();
                }

                if (estado_del_pedido_par == "CONFIRMADO")
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"C:\\Users\\Allan\\Documents\\universidad\\confirmadas\\" + "Numero de pedido" + identificador_pedido_par + ".pdf", FileMode.Create));
                    // Le colocamos el título y el autor
                    // **Nota: Esto no será visible en el documento
                    doc.AddTitle("Facturas");
                    doc.AddCreator("Allan");
                    writer.Close();
                }
                // Abrimos el archivo
                doc.Open();
                //-------------------------------------------------------------------//
                
                // Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Escribimos el encabezamiento en el documento
                doc.Add(new Paragraph("Factura"));
                doc.Add(Chunk.NEWLINE);

                // Creamos una tabla que contendrá el nombre, apellido y país
                // de nuestros visitante.
                PdfPTable tblFactura = new PdfPTable(12);
                tblFactura.WidthPercentage = 100;

                
                // Configuramos el título de las columnas de la tabla
                
                PdfPCell cl_identificador_pedido = new PdfPCell(new Phrase("Identificador pedido", _standardFont));
                cl_identificador_pedido.BorderWidth = 0;
                cl_identificador_pedido.BorderWidthBottom = 0.75f;

                PdfPCell cl_fecha_del_pedido = new PdfPCell(new Phrase("Fecha del pedido", _standardFont));
                cl_fecha_del_pedido.BorderWidth = 0;
                cl_fecha_del_pedido.BorderWidthBottom = 0.75f;

                PdfPCell cl_codigo_cliente = new PdfPCell(new Phrase("Codigo del cliente", _standardFont));
                cl_codigo_cliente.BorderWidth = 0;
                cl_codigo_cliente.BorderWidthBottom = 0.75f;

                PdfPCell cl_condicion_de_pago = new PdfPCell(new Phrase("Condicion de pago", _standardFont));
                cl_condicion_de_pago.BorderWidth = 0;
                cl_condicion_de_pago.BorderWidthBottom = 0.75f;

                PdfPCell cl_fecha_estimada_entrega = new PdfPCell(new Phrase("Fecha de entrega estimada", _standardFont));
                cl_fecha_estimada_entrega.BorderWidth = 0;
                cl_fecha_estimada_entrega.BorderWidthBottom = 0.75f;

                PdfPCell cl_cantidad_pedida = new PdfPCell(new Phrase("cantidad pedida", _standardFont));
                cl_cantidad_pedida.BorderWidth = 0;
                cl_cantidad_pedida.BorderWidthBottom = 0.75f;

                PdfPCell cl_precio_de_venta_unitario = new PdfPCell(new Phrase("Precio de venta unitario", _standardFont));
                cl_precio_de_venta_unitario.BorderWidth = 0;
                cl_precio_de_venta_unitario.BorderWidthBottom = 0.75f;

                PdfPCell cl_descuento = new PdfPCell(new Phrase("Descuento", _standardFont));
                cl_descuento.BorderWidth = 0;
                cl_descuento.BorderWidthBottom = 0.75f;

                PdfPCell cl_impuesto_de_ventas = new PdfPCell(new Phrase("Impuesto de ventas", _standardFont));
                cl_impuesto_de_ventas.BorderWidth = 0;
                cl_impuesto_de_ventas.BorderWidthBottom = 0.75f;

                PdfPCell cl_precio_total = new PdfPCell(new Phrase("Precio total", _standardFont));
                cl_precio_total.BorderWidth = 0;
                cl_precio_total.BorderWidthBottom = 0.75f;

                PdfPCell cl_estado_del_pedido = new PdfPCell(new Phrase("Estado del pedido", _standardFont));
                cl_estado_del_pedido.BorderWidth = 0;
                cl_estado_del_pedido.BorderWidthBottom = 0.75f;

                PdfPCell cl_descripcion = new PdfPCell(new Phrase("Descripcion", _standardFont));
                cl_descripcion.BorderWidth = 0;
                cl_descripcion.BorderWidthBottom = 0.75f;










                // Añadimos las celdas a la tabla
                tblFactura.AddCell(cl_identificador_pedido);
                tblFactura.AddCell(cl_fecha_del_pedido);
                tblFactura.AddCell(cl_codigo_cliente);
                tblFactura.AddCell(cl_condicion_de_pago);
                tblFactura.AddCell(cl_fecha_estimada_entrega);
                tblFactura.AddCell(cl_cantidad_pedida);
                tblFactura.AddCell(cl_precio_de_venta_unitario);
                tblFactura.AddCell(cl_descuento);
                tblFactura.AddCell(cl_impuesto_de_ventas);
                tblFactura.AddCell(cl_precio_total);
                tblFactura.AddCell(cl_estado_del_pedido);
                tblFactura.AddCell(cl_descripcion);










                // Llenamos la tabla con información
                cl_identificador_pedido = new PdfPCell(new Phrase(identificador_pedido_par, _standardFont));
                cl_identificador_pedido.BorderWidth = 0;

                cl_fecha_del_pedido = new PdfPCell(new Phrase(fecha_del_pedido_par, _standardFont));
                cl_fecha_del_pedido.BorderWidth = 0;

                cl_codigo_cliente = new PdfPCell(new Phrase(codigo_cliente_par, _standardFont));
                cl_codigo_cliente.BorderWidth = 0;

                cl_condicion_de_pago = new PdfPCell(new Phrase(condicion_de_pago_par, _standardFont));
                cl_condicion_de_pago.BorderWidth = 0;

                cl_fecha_estimada_entrega = new PdfPCell(new Phrase(fecha_estimada_entrega_par, _standardFont));
                cl_fecha_estimada_entrega.BorderWidth = 0;

                cl_cantidad_pedida = new PdfPCell(new Phrase(cantidad_pedida_par, _standardFont));
                cl_cantidad_pedida.BorderWidth = 0;

                cl_precio_de_venta_unitario = new PdfPCell(new Phrase(precio_de_venta_unitario_par, _standardFont));
                cl_precio_de_venta_unitario.BorderWidth = 0;

                cl_descuento = new PdfPCell(new Phrase(descuento_par, _standardFont));
                cl_descuento.BorderWidth = 0;

                cl_impuesto_de_ventas = new PdfPCell(new Phrase(impuesto_de_ventas_par, _standardFont));
                cl_impuesto_de_ventas.BorderWidth = 0;

                cl_precio_total = new PdfPCell(new Phrase(precio_total_par, _standardFont));
                cl_precio_total.BorderWidth = 0;

                cl_estado_del_pedido = new PdfPCell(new Phrase(estado_del_pedido_par, _standardFont));
                cl_estado_del_pedido.BorderWidth = 0;

                cl_descripcion = new PdfPCell(new Phrase(descripcion_par, _standardFont));
                cl_descripcion.BorderWidth = 0;


                // Añadimos las celdas a la tabla
                tblFactura.AddCell(cl_identificador_pedido);
                tblFactura.AddCell(cl_fecha_del_pedido);
                tblFactura.AddCell(cl_codigo_cliente);
                tblFactura.AddCell(cl_condicion_de_pago);
                tblFactura.AddCell(cl_fecha_estimada_entrega);
                tblFactura.AddCell(cl_cantidad_pedida);
                tblFactura.AddCell(cl_precio_de_venta_unitario);
                tblFactura.AddCell(cl_descuento);
                tblFactura.AddCell(cl_impuesto_de_ventas);
                tblFactura.AddCell(cl_precio_total);
                tblFactura.AddCell(cl_estado_del_pedido);
                tblFactura.AddCell(cl_descripcion);


                doc.Add(new Paragraph("(+)Total impuesto: " + cl_impuesto_de_ventas));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("(-)Total descuento: " + cl_descuento));
                doc.Add(Chunk.NEWLINE);
                doc.Add(new Paragraph("Total a pagar: " + cl_precio_total));
                doc.Add(Chunk.NEWLINE);

                    //-------------------------------------------------------------------//
                    doc.Add(tblFactura);

                doc.Close();
                MessageBox.Show("El documento fue guardado correctamente ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "El documento no se guardo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                PDF clase_pdf = new PDF();
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
                string identificador_personal_asignado = "2502";
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

                clase_pdf.generarDocumentoPdf(identificador_pedido, fecha_del_pedido, codigo_cliente, condicion_de_pago, identificador_personal_asignado, fecha_estimada_entrega, cantidad_pedida, precio_de_venta_unitario, descuento, impuesto_de_ventas, estado_del_pedido, descripcion);

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
                                                                                    "Descripcion de los articulos: " + descripcion, "Pedido Registrado", "megavalmo@gmail.com", @"C:\\Users\\Allan\\Documents\\universidad\\registradas\\" + "Numero de pedido" + identificador_pedido + ".pdf");
                

                SqlCommand limpiar_carrito = new SqlCommand("Delete from carrito where codigo_cliente = " + codigo_cliente, conn);

                limpiar_carrito.ExecuteNonQuery();
                    
                }
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Clear();
                }
            }
        }    
    }



        


    
