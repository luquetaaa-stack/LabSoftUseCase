using AppTask.Models.interfaces;

namespace AppTask.Models.Services
{
    public class RegraTarefa : IRegraTarefa
    {
        public bool ValidarDataFinal(DateTime? DataIniciada, DateTime? DataFinalizada)
        {
            return DataIniciada>=DataFinalizada;
        }
    }
}
