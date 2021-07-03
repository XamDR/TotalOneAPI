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
                    Content = "El distrito del Rímac se fundó un 2 de febrero de 1920, a orillas del río que lleva su nombre. " +
                                "Por su cercanía al centro de la ciudad, cuenta con una serie de inmuebles que son patrimonio histórico."
                },
                new CuriousFact
                {
                    ID = Guid.NewGuid().ToString(),
                    CityName = "New York",
                    Content = "Nueva York es una de las ciudades más cosmopolitas del mundo: el 36% de sus residentes nació fuera de Estados Unidos" +
                                " y casi el 50% habla otro idioma además del inglés"
                },
                new CuriousFact
                {
                    ID = Guid.NewGuid().ToString(),
                    CityName = "Bilbao",
                    Content = "La simpática y gigante escultura floral de un perro que está en frente del Museo Guggenheim de Bilbao" +
                                " fue creada por el artista Jeff Koons."
                },
            };
        }
    }
}
