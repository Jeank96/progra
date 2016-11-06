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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.cLIENTESTableAdapter.Fill(this.sistemaVentasDataSet.CLIENTES);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                //condicion de pago
                string codigo_cliente = this.textBox1.Text;
                string nombre = this.textBox2.Text;
                string pais = this.textBox3.Text;
                string direccion_fisica = this.textBox4.Text;
                string codigo_postal = this.textBox5.Text;
                string telefono = this.textBox6.Text;
                string limite_de_credito = this.textBox7.Text;
                string direccion_fisica_entrega = this.textBox8.Text;
                string correo_electronico = this.textBox9.Text;
                string fecha_de_inicio_relacion = this.textBox10.Text;
                string condicion_de_pago = this.textBox11.Text;

                SqlCommand insercion_clientes = new SqlCommand("Insert into CLIENTES values (" + " ' " + codigo_cliente + " ' " + "," 
                                                                                               + " ' " + nombre + " ' " + ","
                                                                                               + " ' " + pais + " ' " + ","
                                                                                               + " ' " + direccion_fisica + " ' " + ","
                                                                                               + codigo_postal + "," 
                                                                                               + telefono + "," 
                                                                                               + limite_de_credito + ","
                                                                                               + " ' " + direccion_fisica_entrega + " ' " + "," 
                                                                                               + " ' " + correo_electronico + " ' "  + "," 
                                                                                               + " ' " + fecha_de_inicio_relacion + " ' " + ","
                                                                                               + " ' " + condicion_de_pago + " ' " 
                                                                                               + ")", conn);
                
                
                conn.Open();
                insercion_clientes.ExecuteNonQuery();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaVentasDataSet.CLIENTES1' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.sistemaVentasDataSet.CLIENTES);

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIMFG3S; Initial Catalog = SistemaVentas; Integrated Security = True;"))
            {
                string codigo_cliente = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                SqlCommand borrar_cliente = new SqlCommand("Delete from CLIENTES where codigo_cliente = " + codigo_cliente, conn);
                conn.Open();
                borrar_cliente.ExecuteNonQuery();
                conn.Close();
            }
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}

