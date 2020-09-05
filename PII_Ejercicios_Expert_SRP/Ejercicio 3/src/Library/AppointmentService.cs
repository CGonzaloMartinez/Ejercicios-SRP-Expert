using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        public string CreateAppointment(MedicalPatient patient,DateTime date, string appointmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n...\n\n");
            Boolean isValid = true;
            

            if ( ! patient.PatientIsValid())
            {
                stringBuilder.Append("Unable to schedule appointment, patient data is still required\n");
                isValid = false;
            }

            if ( ! doctor.DoctorIsValid())
            {
                stringBuilder.Append("Unable to schedule appointment, doctor data is still required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append($"Appoinment Scheduled. \n\nPatient: {patient.name} - Doctor: {doctor.doctorName} - Place: {appointmentPlace} -  Date: {date}\n");
            }

            return stringBuilder.ToString();
        }

    }   
}
