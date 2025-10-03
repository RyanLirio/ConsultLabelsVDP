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
            //Equipment equip = equipment; //no c# o parâmetro já tem referência direta para o objeto original
            _equipments.Add(equipment);
            await Task.CompletedTask; //como é async precisamos retornar  
        }

        public async Task<Equipment> GetByCodigo(string Codigo)
        {
            
        }
    }
}
