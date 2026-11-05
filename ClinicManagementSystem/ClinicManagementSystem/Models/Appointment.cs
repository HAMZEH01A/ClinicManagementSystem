using System;

namespace ClinicManagementSystem.Models
{
    /// <summary>
    /// Represents an Appointment record.
    /// </summary>
    public class Appointment
    {
        public int      AppointmentID   { get; set; }
        public int      PatientID       { get; set; }
        public int      DoctorID        { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string   TimeSlot        { get; set; }
        public string   Status          { get; set; } = "Scheduled";
        public string   Notes           { get; set; }
        public DateTime CreatedAt       { get; set; } = DateTime.Now;

        public string PatientName { get; set; }
        public string DoctorName  { get; set; }

        public Appointment() { }

        public Appointment(int patientId, int doctorId,
                           DateTime appointmentDate, string timeSlot)
        {
            PatientID       = patientId;
            DoctorID        = doctorId;
            AppointmentDate = appointmentDate;
            TimeSlot        = timeSlot;
        }

        public override string ToString() =>
            $"Appt #{AppointmentID} | {PatientName} -> Dr. {DoctorName} | {AppointmentDate:d} {TimeSlot} | {Status}";
    }
}
