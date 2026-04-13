namespace ConsoleApp1
{
    internal interface IDeveloper
    {
        string Tool { get; }

        void Create();

        void Destroy();
    }
}