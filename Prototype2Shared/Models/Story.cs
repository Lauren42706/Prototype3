using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Story
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoryId { get; set; }
        public string StoryName { get; set; }

        [ForeignKey("Stickers")]
        public int StickerId { get; set; }
    }
}
