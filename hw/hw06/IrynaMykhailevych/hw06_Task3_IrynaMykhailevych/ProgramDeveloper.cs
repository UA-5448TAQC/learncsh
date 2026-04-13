using System;

namespace hw06_Task3_IrynaMykhailevych

{
    internal class ProgramDeveloper
    {
        public static void Main()
        {
            Programmer programmer1 = new Programmer() { Language = "C#", Tool = "Visual Studio" };
            Programmer programmer2 = new Programmer() { Language = "Python", Tool = "VS Code" };
            Builder builder1 = new Builder() { Tool = "Hammer" };
            Builder builder2 = new Builder() { Tool = "Drill" };
            
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(programmer1);
            developers.Add(programmer2);
            developers.Add(builder1);
            developers.Add(builder2);

            Console.WriteLine("Before sorting:");

            foreach (IDeveloper dev in developers)
            {
                dev.Create();
                dev.Destroy();
            }

            developers.Sort((x, y) => x.Tool.CompareTo(y.Tool));

            Console.WriteLine("After sorting:");

            foreach (IDeveloper dev in developers)
            {
                dev.Create();
                dev.Destroy();
            }
        }
    }
} 
