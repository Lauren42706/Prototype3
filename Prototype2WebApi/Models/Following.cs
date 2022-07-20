using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class Following
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FollowingId { get; set; }
        public bool Request { get; set; }
        public bool Approval { get; set; }

        [ForeignKey("UserInfoData")]
        public int UserId { get; set; }

    }
}
