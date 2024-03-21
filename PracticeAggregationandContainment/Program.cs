namespace PracticeAggregationandContainment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor instructor = new Instructor("Will", "Cram");

            SchoolProgram prog124 = new SchoolProgram("Programming", "J102", "Room123", instructor);
            prog124.AddStudent("Ana", "Mendes", 100, 100);



            Console.WriteLine(prog124);
            //Console.WriteLine($"Instructor: {will}");

            foreach (Student student in prog124.ClassRoster)
            {
                Console.WriteLine(student);

            }
        }
    }
}