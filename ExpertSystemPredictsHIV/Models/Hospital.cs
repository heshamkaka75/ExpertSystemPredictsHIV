using System.ComponentModel.DataAnnotations;

namespace ExpertSystemPredictsHIV.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
