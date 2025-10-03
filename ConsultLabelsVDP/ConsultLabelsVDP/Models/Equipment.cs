using System.ComponentModel.DataAnnotations;

namespace ConsultLabelsVDP.Models
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; } 
        public string Codigo { get; set; }
        public string Nome { get; set; }    
        public string Fornecedor { get; set; }
        public DateTime DataCompra { get; set; }
        public string Situacao { get; set; }
    }
}
