using System;

namespace list
{
    public interface IList<T> where T : IComparable
    {
        void AddElementToEnd(T value);
        bool FindValue(T value);
        void DeleteValue(T value);
    }
}