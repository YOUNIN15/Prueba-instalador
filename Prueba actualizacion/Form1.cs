using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba_actualizacion;

namespace Prueba_actualizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationDeployment deployment = ApplicationDeployment.CurrentDeployment;

            try
            {
                UpdateCheckInfo info = deployment.CheckForDetailedUpdate();

                if (info.UpdateAvailable)
                {
                    DialogResult result = MessageBox.Show("Hay una nueva versión disponible. ¿Deseas actualizar la aplicación?", "Actualización disponible", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        deployment.Update();
                        MessageBox.Show("La aplicación ha sido actualizada correctamente. Por favor, reinicia la aplicación para aplicar los cambios.", "Actualización completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("No hay actualizaciones disponibles en este momento.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DeploymentDownloadException dde)
            {
                MessageBox.Show("No se pudo descargar la actualización. Comprueba tu conexión a internet e intenta de nuevo.\n\nError: " + dde.Message, "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidDeploymentException ide)
            {
                MessageBox.Show("No se pudo buscar actualizaciones. Comprueba que la aplicación esté publicada con ClickOnce.\n\nError: " + ide.Message, "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar actualizaciones.\n\nError: " + ex.Message, "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tmhora_Tick(object sender, EventArgs e)
        {
            lblsegundos.Text = DateTime.Now.ToString("ss");
            //cirpbreloj.Value = Convert.ToInt32(DateTime.Now.ToString("ss"));
            lblhora.Text = DateTime.Now.ToString("hh:mm");
            //label3.Text = DateTime.Now.ToString('dddd');
            lblfecha.Text = DateTime.Now.ToShortDateString();
            //cirpbreloj.Value = int.Parse(lblsegundos.Text);

            double porcentajeCompletado = (double)DateTime.Now.Second / 60 * 100;
            cirpbreloj.Value = (int)porcentajeCompletado;
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            fr
        }
    }
}
