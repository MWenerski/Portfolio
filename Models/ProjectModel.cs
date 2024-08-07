using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class ProjectModel
    {
        public int ID { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required string GitLink { get; set; }

        public string? PictureUrl1 { get; set; }
        public string? PictureUrl2 { get; set; }
    }
}
