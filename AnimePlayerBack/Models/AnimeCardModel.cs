using Postgrest.Attributes;
using Postgrest.Models;


namespace AnimePlayerBack.Models
{   
    /// <summary>
    /// Cards model
    /// </summary>
    [Table("AnimeCards")]
    public class AnimeCardModel : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
       
        [Column("description")]
        public string Description { get; set; }

        [Column("link")]
        public string Link { get; set; }
    }
}
