namespace Ejercicio1.Models;

public class CentroDeAtencion
{
    LinkedList<Solicitud> solicitudesPendientes = new LinkedList<Solicitud>();
    Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
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

    public void Atender(Solicitud solicitud)
    {
        if (solicitudesPendientes.Remove(solicitud) == true)
        {
            colaDeAtencion.Enqueue(solicitud);
        }
    }

    public string[] VerDescripcionColaAtencion()
    {
        string[] descripciones = new string[colaDeAtencion.Count];

        int n = 0;

        foreach (Solicitud solicitud in colaDeAtencion)
        {
            descripciones[n++] = solicitud.ToString();
        }
        return descripciones;
    }
}
