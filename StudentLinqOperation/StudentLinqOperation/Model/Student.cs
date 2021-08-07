namespace StudentLinqOperation.Model
{
    public class Student
    {

        private int _id;
        private string _name;
        private double _cgpa;
        private string _location;

        public Student(int id, string name, double cgpa, string location)
        {
            _id = id;
            _name = name;
            _cgpa = cgpa;
            _location = location;
        }

        public int StudentId
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Cgpa
        {
            get { return _cgpa; }
            set { _cgpa = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
