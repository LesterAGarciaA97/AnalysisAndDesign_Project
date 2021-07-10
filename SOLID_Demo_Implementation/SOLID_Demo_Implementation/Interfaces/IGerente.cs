namespace SOLID_Demo_Implementation.Interfaces
{
    public interface IGerente
    {
        /// <summary>
        /// Método 01
        /// </summary>
        /// <returns>Este método retorna el reporte solicitado</returns>
        public string solicitarReporte()
        {
            return "El reporte del mes de Julio";
        }
    }
}