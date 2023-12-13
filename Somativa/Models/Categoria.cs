using System.ComponentModel;

namespace Somativa.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        [DisplayName("Tipos de Massas")]
        public string Nome { get; set; }
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}
