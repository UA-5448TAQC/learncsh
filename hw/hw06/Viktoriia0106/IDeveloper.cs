namespace ConsoleAppVRHW06
{
    interface IDeveloper
    {
        string Tool { get; set;}
        void Create();
        void Destroy();
    }
}