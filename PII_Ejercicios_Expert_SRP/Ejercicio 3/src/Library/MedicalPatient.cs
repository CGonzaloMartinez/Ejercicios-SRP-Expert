


namespace Library
{
    public class MedicalPatient
    {
        public string name {get; set;}
        public string id {get; set;}
        public string phoneNumber{get;set;}

        public MedicalPatient(string name, string id, string phoneNumber)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
        }

        public bool PatientIsValid()
        {
            return  ! string.IsNullOrEmpty(this.name) && ! string.IsNullOrEmpty(this.id) && ! string.IsNullOrEmpty(this.phoneNumber);
        }   
    }
}