using Cv.Models;
using Cv.AccesoDatos;

namespace Cv.Data{
    
    public interface IDAServicioEmailSendGrid
    {
        Task Enviar(ContactoModels contacto);
    }
}