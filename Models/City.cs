using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace provCityCode1st.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        public string ProvinceCode { get; set; }
        [ForeignKey("ProvinceCode")]
        [JsonIgnore]
        public Provinces Province { get; set; }
    }
}