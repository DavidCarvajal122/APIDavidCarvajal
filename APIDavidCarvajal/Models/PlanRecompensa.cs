using System.ComponentModel.DataAnnotations.Schema;

namespace APIDavidCarvajal.Models
{
    public class PlanRecompensa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Puntos { get; set; }
        public string TipoPlan
        {
            get
            {
                if (Puntos >= 500)
                {
                    return "GOLD"; 
                }
                else
                {
                    return "SILVER";
                }
            }
        }
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }
    }
}
