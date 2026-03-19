using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CollegeSIA.models
{
    [Table("building")]
    public class Building
    {
        [Key]
        [Column("building_id")]
        public int BuildingId { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; } = null!;

        [Column("address")]
        [Required]
        public string Address { get; set; } = null!;

        public List<Classroom> Classrooms { get; set; } = new();
    }
}
