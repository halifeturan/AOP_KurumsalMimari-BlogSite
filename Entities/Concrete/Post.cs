using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Post:IEntity
    {
        [Key]
        public int PostID { get; set; }
        public string PostContents { get; set; }
        public DateTime PostDate { get; set; }
        public string PostTitle{ get; set; }
    }
}
