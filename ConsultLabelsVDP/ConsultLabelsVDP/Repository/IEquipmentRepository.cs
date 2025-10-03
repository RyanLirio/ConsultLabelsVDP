using ConsultLabelsVDP.Models;

namespace ConsultLabelsVDP.Repository
{
    public interface IEquipmentRepository
    {
        public Task AddEquipment(Equipment equipment);
        public Task<Equipment> GetByCodigo (string Codigo);
    }
}
