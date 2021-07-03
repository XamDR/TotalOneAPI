using TotalOneAPI.Models;

namespace TotalOneAPI.Services
{
    public interface ICuriousFactRepository
    {
        CuriousFact GetCuriousFactForCity(string cityName);
    }
}
