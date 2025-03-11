using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor.Scheduler.Entities
{
    //public enum ScubaDivingTopic
    //{
    //    OpenWaterDiving,
    //    AdvancedOpenWater,
    //    RescueDiving,
    //    DiveSafetyAndFirstAid,
    //    EquipmentMaintenance,
    //    UnderwaterPhotography,
    //    WreckDiving,
    //    CaveDiving,
    //    NightDiving,
    //    MarineBiology,
    //    TechnicalDiving,
    //    DivePlanning
    //}

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Catalog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [StringLength(100)]
        public string InstructorName { get; set; }

        [Required]
        public DateTime DateOffered { get; set; } = GetNextMonday();

        [Range(1, int.MaxValue, ErrorMessage = "Length must be a positive number in minutes")]
        public int LengthInMinutes { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int TotalNumberOfStudents { get; set; }

        public int? MaximumCapacity { get; set; }

        [StringLength(500)]
        public string TeamsMeetingLink { get; set; }

        [StringLength(500)]
        public string ReplayLink { get; set; }

        public bool IsLive { get; set; }

        [StringLength(50)]
        public string EnrollmentStatus { get; set; }

        [Required]
        [StringLength(50)] // Added length constraint for consistency
        public string Topic { get; set; }

        public string Tags { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Hardcoded dropdown options for EnrollmentStatus
        private static readonly List<string> EnrollmentOptions = new List<string> { "Open", "Closed", "Waitlist" };
        [NotMapped]
        public string EnrollmentSelector
        {
            get => EnrollmentStatus != null && EnrollmentOptions.Contains(EnrollmentStatus) ? EnrollmentStatus : EnrollmentOptions[0];
            set => EnrollmentStatus = EnrollmentOptions.Contains(value) ? value : EnrollmentOptions[0];
        }
        public static IEnumerable<string> GetEnrollmentOptions => EnrollmentOptions;

        // Hardcoded dropdown options for LengthInMinutes
        private static readonly List<int> LengthOptions = new List<int> { 30, 60, 90, 120 };
        [NotMapped]
        public int LengthSelector
        {
            get => LengthOptions.Contains(LengthInMinutes) ? LengthInMinutes : LengthOptions[0];
            set => LengthInMinutes = LengthOptions.Contains(value) ? value : LengthOptions[0];
        }
        public static IEnumerable<int> GetLengthOptions => LengthOptions;

        // Hardcoded dropdown options for Topic
        private static readonly List<string> TopicOptions = new List<string>
    {
        "OpenWaterDiving",
        "AdvancedOpenWater",
        "RescueDiving",
        "DiveSafetyAndFirstAid",
        "EquipmentMaintenance",
        "UnderwaterPhotography",
        "WreckDiving",
        "CaveDiving",
        "NightDiving",
        "MarineBiology",
        "TechnicalDiving",
        "DivePlanning"
    };
        [NotMapped]
        public string TopicSelector
        {
            get => Topic != null && TopicOptions.Contains(Topic) ? Topic : TopicOptions[0];
            set => Topic = TopicOptions.Contains(value) ? value : TopicOptions[0];
        }
        public static IEnumerable<string> GetTopicOptions => TopicOptions;

        // Helper method to calculate the next Monday
        private static DateTime GetNextMonday()
        {
            DateTime today = DateTime.UtcNow;
            int daysUntilMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            if (daysUntilMonday == 0) // If today is Monday, move to next week
                daysUntilMonday = 7;
            return today.Date.AddDays(daysUntilMonday);
        }
    }

}

