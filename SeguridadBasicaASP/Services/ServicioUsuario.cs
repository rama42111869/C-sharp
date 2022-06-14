using SeguridadBasicaASP.Models;

namespace SeguridadBasicaASP.Services
{
    public class ServicioUsuario: IServicioUsuario
    {
        List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario(){Email="pato@hotmail.com",Contraseña="123456"},
            new Usuario(){Email="pato2@hotmail.com",Contraseña="123456"}
        };


        public bool IsUsuario(string email, string contraseña) =>
            usuarios.Where(d => d.Email == email && d.Contraseña == contraseña).Count() > 0;
    }
}
