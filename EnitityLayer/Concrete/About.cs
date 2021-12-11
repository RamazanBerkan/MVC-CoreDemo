using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityLayer.Concrete
{
   public class About
    {
        [Key]

        public int AboutId { get; set; }

        public string AboutDetalis1 { get; set; }
        public string AboutDetalis2 { get; set; }

        public string AboutIamge1 { get; set; }
        public string AboutIamge2 { get; set; }

        public string AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }

    }
}
