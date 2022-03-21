using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parcial_1
{
    public partial class Lista_Jugadores : Form
    {
        public Lista_Jugadores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FormPrincipal = new Form1();
            FormPrincipal.Closed += (s, args) => this.Close();
            FormPrincipal.ShowDialog();
        }

        DataTable ListadoJugador = new DataTable();
        private void Lista_Jugadores_Load(object sender, EventArgs e)
        {
            ListadoJugador.Columns.Add("Nombre", typeof(string));
            ListadoJugador.Columns.Add("Goles", typeof(int));
            informacionJugadores.DataSource = ListadoJugador;
            leerArchivo();

            promedioGoles.Text=(from DataGridViewRow Linea in informacionJugadores.Rows where Linea.Cells[1]
                                      .FormattedValue.ToString()!= String.Empty select 
                                      Convert.ToDecimal(Linea.Cells[1].FormattedValue)).Average().ToString();



        }
        private void leerArchivo()
        {
            StreamReader Archivo1 = new StreamReader(@"GolesJugadores.txt");
            string linea;
            while ((linea = Archivo1.ReadLine()) != null)
            {
                DataRow dr = ListadoJugador.NewRow();
                string[] valores = linea.Split('|');
                for (int i = 0; i < 2; i++)
                {
                    dr[i] = valores[i];
                }
                ListadoJugador.Rows.Add(dr);
            }
            Archivo1.Close();
        }

        private void OrdenarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Mayor a Menor")
                {
                    informacionJugadores.Sort(informacionJugadores.Columns[1], ListSortDirection.Descending);
                }
                else
                {
                    if (comboBox1.Text == "Menor a Mayor")
                    {
                        informacionJugadores.Sort(informacionJugadores.Columns[1], ListSortDirection.Ascending);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error! Solo se encuentra un cliente registrado! " + ex); }
        }
    }
}
