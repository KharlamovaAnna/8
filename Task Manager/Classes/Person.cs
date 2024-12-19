namespace Task_Manager.Classes
{
    internal class Person
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public Person(string name, string contactInfo)
        {
            Name = name;
            ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            return $"{Name} ({ContactInfo})";
        }
    }
}
