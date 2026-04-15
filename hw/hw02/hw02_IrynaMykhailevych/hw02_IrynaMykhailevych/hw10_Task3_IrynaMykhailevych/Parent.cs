using System;

namespace hw10_Task3_IrynaMykhailevych
{
    public class Parent
    {
        public void OnMarkChange(int mark)         
        {
            Console.WriteLine($"Parent notified: Student received a mark of {mark}.");
        }
    }
}
