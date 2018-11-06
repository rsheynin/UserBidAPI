using System.Collections.Generic;

namespace UserBidAPI.DomainServices
{
    public interface IRepository<T>
    {
        void Add(T obj);
        T Get(string name);
        T Get(int id);
        IList<T> Get();
    }
}