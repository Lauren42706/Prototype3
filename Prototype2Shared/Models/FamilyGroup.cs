using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prototype2WebApi.Models
{
    public class FamilyGroup
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FamilyGroupId { get; set; }

        [ForeignKey("FamilyStatus")]
        public int FamilyStatusId { get; set; }
        public FamilyStatus? FamilyStatus { get; set; }

        [ForeignKey("UserInfoData")]
        public int UserId { get; set; }
        public UserInfoData? UserInfoData { get; set; }
    }
}
