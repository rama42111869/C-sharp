using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using SeguridadBasicaASP.Services;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace SeguridadBasicaASP.Security
{
    public class BasicAuthHandler:AuthenticationHandler<AuthenticationSchemeOptions>
    {

        private readonly IServicioUsuario _servicioUsuario;

        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IServicioUsuario servicioUsuario
            ): base(options,logger,encoder,clock)
        {
            _servicioUsuario = servicioUsuario;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("No viene el header");

            bool result = false;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
                var email = credentials[0];
                var contraseña = credentials[1];
                result = _servicioUsuario.IsUsuario(email, contraseña);
            }
            catch
            {
                return AuthenticateResult.Fail("Surgio un inconveniente");
            }

            if(!result)
                return AuthenticateResult.Fail("Usuario o Contraseña invalida");

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, "id"),
                new Claim(ClaimTypes.Name,"usuario"),

            };

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal= new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);
            return AuthenticateResult.Success(ticket);
        }
    }
}
