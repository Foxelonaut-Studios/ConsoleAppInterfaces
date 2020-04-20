using ConsoleAppInterfaces.BaseClasses;
using ConsoleAppInterfaces.Interfaces;
using ConsoleAppInterfaces.Models;
using System.Collections.Generic;

namespace ConsoleAppInterfaces.DataDoodads
{
    class BaseDataCache<T> where T: IModeldad
    {
        private int count = 0;

        public BaseDataCache(IDictionary<int, T> data, int cnt)
        {
            Data = data;
            Count = cnt;
        }

        public IDictionary<int, T> Data { get; private set; }

        public int Count { get => count; private set => count = value; }



        public void Add(T data)
        {
            Data.Add(count++, data);
        }

        public T GetById(int id)
        {
            return Data[id];
        }

        public bool RemoveById(int id)
        {
            bool result = false;
            if (FindOneById(id).Sucess)
            {
                Data.Remove(id);
                count--;
                result = true;
            }
            return result;
        }



        public bool Remove(T data)
        {
            bool result = false;
            if(FindOne(data).Sucess)
            {
                Data.Remove(data.Id);
                count--;
                result = true;
            }
            return result;
        }

        public (bool Sucess, T Item) FindOne(T data)
        {
            T item;
            bool success = Data.TryGetValue(data.Id, out item);
            return (success, item);
        }
        public (bool Sucess, T Item) FindOneById(int id)
        {
            T item;
            bool success = Data.TryGetValue(id, out item);
            return (success, item);
        }
        public void Update(T data)
        {
            Data[data.Id] = data;
        }
    }
}
