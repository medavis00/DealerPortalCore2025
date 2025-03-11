using System;
using System.ComponentModel.DataAnnotations;

namespace Blazor.Scheduler.App.Entities;

public enum ScubaDivingTopic
{
    OpenWaterDiving,
    AdvancedOpenWater,
    RescueDiving,
    DiveSafetyAndFirstAid,
    EquipmentMaintenance,
    UnderwaterPhotography,
    WreckDiving,
    CaveDiving,
    NightDiving,
    MarineBiology,
    TechnicalDiving,
    DivePlanning
}

public class TrainingVideo
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
    public DateTime DateOffered { get; set; }

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
    public string EnrollmentStatus { get; set; } // e.g., "Open", "Closed", "Waitlist"

    [Required]
    public ScubaDivingTopic Topic { get; set; } // Replaces Category with scuba-specific enum

    public string Tags { get; set; } // e.g., "beginner, PADI, safety"

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; } = true;
}

