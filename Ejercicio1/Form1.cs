using Ejercicio1.Models;

namespace Ejercicio1;

public partial class FormPrincipal : Form
{
    CentroDeAtencion centro = new CentroDeAtencion();
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnImpSol_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                centro.ImportarCsvSolicitudesEntrantes(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();

                }
            }
            VerSolicitudesPendientes();
        }
    }

    protected void VerSolicitudesPendientes()
    {
        lsbVerSolicitudesImportadas.Items.Clear();
        LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();

        while (nodo != null)
        {
            lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
            nodo = nodo.Next;
        }
    }

    protected void VerSolicitudesAAtender()
    {
        lsbColaSolicitudesAAtender.Items.Clear();

        lsbColaSolicitudesAAtender.Items.AddRange(centro.VerDescripcionColaAtencion());
    }

    private void btnConfirmarSeleccion_Click(object sender, EventArgs e)
    {
        Solicitud item = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;

        if (item != null)
        {
            centro.Atender(item);

            VerSolicitudesPendientes();
            VerSolicitudesAAtender();

            lsbVerSolicitudesImportadas.SelectedItem = null;
            btnSeleccion.Text = "Seleccione un registro";

        }
    }

    private void lsbVerSolicitudesImportadas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void lsbVerSolicitudesImportadas_SelectedValueChanged(object sender, EventArgs e)
    {
        Solicitud item = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;

        if (item != null)
        {
            btnSeleccion.Text = item.ToString();
        }
    }
}