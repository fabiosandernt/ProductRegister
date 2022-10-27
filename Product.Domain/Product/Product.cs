using Product.CrossCutting.Entity;


namespace Product.Domain.Product
{
    public class Product: Entity<Guid>
    {
        public string Titulo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCriacao { get; set; } 
        public DateTime DataAtualizacao { get; set; }
    
    }
}
