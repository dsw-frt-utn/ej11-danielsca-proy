using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    public List<Alumno> Alumnos { get; set; }

    public CasoList()
    {
        Alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        Alumnos.Add(alumno);
    }

    public List<Alumno> RetornarLista()
    {
        return Alumnos;
    }

    public Alumno? BuscarAlumnoPorNombre(string nombre)
    {
        foreach (var alumno in Alumnos)
        {
            if (alumno.Nombre.Equals(nombre))
            {
                return alumno;
            }
        }
        return null;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        Alumnos.Remove(alumno);
    }

    public void EliminarAlumnoPosicion(int posicion)
    {
        Alumnos.RemoveAt(posicion);
    }
}
