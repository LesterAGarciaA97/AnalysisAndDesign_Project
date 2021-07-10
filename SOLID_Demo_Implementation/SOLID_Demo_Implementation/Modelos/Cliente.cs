using SOLID_Demo_Implementation.Interfaces;
using System;

namespace SOLID_Demo_Implementation.Modelos
{
    public class Cliente : ILogin, ICliente
    {
        public void iniciarSesion()
        {
            throw new NotImplementedException();
        }
        public void canjearPuntos()
        {
            throw new NotImplementedException();
        }
        public void modificarDatos()
        {
            throw new NotImplementedException();
        }
        public void pagoServicios()
        {
            throw new NotImplementedException();
        }
    }
}