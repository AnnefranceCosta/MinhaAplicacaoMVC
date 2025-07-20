namespace MinhaAplicacaoMvc.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public bool Situacao { get; set; }
        public decimal Comissao { get; set; }

        public ICollection<Cliente>? Clientes { get; set; }
    }
}
