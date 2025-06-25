// 📁 GymSystemClean.Application/Interfaces/IClientRepository.cs

using GymSystemClean.Domain.Entities;

namespace GymSystemClean.Application.Interfaces;

public interface IClientRepository
{
    Task<int> AddClientAsync(Client client);
    Task<Client?> GetByIdAsync(int id);
    Task<IEnumerable<Client>> GetAllAsync();
    Task UpdateClientAsync(Client client);
    Task DeleteClientAsync(int id);
}