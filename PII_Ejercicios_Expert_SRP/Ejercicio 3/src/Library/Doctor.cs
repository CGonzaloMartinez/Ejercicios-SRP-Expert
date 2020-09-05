


namespace Library
{
    public class Doctor
    {
        public string doctorName{get; set;}
        public string medicalSpeciallity{get; set;}

        public Doctor (string doctorName, string medicalSpeciallity)
        {
            this.doctorName = doctorName;
            this.medicalSpeciallity = medicalSpeciallity;
        }

        public bool DoctorIsValid()
        {
            return ! string.IsNullOrEmpty(doctorName) && ! string.IsNullOrEmpty(medicalSpeciallity);
        }   
    }


}