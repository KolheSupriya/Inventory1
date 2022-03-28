using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


/*
 User_ID	Role_ID	User_Name	Full_Name	Password	DOB	City	Address	Zip_Code	Created_At	Email
1	1	supriyakol	supriya kolhe	supriya@123	23-07-97	mumbai	temporary address, state,country	421578	26-03-22	supriya@gmail.com
2	2	supriyakol	supriya kolhe	supriya@12345	21-07-97	pune	temporary address, state,country	421578	26-03-22	supriyaa@gmail.com
*/
namespace InventoryManagementSystem
{
    

    class USERS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int User_ID { get; set; }
        
        
        [Required]
        public int Role_ID { get; set; }
        [ForeignKey("Role_ID")]
        public ROLE ROLE { get; set; }




        [Required]
        [Index(IsUnique = true)]
        [MaxLength(15, ErrorMessage = "{0} length must be under {1}.")][MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        public string User_Name { get; set; }
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public string First_Name { get; set; }
        [MaxLength(15, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public string Last_Name { get; set; }
        [MaxLength(15, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public string Password { get; set; }

        [Required] public DateTime DOB { get; set; }
        [MaxLength(20, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public string City { get; set; }
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public string Address { get; set; }
        [MaxLength(6, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(5, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public int Zip_Code { get; set; }
        [MaxLength(30, ErrorMessage = "{0} length must be under {1}.")]
        [MinLength(4, ErrorMessage = "{0} length must be above {2}.")]
        [Required] public string Email { get; set; }
        
    }
}
