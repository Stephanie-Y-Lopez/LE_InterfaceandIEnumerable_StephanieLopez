namespace LE_InterfaceandIEnumerable_StephanieLopez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Bottle bottle = new Bottle();
            Chest chest = new Chest();

            List<IOpen> openableItems = new List<IOpen>();
            openableItems.Add(door);
            openableItems.Add(bottle);
            openableItems.Add(chest);

            //Opening each item!
            foreach (var item in openableItems)
            {
                item.Open();
            }

            ClassRoster prog124 = new ClassRoster();

            //Adding students to the class roster
            prog124.AddStudent("Will", "Cram");
            prog124.AddStudent("Manjula", "Manjula");
            prog124.AddStudent("Yolis", "Chavoya");
            prog124.AddStudent("Mia", "Mendez");
            prog124.AddStudent("Yolanda", "Chavoya");

            //Displaying using foreach
            foreach (Student student in prog124)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}