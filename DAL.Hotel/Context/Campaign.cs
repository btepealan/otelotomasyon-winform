using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Hotel.Context
{
    [Table("Campaigns")]

    public class Campaign
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int PersonnelId { get; set; }
        [Required]
        public DateTime CampaignStart { get; set; }
        [Required]
        public DateTime CampaignFinish { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public int DiscountRate { get; set; }
        [Required]
        public int RoomType { get; set; }

        [ForeignKey("PersonnelId")]
        public virtual Personnel Personnel { get; set; }
    }
}
