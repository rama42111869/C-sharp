namespace SeguridadBasicaASP.Services
{
    public interface IServicioUsuario
    {
        public bool IsUsuario(string email, string contraseña);
    }
}
