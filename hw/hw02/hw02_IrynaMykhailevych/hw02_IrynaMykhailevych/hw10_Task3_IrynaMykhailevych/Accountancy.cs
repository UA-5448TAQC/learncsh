using System;

namespace hw10_Task3_IrynaMykhailevych
{
    public class Accountancy
    {
        public void PayingFellowship(int mark)
        {
            if (mark >= 10 && mark <= 12)
            {
                Console.WriteLine("Fellowship paid.");
            }
            else
            {
                Console.WriteLine("Fellowship not paid.");
            }
        }
    }
}
