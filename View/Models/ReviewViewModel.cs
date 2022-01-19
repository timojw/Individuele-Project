using System.ComponentModel.DataAnnotations;

namespace View.Models
{
    public class ReviewViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int Stars { get; set; }
        public int ReviewerID { get; set; }
        public int ProductID { get; set; }
        public string ReviewerName { get; set; }

    }
}
