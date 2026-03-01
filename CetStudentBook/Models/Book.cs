using System;
using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Book name is required")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 200 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Author must be between 2 and 200 characters")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Publish date is required")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Page count is required")]
        [Range(1, 10000, ErrorMessage = "Page count must be between 1 and 10000")]
        public int PageCount { get; set; }

        [Required]
        public bool IsSecondHand { get; set; }
    }
}
