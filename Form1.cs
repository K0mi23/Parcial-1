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
    public partial class Form1 : Form
    {
        List<DatosJugador> datosJugador = new List<DatosJugador>();
        List<datosGolesJugador> datosGolesJugador = new List<datosGolesJugador>();
        public Form1()
        {
            InitializeComponent(); AgregarInformacionCombobox();
        }

        private void limpiarTexto()
        {
            nombreJugador.Text = ""; numeroJugador.Text = ""; equipoJugador.SelectedIndex = -1; ; equipoContrario.SelectedIndex = -1; ; golesAnotados.Value = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(equipoContrario.Text == equipoJugador.Text)
            {
                MessageBox.Show("ERROR! Porfavor ingresar el equipo contrario correcto");

            }
            else
            {
                if (nombreJugador.Text == "" && numeroJugador.Text == "" && equipoJugador.Text == "" && equipoContrario.Text == "")
                {
                    MessageBox.Show("Porfavor completar la información!");

                }
                else
                {   
                    DatosJugador InformacionJugador = new DatosJugador();
                    datosGolesJugador InformacionGoles = new datosGolesJugador();
                    InformacionGoles.nombreJugador = nombreJugador.Text;
                    InformacionGoles.golesAnotados = Int16.Parse(golesAnotados.Text);
                    InformacionJugador.nombreJugador = nombreJugador.Text;
                    InformacionJugador.numJugador = numeroJugador.Text;
                    InformacionJugador.equipoJugador = equipoJugador.Text;
                    datosJugador.Add(InformacionJugador);
                    GuardarenArchivo(); GuardarenArchivo2(); GuardarenArchivo3(); limpiarTexto();
                }
            }
        }

        public void AgregarInformacionCombobox()
        {
            string[] lineaArchivo = File.ReadAllLines(@"Equipos.txt");
            foreach (var linea in lineaArchivo)
            {
                var Equipos = linea.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)[0];
                equipoJugador.Items.Add(Equipos);
                equipoContrario.Items.Add(Equipos);

            }
        }
        private void GuardarenArchivo()
        {
            using (FileStream fs = File.Open(@"InformacionJugadores.txt", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(String.Format(this.nombreJugador.Text + "|"));
                sw.Write(String.Format(this.numeroJugador.Text.ToString() + "|"));
                sw.Write(String.Format(this.equipoJugador.Text + "|"));
                sw.WriteLine("");
            }
        }


        private void GuardarenArchivo2()
        {
            using (FileStream fs = File.Open(@"InformacionPartido.txt", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(String.Format(this.numeroJugador.Text.ToString() + "|"));
                sw.Write(String.Format(this.fechaJuego.Value.ToString() + "|"));
                sw.Write(String.Format(this.equipoContrario.Text + "|"));
                sw.Write(String.Format(this.golesAnotados.Value.ToString() + "|"));
                sw.WriteLine("");
            }
        }

        private void GuardarenArchivo3()
        {
            using (FileStream fs = File.Open(@"GolesJugadores.txt", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(String.Format(this.nombreJugador.Text + "|"));
                sw.Write(String.Format(this.golesAnotados.Value.ToString() + "|"));
                sw.WriteLine("");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarEquipos FormEquipos = new AgregarEquipos();
            FormEquipos.Closed += (s, args) => this.Close();
            FormEquipos.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ListarJugadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lista_Jugadores FormLista = new Lista_Jugadores();
            FormLista.Closed += (s, args) => this.Close();
            FormLista.ShowDialog();
        }
    }
}
