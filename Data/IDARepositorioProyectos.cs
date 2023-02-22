using Cv.Models;
using Cv.AccesoDatos;

namespace Cv.Data{
    public interface IDARepositorioProyectos
    {
        List<Proyecto> Obtener();
        //List<Proyecto> ObtenerCurso();
    }
}