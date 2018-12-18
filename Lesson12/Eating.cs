using System;
using System.Collections;

namespace Lesson12
{
    public class Eating<T>
        where T: IEnumerable
    {
        public int Volume { get; private set; }

        public T Add(T product)
        {
            return default(T);
        }
    }
}
