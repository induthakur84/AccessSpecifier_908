

// What is the Access Specifier in C#?


//Access Specifier in C# are keywords used to define the accessiability
// of the classess methods, properties and other members

// this determine who can access these memeber and how can be accessed



//5 types

// 1 .Public : Members declared as public can be accessed from anywhere in the code.


// 2 Private: Members declares as private can be accessed only within the same class.


// 3.Protected: Member declared as protecture can be accessed with the same class
// and by the derived class


// 4. Internal: Member declared as internal can be accessed within the same assemble,
//but not from other assemblies


//5.Protected Inhternal: Member detail as protectured internal can be acesssed

// anywhere in the sam assembly or from derieved class, even it the derieve class
//is in the anothere asseembly



using System.Globalization;
using System.Xml.Linq;

namespace AccessSpecifier
{
    class student
    {

        // public variable


        public string Name = "Admin";// public


        private int age = 30;// private variable


        //protected variable

        protected string Colleage = "ABC";

        internal string City = "xyz";



        public void ShowStudentDetails()
        {
            Console.WriteLine("Name : " +  Name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("College : " + Colleage);
            Console.WriteLine("City : " + City);
        }

    }


    class collegeStudent: student
    {
        public void showCollegeDetails()
        {
            Console.WriteLine("Name : " + Name);
          //
          //Console.WriteLine("Age : " + age);
            Console.WriteLine("College : " + Colleage);
            Console.WriteLine("City : " + City);
        }
    }


    class OtherClass
    {
        public void showOtherDetails()
        {
            student s= new student();
            Console.WriteLine("Name : " + s.Name);
          //  Console.WriteLine("Age : " + s.age);//private
           // Console.WriteLine("College : " + s.Colleage);//protected
            Console.WriteLine("City : " + s.City);

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.ShowStudentDetails();



            collegeStudent collegeStudent = new collegeStudent();

            collegeStudent.showCollegeDetails();


            OtherClass otherClass = new OtherClass();

            otherClass.showOtherDetails();
        }

    }
}