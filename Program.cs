using App_CAMPSYS.View;

namespace App_CAMPSYS;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // TODO: cuando migremos FormPrincipal, este debe ser el punto de entrada real.
        // Por ahora arrancamos directo en FormInscripcion para probar la migración MVP + EF Core.
        Application.Run(new FormPrincipal());
    }
}
