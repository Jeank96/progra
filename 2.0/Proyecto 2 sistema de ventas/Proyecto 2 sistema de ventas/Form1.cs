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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string selectedStatic;
        public static DataSet cliente = new DataSet(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            this.cLIENTESTableAdapter.Fill(this.sistemaVentasDataSet.CLIENTES);
            this.cATALOGO_DE_PRODUCTOSTableAdapter.Fill(this.sistemaVentasDataSet.CATALOGO_DE_PRODUCTOS);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int largoComboBox = this.comboBox1.Items.Count;
                //comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
                {
                    //condicion de pago
                    string selected = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                    selectedStatic = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                    SqlDataAdapter consulta = new SqlDataAdapter("SELECT condicion_de_pago FROM CLIENTES where CLIENTES.nombre =" + " '" + selected + " ' ", conn);
                    SqlDataAdapter consulta2 = new SqlDataAdapter("SELECT codigo_cliente FROM CLIENTES where CLIENTES.nombre =" + " '" + selected + " ' ", conn);
                    SqlDataAdapter consulta3 = new SqlDataAdapter("SELECT condicion_de_pago, codigo_cliente FROM CLIENTES where CLIENTES.nombre =" + " '" + selected + " ' ", conn);

                    conn.Open();


                    DataSet newdataset = new DataSet();
                    DataSet newdataset2 = new DataSet();
                    

                    consulta.Fill(newdataset);
                    consulta2.Fill(newdataset2);



                    consulta.Fill(cliente);

                    dataGridView1.DataSource = newdataset.Tables[0];
                    dataGridView2.DataSource = newdataset2.Tables[0];
                }
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                //condicion de pago
                string selected = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                MessageBox.Show(selected);
                SqlDataAdapter consulta = new SqlDataAdapter("SELECT SKU, precio_de_venta_unitario, existencias_en_inventario FROM CATALOGO_DE_PRODUCTOS where CATALOGO_DE_PRODUCTOS.descripción_del_producto =" + " '" + selected + " ' ", conn);
                
                conn.Open();


                DataSet newdataset = new DataSet();



                consulta.Fill(newdataset);


                dataGridView3.DataSource = newdataset.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                

                string SKU = this.dataGridView3.Rows[0].Cells[0].Value.ToString();
                string precio_de_venta_unitario = this.dataGridView3.Rows[0].Cells[1].Value.ToString();
                int existencias_en_inventario = Int32.Parse( this.dataGridView3.Rows[0].Cells[2].Value.ToString() );


                int existencias_solicitadas = Int32.Parse(this.textBox1.Text);
                int nueva_existencia = (existencias_en_inventario - existencias_solicitadas);
                string codigo_cliente = this.dataGridView2.Rows[0].Cells[0].Value.ToString();

                if (existencias_en_inventario == 0)
                {
                    SqlCommand borrar_producto = new SqlCommand("Delete from CATALOGO_DE_PRODUCTOS where SKU = " + SKU, conn);
                    conn.Open();
                    borrar_producto.ExecuteNonQuery();
                    conn.Close();
                }


                
                
                //MessageBox.Show(nueva_existencia.ToString());

                SqlCommand agregar_al_carrito = new SqlCommand("Insert into carrito values (" + SKU + "," + precio_de_venta_unitario + "," + existencias_solicitadas + "," + codigo_cliente + ")", conn);
                SqlCommand actualizacion_existencias = new SqlCommand("Update CATALOGO_DE_PRODUCTOS SET existencias_en_inventario = " + (existencias_en_inventario - existencias_solicitadas) + "WHERE SKU =" + SKU, conn);
                conn.Open();
                agregar_al_carrito.ExecuteNonQuery();
                actualizacion_existencias.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                //condicion de pago
                string selected = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
                MessageBox.Show(selected);
                SqlDataAdapter consulta_pedido = new SqlDataAdapter("SELECT fecha_del_pedido, identificador_pedido, estado_del_pedido FROM PEDIDOS", conn);

                conn.Open();


                DataSet newdataset = new DataSet();



                consulta_pedido.Fill(newdataset);


                dataGridView4.DataSource = newdataset.Tables[0];
                conn.Close();
            }

        }
       
        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                string codigo_cliente = this.dataGridView2.Rows[0].Cells[0].Value.ToString();
                SqlDataAdapter ver_carrito = new SqlDataAdapter("select * from carrito WHERE codigo_cliente = " + codigo_cliente, conn);
                conn.Open();
                DataSet newdataset = new DataSet();



                ver_carrito.Fill(newdataset);


                frm.dataGridView1.DataSource = newdataset.Tables[0];
                frm.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

  
        }
    }

