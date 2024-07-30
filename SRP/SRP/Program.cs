using Proyecto.Models;
using Proyecto.Printers;
using Proyecto.Services;
using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona = new Persona("Smith Rodriguez", 18, "123 Las americas", "Smith.Rp@example.com");

            
            CorreoElectronicoService correoService = new CorreoElectronicoService();
            correoService.EnviarCorreoElectronico(persona.CorreoElectronico, "Ey como estan es un mensaje de ejemplo");

            
            PersonaPrinter printer = new PersonaPrinter();
            printer.ImprimirDatos(persona);
        }
    }
}
