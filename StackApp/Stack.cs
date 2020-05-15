using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    public class Stack
    {
        private List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null parameter is not permitted");
            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stack is empty!");
            var index = _list.Count - 1;
            var result = _list[index];
            _list.RemoveAt(index);
            return result;
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
