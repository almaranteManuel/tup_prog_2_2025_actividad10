namespace Ejercicio1.Models;

public class CentroDeAtencion
{
    LinkedList<Solicitud> solicitudesPendientes = new LinkedList<Solicitud>();
    public void ImportarCsvSolicitudesEntrantes(FileStream fs)
    {
        StreamReader sr = new StreamReader(fs);

        sr.ReadLine();

        while (!sr.EndOfStream)
        {
            string linea = sr.ReadLine();
            Solicitud solicitud = new Solicitud();
            solicitud.Importar(linea);

            solicitudesPendientes.AddLast(solicitud);
        }
    }

    public LinkedListNode<Solicitud> GetSolicitudPendiente()
    {
        return solicitudesPendientes.First;
    }
}
