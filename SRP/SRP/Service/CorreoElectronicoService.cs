﻿using System;

namespace Proyecto.Services
{
    public class CorreoElectronicoService
    {
        public void EnviarCorreoElectronico(string correoElectronico, string mensaje)
        {
            // Lógica para enviar correo electrónico
            Console.WriteLine($"Enviando correo a {correoElectronico} con el mensaje: {mensaje}");
        }
    }
}
