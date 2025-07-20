namespace MinhaAplicacaoMvc.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public decimal Desconto { get; set; }
        public string Vendedor { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
