using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_16
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
