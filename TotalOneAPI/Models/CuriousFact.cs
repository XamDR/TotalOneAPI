using System.ComponentModel.DataAnnotations;

namespace TotalOneAPI.Models
{
    public class CuriousFact
    {
        [Required]
        public string ID { get; set; }

        [Required]
        public string CityName { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
