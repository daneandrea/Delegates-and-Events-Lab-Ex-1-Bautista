namespace AccountRegistration
{
    internal class StudentInfoClass
    {
        public StudentInfoClass()
        {
        }

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string MiddleName { get; internal set; }
        public string Address { get; internal set; }
        public long ContactNo { get; internal set; }
        public string Program { get; internal set; }
        public long Age { get; internal set; }
        public long StudentNo { get; internal set; }
    }
}