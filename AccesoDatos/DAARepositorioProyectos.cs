using System;
using Cv.Models; 
using Cv.Data;

namespace Cv.AccesoDatos;

public class DAARepositorioProyectos: IDARepositorioProyectos
{
    public List<Proyecto> Obtener()
    {
      
      List<Proyecto> lts = new List<Proyecto>() { 
                new Proyecto(){Titulo="Empresa Redondo",Descripcion="Creación del modulo Abastecimiento de combustible, dividido en tres nodos proyección, abastecimiento y listado para el Sistema web",Link="https://www.youtube.com/watch?v=UfT-st9dl8Q",ImgrUrl="/Img/redondo.png"},
                new Proyecto(){Titulo="Empresa Covito",Descripcion="Creación de un Fang Page",Link="https://www.youtube.com/watch?v=UfT-st9dl8Q",ImgrUrl="/Img/foto02.png"},
                new Proyecto(){Titulo="Empresa Palta Rumi",Descripcion="Creación del modulo balanza, chancado, muestreo, laboratorio, gerencia y fiscalización para el Sistema web",Link="https://www.youtube.com/watch?v=UfT-st9dl8Q",ImgrUrl="/Img/palta.jpeg"}
            };
      return lts;
 
    }

   // public List<Proyecto> ObtenerCurso()
    //{ 
      //List<Proyecto> lts = new List<Proyecto>() 
      //{
       // new Proyecto(){Titulo="Diseño de pagina web",Descripcion="Nivel intermedio",Link="s",ImgrUrl="/Imagenes/curso03.png"},
        //new Proyecto(){Titulo="Diseño de pagina web",Descripcion="Nivel Basico",Link="s",ImgrUrl="/Imagenes/curso02.png"},
        //new Proyecto(){Titulo="Base de Datos",Descripcion="Nivel Basico",Link="s",ImgrUrl="/Imagenes/curso02.png"},
        //new Proyecto(){Titulo="Especialista excel",Descripcion="Nivel Basico, intermedio y avanzado",Link="s",ImgrUrl="/Imagenes/curso05.png"},
        //new Proyecto(){Titulo="Reparación de computadoras",Descripcion="Nivel intermedio",Link="s",ImgrUrl="/Imagenes/curso04.png"}
      //      };
     // return lts;   
    //}

}