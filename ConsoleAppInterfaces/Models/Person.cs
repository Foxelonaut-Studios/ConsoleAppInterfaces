using ConsoleAppInterfaces.BaseClasses;
using ConsoleAppInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaces.Models
{
    struct Person : IModeldad
    {
        public string Name;
        public string Email;
        public string Created;
        public string Updated;
        public int Id { get; }
        public int id { get; private set; }
    }
}
