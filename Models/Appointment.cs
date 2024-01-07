using System.ComponentModel.DataAnnotations;

namespace proiect.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        [Required(ErrorMessage = "ClientId is required.")]
        public int ClientId { get; set; }
        [Required(ErrorMessage = "StylistId is required.")]
        public int StylistId { get; set; }
        [Required(ErrorMessage = "Date is required.")]
        public DateTime AppointmentDate { get; set; }
        [Required(ErrorMessage = "Status is required.")]
        public string Status { get; set; }
    }
}
