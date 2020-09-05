using System;
using System.Collections;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            MedicalPatient patient1 = new MedicalPatient("Gonzalo","094778292", "53421879");
            Doctor doctor1 = new Doctor("Omar Pérez", "Pediatría");
            AppointmentService consulta1 = new AppointmentService(); 
            DateTime appointmentsDate = new  DateTime(2020, 9, 15,20,30,00);
            Console.WriteLine(consulta1.CreateAppointment(patient1,appointmentsDate,"Casa de Galica",doctor1));
        }
    }
}
