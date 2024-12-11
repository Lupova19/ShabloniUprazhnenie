using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalBoxOfStrings
{
    public class Box<T>
    {
        private T data;
        public T Value
        {
            get { return data; }
            set { data = value; }
        }

        public Box(T data)
        {
            this.data = data;
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data}";
        }
    }
}
