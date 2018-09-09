namespace Cascardi.Models
{
    public class RelatorioRentabilidade
    {
        public RelatorioRentabilidade()
        {
        }

        public int Id { get; set; }
        public double Investimento { get; set; }
        public double Lucro { get; set; }
        public double Rentabilidade { get; set; }
    }
}