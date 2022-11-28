// See https://aka.ms/new-console-template for more information
class Student
{
    public string name;
    public int weight;

    public Student(string modelName,int modelWeight)
    {
        name = modelName;
        weight = modelWeight;

    }
    static void Main(string[] args)
    {
        Student student1 = new Student("ter", 71);
        Student student2 = new Student("haroon", 60);
        Student student3 = new Student("ta", 60);
        Student student4 = new Student("palm", 55);
        Student student5 = new Student("pee", 62);
        int[] weightlist = { student1.weight, student2.weight, student3.weight, student4.weight, student5.weight };
        int Max = weightlist.Max();
        int Min = weightlist.Min();
        Console.WriteLine("แสดงค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด" + (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักมากที่สุด" + Max);
        Console.WriteLine("แสดงชื่อและน้ำหนักของคนที่มีน้ำหนักน้อยที่สุด"+ Min);
        Console.WriteLine("นาย ประจักษ์ ศรีทอง 653450294-0");
    }   
}
