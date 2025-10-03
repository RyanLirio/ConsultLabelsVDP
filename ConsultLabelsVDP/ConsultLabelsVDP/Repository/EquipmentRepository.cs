using ConsultLabelsVDP.Models;

namespace ConsultLabelsVDP.Repository
{
    public class EquipmentRepository
    {
        private static readonly List<Equipment> _equipments = new List<Equipment>
        {
            new Equipment { Id = 1, Codigo = "EQ001", Nome = "Laptop", Fornecedor = "Dell", DataCompra = new DateTime(2022, 1, 15), Situacao = "Ativo" }
        };

        public async Task AddEquipment(Equipment equipment)
        {

        }

        public async Task<Equipment> GetByCodigo(string Codigo)
        {
            
        }
    }
}
