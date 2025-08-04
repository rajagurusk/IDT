using System.ComponentModel.DataAnnotations;

namespace IDT.Models
{
    public class ScanData
    {
        public int Id { get; set; }

        [Required]
        public string?LotNo { get; set; }

        [Required]
        public string? Size { get; set; }

        public string? Remarks { get; set; } // nullable
    }

}
