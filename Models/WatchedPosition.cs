namespace ARD.Models
{
    public class WatchedPosition
    {
        [Key]
        public int WatchedPositionId { get; set; }

        [Required]
        public int X { get; set; }

        [Required]
        public int Y { get; set; }

        [Required]
        public int Z { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime WatchedPositionCreationDate { get; set; }
    }
}