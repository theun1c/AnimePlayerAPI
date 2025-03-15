using Postgrest.Attributes;
using Postgrest.Models;


namespace AnimePlayerBack.Models
{
    [Table("Anime")]
    public class AnimeModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
       
        [Column("episodes")]
        public int Episodes { get; set; }

        [Column("seasons")]
        public int Seasons { get; set; }
    }
}
