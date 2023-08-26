using System.ComponentModel.DataAnnotations;
namespace BlueAPI.Model;

public class DEASchedulesModel
{
    [Key]
    public int? DEAScheduleID { get; set; }
    public string? Status { get; set; }
    public string? ScheduleTypeTitle { get; set; }
    public string? ScheduleTitle { get; set; }
    public DateTime? LastModifiedDate { get; set; }
}





