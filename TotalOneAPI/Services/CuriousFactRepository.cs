using System;
using System.Collections.Generic;
using System.Linq;
using TotalOneAPI.Models;

namespace TotalOneAPI.Services
{
    public class CuriousFactRepository : ICuriousFactRepository
    {
        private List<CuriousFact> curiousFacts;

        public CuriousFactRepository() => InitializeData();

        public CuriousFact GetCuriousFactForCity(string cityName)
            => curiousFacts.FirstOrDefault(f => f.CityName == cityName);

        private void InitializeData()
        {
            curiousFacts = new List<CuriousFact>
            {
                new CuriousFact
                {
                    ID = Guid.NewGuid().ToString(),
                    CityName = "Huancayo",
                    Content = "Es la cuarta ciudad más alta del Perú, con una altitud de 3 259 m.s.n.m."
                },
                new CuriousFact
                {
                    ID = Guid.NewGuid().ToString(),
                    CityName = "Rímac",
                    Content = ""
                },
                new CuriousFact
                {
                    ID = Guid.NewGuid().ToString(),
                    CityName = "New York",
                    Content = ""
                },
                new CuriousFact
                {
                    ID = Guid.NewGuid().ToString(),
                    CityName = "Bilbao",
                    Content = ""
                },
            };
        }
    }
}
