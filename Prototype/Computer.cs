using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Computer
    {
        private string cpu;
        private string motherboard;
        private string gpu;
        private int ram;

        public string CPU
        {
            get { return cpu; }
            set { cpu = value; }
        }

        public string Motherboard
        {
            get { return motherboard; }
            set { motherboard = value; }
        }

        public string GPU
        {
            get { return gpu; }
            set { gpu = value; }
        }

        public int RAM
        {
            get { return ram; }
            set { ram = value; }
        }

        protected Computer() { }

        protected Computer(Computer comp)
        {
            this.cpu = comp.CPU;
            this.motherboard = comp.Motherboard;
            this.gpu = comp.GPU;
            this.ram = comp.RAM;
        }

        public abstract Computer clone();
    }
}
