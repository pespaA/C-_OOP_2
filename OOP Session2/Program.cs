namespace OOP_Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo.Demo0();

            employees[] emp = new employees[3];
            emp[0] = new employees(100, "Omar Ahmed", Gender.M, SecurityLevel.DBA, 99999);
            emp[1] = new employees(200, "Ahmed Mokhtar", Gender.Male, SecurityLevel.guest, 99999);
            emp[2] = new employees(300, "Omar asdasdasd", Gender.M, SecurityLevel.secretary, 99999);

            for (int i =0; i< emp.Length;i++)
            {
                Console.WriteLine(emp[i].ToString());
                Console.WriteLine("");
            }
        }
    }
}
