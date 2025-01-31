using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Enrollment
{
    [Required]
    public Guid Id { get; set; }

    [Range(0, 100, ErrorMessage = "Score must be between 0 to 100")]
    public byte? Score { get; set; }

    public DateTime JoinedAt { get; init; } = DateTime.UtcNow;

    public DateTime? EndedAt { get; set; }

    [Required(ErrorMessage = "StudentId is required.")]
    [ForeignKey(nameof(Student))]
    public Guid StudentId { get; set; }

    [Required(ErrorMessage = "CourseId is required.")]
    [ForeignKey(nameof(Course))]
    public Guid CourseId { get; set; }
    
    public Student? Student { get; set; }
    public Course? Course { get; set; }
}