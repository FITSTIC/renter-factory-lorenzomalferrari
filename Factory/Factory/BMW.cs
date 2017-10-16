using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BMW : ICar
    {
        private string targa;
        public string Model => "BMW Serie 3 Touring";
        public BMW(string targa)
        {
            this.targa = targa;
        }
    }
}
