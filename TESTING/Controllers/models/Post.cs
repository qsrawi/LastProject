using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public class Post:IBaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Title { get; set; }
        public String Body { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        [InverseProperty("posts")]
        public Users User { get; set; }

        [ForeignKey("Rusers")]
        public int RUserId { get; set; }
        [InverseProperty("Rposts")]
        public Users Rusers { get; set; }

    }
}
