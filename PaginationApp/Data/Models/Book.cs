using System.ComponentModel.DataAnnotations;

namespace PaginationApp.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Author { get; set; }
        [StringLength(50)]
        public string Genre { get; set; }
    }
}
