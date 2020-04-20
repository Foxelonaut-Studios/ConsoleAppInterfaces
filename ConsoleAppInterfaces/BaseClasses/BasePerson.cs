using ConsoleAppInterfaces.Interfaces;

namespace ConsoleAppInterfaces.BaseClasses
{
    public class BasePerson : IModeldad
    {
        public int Id { get; }
        public int id { get; private set; }
    }
}
