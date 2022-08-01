using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class PostedStory
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostedStoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Privacy { get; set; }
        public string SaveId { get; set; }
    }
}
