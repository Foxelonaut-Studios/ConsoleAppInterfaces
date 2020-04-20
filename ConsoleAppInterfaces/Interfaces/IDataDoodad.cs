using ConsoleAppInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInterfaces.Interfaces
{
    interface IDataDoodad
    {
        void Add(IModeldad mDoodad);
        void RemoveById(int id);
        void Remove(IModeldad mDoodad);
        IModeldad GetById(int id);
        IModeldad FindOne<IModeldad>(IModeldad mDoodad);
        void Update<IModeldad>(IModeldad mDoodad);
    }
}
