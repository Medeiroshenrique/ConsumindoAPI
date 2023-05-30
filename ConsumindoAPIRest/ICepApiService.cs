using System.Threading.Tasks;
using Refit;

namespace ConsumindoAPIRest;

public interface ICepApiService
{
    [Get("/ws/{cep}/json/")]
    Task<CepResponse> GetAddressAsync(string cep);
}