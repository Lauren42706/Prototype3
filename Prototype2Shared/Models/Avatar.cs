using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Avatar
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AvatarId { get; set; }

        [ForeignKey("UserInfoData")]
        public int UserId { get; set; }
    }
}
