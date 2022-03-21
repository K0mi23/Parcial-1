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
    public partial class AgregarEquipos : Form
    {
        public AgregarEquipos()
        {
            InitializeComponent(); verificarLineasRepetidas();
        }
        private void verificarLineasRepetidas()
        {
            string[] lines = File.ReadAllLines(@"Equipos.txt");
            File.WriteAllLines(@"Equipos.txt", lines.Distinct().ToArray());

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FormPrincipal = new Form1();
            FormPrincipal.Closed += (s, args) => this.Close();
            FormPrincipal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Equipo = nombreEquipo.Text;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(Equipo))
                    {
                        MessageBox.Show("Este equipo ya fue ingresado!");
                    }
                }
                GuardarenArchivo(); verificarLineasRepetidas();  visualizar(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void visualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = tablaEquipos;
            dataGridView1.Refresh();

        }
        private void GuardarenArchivo()
        {
            using (FileStream fs = File.Open(@"Equipos.txt", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {

                sw.Write(String.Format(this.nombreEquipo.Text + "|"));
                sw.WriteLine("");
            }
        }
        DataTable tablaEquipos = new DataTable();
        private void AgregarEquipos_Load(object sender, EventArgs e)
        {
            tablaEquipos.Columns.Add("Equipo",typeof(string));
            dataGridView1.DataSource = tablaEquipos;
             verificarLineasRepetidas(); leerArchivo();
        }

        private void leerArchivo()
        {
            StreamReader Archivo1 = new StreamReader(@"Equipos.txt");
            string linea;
            while ((linea = Archivo1.ReadLine()) != null)
            {
                DataRow dr = tablaEquipos.NewRow();
                string[] valores = linea.Split('|');
                for (int i = 0; i <= 0; i++)
                {
                    dr[i] = valores[i];
                }
                tablaEquipos.Rows.Add(dr);
            }
            Archivo1.Close();

        }

    }
}
