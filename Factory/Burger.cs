using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface Burger
    {
        public string Sauce { get; set; }

        public abstract void prepare();
    }
}
