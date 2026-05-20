using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        Console.WriteLine("Agregar 3 alumnos a la lista");
        CasoList lista = new CasoList();

        var A1 = new Alumno(1, "Daniel", 8, 60554);
        var A2 = new Alumno(2, "Mauro", 8, 60698);
        var A3 = new Alumno(3, "Paulina", 8, 60556);

        lista.AgregarAlumno(A1);
        lista.AgregarAlumno(A2);
        lista.AgregarAlumno(A3);

        Console.WriteLine("Listar por consola los alumnos");
        foreach (var item in lista.RetornarLista())
        { 
            Console.WriteLine(item);
        }

        Console.WriteLine("Buscar por nombre un alumno que exista y mostrar por consola");
        var alumnoBuscadoExistente = lista.BuscarAlumnoPorNombre("Daniel");
        Console.WriteLine(alumnoBuscadoExistente);

        Console.WriteLine("Buscar por nombre un alumno que no exista y mostrar por consola el texto \"No existe\"");
        var alumnoBuscadoInexistente = lista.BuscarAlumnoPorNombre("Baltazar");
        if (alumnoBuscadoInexistente == null)
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("Eliminar un alumno y listar por consola los alumnos");
        lista.EliminarAlumno(A3);
        foreach (var item in lista.RetornarLista())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Eliminar el primer elemento de la lista y listar por consola los alumnos");
        lista.EliminarAlumnoPosicion(0);
        foreach (var item in lista.RetornarLista())
        {
            Console.WriteLine(item);
        }
    }

    
    public static void EjemploDictionary()
    {
        Console.WriteLine("Agregar 3 alumnos al diccionario");
        CasoDictionary diccionario = new CasoDictionary();
        diccionario.AgregarAlumno(new Alumno(1, "Daniel", 8, 60554)); 
        diccionario.AgregarAlumno(new Alumno(2, "Mauro", 8, 60698));
        diccionario.AgregarAlumno(new Alumno(3, "Paulina", 8, 60556));

        Console.WriteLine("Listar por consola los alumnos");
        foreach (var alumno in diccionario.RetornarDiccionario())
        {
            Console.WriteLine(alumno.Value);
        }

        Console.WriteLine("Buscar un alumno por clave y mostrar por consola");
        var alumnoBuscadoExistente = diccionario.BuscarAlumno(60554);
        Console.WriteLine(alumnoBuscadoExistente);

        Console.WriteLine("Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto \"No existe\"");
        var alumnoBuscadoInexistente = diccionario.BuscarAlumno(60000);
        if (alumnoBuscadoInexistente == null)
        {
            Console.WriteLine("No existe");
        }

        //Ambos metodos simplificados debido a que se daran si o si esas opciones.

        /* En todo caso seria algo asi:
         
         if(AlumnoBuscado)
         {
           Console.WriteLine(AlumnoBuscado);
         }
         else
         {
           Console.WriteLine("No existe");
         }

        */

        Console.WriteLine("Eliminar un alumno por clave y listar por consola los alumnos");
        diccionario.EliminarAlumno(60556);

        foreach (var alumno in diccionario.RetornarDiccionario())
        {
            Console.WriteLine(alumno.Value);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostrar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
