using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente(GetOrdenadosPorTituloDesc)
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{


    //Tomar el primer libro
    public Libro? GetPrimero() => Libro.CrearLista()
                                       .FirstOrDefault();

    //Tomar el ultimo libro
    public Libro? GetUltimo() => Libro.CrearLista()
                                      .LastOrDefault();
    //Obtener la suma de precios
    public decimal GetTotalPrecios() => Libro.CrearLista()
                                             .Sum(libro => libro.Precio);

    // Obtener el promedio de precios
    public decimal GetPromedioPrecios() => Libro.CrearLista()
                                                .Average(libro => libro.Precio);

    // Oetener la lista de libros con Id mayor a 15
    public List<Libro> GetListBy() => Libro.CrearLista()
                                           .Where(librito => librito.Id > 15)
                                           .ToList();

    // Obtener una lista de cada libro con su título y precio en formato moneda
    public List<string> GetLibros() => Libro.CrearLista()   
                                            .Select(librito => $"{librito.Titulo}: {librito.Precio:C}")
                                            .ToList();

    // Obtener el libro con el precio más alto
    public Libro? GetMayorPrecio() => Libro.CrearLista()
                                           .OrderBy(librito => librito.Precio)
                                           .Last();

    // Obtener el libro con el precio más bajo
    public Libro? GetMenorPrecio() => Libro.CrearLista()    
                                           .OrderBy(librito => librito.Precio)  
                                           .First();

    // Obtener los libros cuyo precio sea mayor al promedio
    public List<Libro> GetMayorPromedio()
    {
        var promedio = GetPromedioPrecios();
        return Libro.CrearLista()   
                    .Where(librito => librito.Precio > promedio)
                    .ToList();
    }

    // Obtener los libros ordenados por título de forma descendente
    public List<Libro> GetOrdenadosPorTituloDesc() => Libro.CrearLista()
                                                           .OrderByDescending(librito => librito.Titulo)
                                                           .ToList();

}
