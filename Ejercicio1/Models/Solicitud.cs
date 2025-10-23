namespace Ejercicio1.Models;

[Serializable]
public class Solicitud : IExportable
{
    public int Numero {  get; set; }
    public string Motivo { get; set; }

    public void Importar(string linea)
    {
        string[] datos = linea.Split(';');
        Numero = Convert.ToInt32(datos[0]);
        Motivo = datos[1];
    }

    public override string ToString()
    {
        return $"{Numero} ({Motivo})";
    }
}
