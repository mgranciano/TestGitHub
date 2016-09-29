using Nancy;

namespace ServicioLogin.NancyModules
{
    public class LoginModule : NancyModule
    {
        public LoginModule()
        {
            Get["/"] = parameters => "Hello World";
        }
    }
}
