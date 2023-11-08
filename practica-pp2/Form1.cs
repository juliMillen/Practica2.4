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
using System.Runtime.Serialization.Formatters.Binary;

namespace practica_pp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Agencia nuevaAgencia = new Agencia();
        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (rBdenuncia.Checked)
            {
                string patente = tBpatente.Text;
                if (nuevaAgencia.BuscarVehiculo(patente) != null)
                {
                    Vehiculo nuevoVehiculo = new Vehiculo(patente);
                    Denuncia nuevaDenuncia = new Denuncia(nuevoVehiculo);
                }
            }
            else
            {
                try
                {
                    int dni = Convert.ToInt32(tBdni.Text);
                    int tipo = Convert.ToInt32(cbxTipo.SelectedItem);
                    NuevoCliente nuevoCliente = new NuevoCliente(dni, tipo);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("Error en el formato del dni" + ex);
                }
               
            }
        }
        FileStream archivo;
        private void Form1_Load(object sender, EventArgs e)
        {
            string nombre = openFileDialog1.FileName;
            try
            {
                   archivo = new FileStream(nombre, FileMode.Open, FileAccess.Read);
                    if (archivo.Length > 0)
                    {
                        BinaryFormatter bF = new BinaryFormatter();
                        nuevaAgencia = (Agencia)bF.Deserialize(archivo);
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en el archivo!" + ex);
            }
            finally
            {
                if (archivo != null)
                {
                    archivo.Close();
                }
            }
        }

        FileStream archivoGuardar;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string nombre = saveFileDialog1.FileName;


            try
            {
                archivoGuardar = new FileStream(nombre, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bF = new BinaryFormatter();
                bF.Serialize(archivoGuardar, nuevaAgencia);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el fichero" + ex);
            }
            finally
            {
                if (archivoGuardar != null)
                {
                    archivoGuardar.Close();
                }
            }
        }
    }
}
