using System;
using Cv.Models; 
using Cv.Data;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Cv.AccesoDatos{

public class DAAServicioEmailSendGrid: IDAServicioEmailSendGrid
{
    private readonly IConfiguration configuration;
    

public DAAServicioEmailSendGrid(IConfiguration configuration)
{
    this.configuration=configuration;
    
}

    public async Task Enviar(ContactoModels contacto)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apiKey); 
            var from = new EmailAddress(email,nombre);
            var subject= $"El cliente {contacto.Email} quiere contactarte";
            var to=new EmailAddress(email,nombre);
            var MensajeTextoPlano=contacto.Mensaje;
            var contenidhtml=@$"De: {contacto.Nombre}
            Email: {contacto.Email}
            Mensaje: {contacto.Mensaje}";
            var singleEmail =MailHelper.CreateSingleEmail(from, to, subject, MensajeTextoPlano,contenidhtml);
            var response = await cliente.SendEmailAsync(singleEmail);
            
        }
}
}