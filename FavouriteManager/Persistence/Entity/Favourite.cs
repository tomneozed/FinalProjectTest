using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace FavouriteManager.Persistence.entity
{

    [Table("Favourite")]
    public class Favourite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public long Id {  get; set; }
        [Column]
        public String Link { get; set; }
        [Column]
        public String Label { get; set; }
        [Column]
        public bool IsValid { get; set; }
        [Column]
        public Category Category { get; set; }

        public long CategoryId {  get; set; }
        [Column]
        public DateTime UpdatedAt { get; set; }


    }
}
