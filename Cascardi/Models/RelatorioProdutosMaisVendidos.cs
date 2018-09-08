namespace Cascardi.Models
{
    public class RelatorioProdutosMaisVendidos
    {
        public RelatorioProdutosMaisVendidos()
        {
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string CodigoDeBarras { get; set; }
        public double ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }
    }
}