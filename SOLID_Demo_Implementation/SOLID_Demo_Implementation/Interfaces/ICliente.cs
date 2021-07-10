using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Demo_Implementation.Interfaces
{
    public interface ICliente
    {
        /// <summary>
        /// Método 01
        /// </summary>
        /// <returns>Este método retorna la aprobación/denegación de los pagos</returns>
        public int pagoServicios()
        {
            return 0;
        }
        /// <summary>
        /// Método 02 - Este método modifica los datos de un usuario existente en el sistema
        /// </summary>
        public void modificarDatos()
        {

        }
        /// <summary>
        /// Método 03 - Este método hace el proceso del caje de puntos 
        /// </summary>
        public void canjearPuntos()
        {
            
        }
    }
}
