using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    public Dictionary<int, Alumno> Alumnos { get; set; }

    public CasoDictionary()
    {
        Alumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        Alumnos.Add(alumno.Legajo, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        foreach (var alumno in Alumnos)
        {
            if (alumno.Key == legajo)
            {
                return alumno.Value;
            }
        }
        return null;
    }

    public Dictionary<int, Alumno> RetornarDiccionario()
    {
        return Alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        Alumnos.Remove(legajo);
    }
}
