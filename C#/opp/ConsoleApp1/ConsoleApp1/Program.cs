class Employee
{
    public int id;
    public String name;
    public double grosspay;
    static double text = 0.1;
    public double netsalary;
    public Employee(int id, String name, double grosspay)
    {
        this.id = id;
        this.name = name;
        this.grosspay = grosspay;
    }
    void calculateSalary()
    {
        if (grosspay > 3000)
        {
            netsalary = grosspay - (text * grosspay);
            Console.WriteLine("Employee Id Is : {0} \n " +
                "Employee Name is : {1} \n" + "Employee Salary is : {2}", id, name, netsalary);
        }
        else
        {
            Console.WriteLine("Employee Id Is : {0} \n " +
              "Employee Name is : {1} \n" +
              "Employee Salary is : {2}", id, name, grosspay);
        }
    }
    public void showSalary()
    {
        this.calculateSalary();
    }

}


class program
{
    public static void Main()
    {
        var salary = new Employee(101,"IbrHIM",3000);
        salary.showSalary();
    }
}


////abstract class person
////{
////   public int id;
////    public String name;
////    public int age;
////    public String address;
////   public  abstract void myinfo();
////}
//// class student: person
////{
////    public int fee;
////    public String course;
////    public override void myinfo()
////    {
////        Console.WriteLine("Std anem is {0} \n" +
////            "std age is : {1} \n" +
////            "std fees is : {2} \n" +
////            "std address is : {3}",this.name ,this.age ,this.fee,this.address);
////    }
////}

//// class teacher: person
////{
////    public int salary;
////    public String qualification;
////    public override void myinfo()
////    {
////        Console.WriteLine("teacher neme is {0} \n" +
////            "teacher age is : {1} \n" +
////            "teacher fees is : {2} \n" +
////            "teacher address is : {3}", this.name, this.age, this.salary, this.qualification);
////    }
////}



////class program
////{
////    public static void Main()
////    {
////        var std1 = new student();
////        std1.name = "Ibrahim";
////        std1.age = 23;
////        std1.fee = 5500;
////        std1.address = "korangi";
////        std1.myinfo();

////        //Employee emp1 = new Employee(1, "Ibrahim", 39000);
////        //emp1.showSalary();

////    }
////}












//using System.Collections;
//public delegate void addition(int a, int b);
//public delegate void read();
//class program
//{
//    public static void readdata()
//    {
//        Console.WriteLine("This is Called Degates");
//    }

// public static void sum(int a, int b)
//    {
//        Console.WriteLine("Your sum is : {0}",a+b);
//    }
//    public static void sub(int a, int b)
//    {
//        Console.WriteLine("Your sub is : {0}", a - b);
//    }
//    public static void Main()
//    {

//        addition add1 = new addition(sum);
//        add1 = sub;

//        sub(9,7);

//        read only = new read(readdata);
//        only();









//        //calculation obj = new calculation(program.add);
//        //obj.Invoke(5,5);
//        //obj = sub;
//        //obj(10, 2);
//        //obj(10, 10);





//        //ArrayList mylist=new ArrayList();
//        ////Console.WriteLine(mylist.Capacity);
//        //mylist.Add(1);
//        ////Console.WriteLine(mylist.Capacity);
//        //mylist.Add("Ibrahim");
//        //mylist.Add("khizer");
//        //mylist.Add("loop");
//        //mylist.Add('w');
//        ////Console.WriteLine(mylist.Capacity);
//        //mylist.Insert(1,"Muskan");
//        //mylist.Remove("loop");
//        //mylist.RemoveAt(4);

//        //foreach(object i in mylist)
//        //{
//        //    Console.Write(i+" __  ");
//        //}


//        //mylist.Add(23);
//        //Console.WriteLine(mylist[1]);



//        //int[] record= new int[3];
//        //record[0] = 5;
//        //record[1] = 6;
//        //record[2] = 7;
//        //Array.Resize(ref record,5);
//        //record[3] = 8;
//        //record[4]= 9;
//        //record[5]= 10;


//    }
//}



























////using ConsoleApp1;

////var st = new Students();
////st.getinfo();


//////class Student
//////{
//////    public int id;
//////    public String name;
//////    public String mail;
//////    public String password;

//////    public Student()
//////    {
//////        Console.WriteLine("first calling");
//////    }

//////    public Student(int id, String name, String mail, String pass)
//////    {
//////        this.id = id;
//////        this.name = name;
//////        this.mail = mail;
//////        this.password = pass;
//////    }

//////    public void getinfo()
//////    {
//////        Console.WriteLine("Student Id is : {0}" +
//////            "\n Student Name is : {1}\n Student Mail is : {2}" +
//////            "\n Student Password is : {3}", this.id, this.name, this.mail, this.password);
//////    }
//////}
//////class program
//////{
//////    public static void Main()
//////    {
//////        Student student = new Student(1, "ibrahim", "ibrahim@gmail.com", "123");
//////        student.getinfo();
//////        //Student student1 = new Student(2, "muskan", "muskan@gmail.com", "muskan123");
//////        //student1.getinfo();
//////    }
//////}

////using ConsoleApp1;

////class course
////{

////    public int courseId;
////    public String name;
////    public String description;
////    public String duration;
////}
////class teacher :course
////{
////    public int teacherId;
////    public String teacherName;
////}

////class students: teacher
////{
////    public int studentId;
////    public String studentName;
////    public String address;
////    public int age;

////    public students(int sid,int tid,int cid,String sname,String saddress,int sage)
////    {
////        this.studentId = sid;
////        this.age = sage;
////        this.studentName=sname;
////        this.address = saddress;
////        this.teacherId = tid;
////        this.courseId = cid;
////    }

////    public void getinfo()
////    {
////        Console.WriteLine("Student name is : {0} \n age : {1}\n address{2}\n teacher id is : {3}\n course id is : {4}",
////            this.studentId,
////            this.age,this.studentName,this.address,this.teacherId,this.courseId);
////    }
////}

////class program
////{
////    public static void Main()
////    {
////        var Class2 = new Class2();
////        Class2.name = "html";
////        Console.WriteLine(Class2.name);

////        //var student = new students(101,001,300,"Ibrahim","Aptech",23);
////        //student.getinfo();
////    }
////}









//sealed class parent {

//    int id;
//    String name;
//    int age;
//}

//class child :parent
//{
//    int id;
//} 










