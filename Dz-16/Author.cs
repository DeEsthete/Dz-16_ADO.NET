using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_16
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string AboutAuthor { get; set; }
        public int Age { get; set; }
    }
}
