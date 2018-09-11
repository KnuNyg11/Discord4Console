using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord4Console.Objects
{
    class GenericPayload
    {
        public int op { get; set; }
        public object d { get; set; }
    }
}
