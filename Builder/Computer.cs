using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        private string cpu;
        private string motherboard;
        private string gpu;
        private int ram;

        public string CPU
        {
            get;
            set;
        }

        public string Motherboard
        {
            get;
            set;
        }

        public string GPU
        {
            get; 
            set;
        }

        public int RAM
        {
            get;
            set;
        }
    }
    public class ComputerBuilder
    {
        Computer _computer = new Computer();         

        public ComputerBuilder CPU(string Cpu)
        {
            _computer.CPU = Cpu;
            return this;
        }

        public ComputerBuilder MotherBoard(string Motherboard)
        {
            _computer.Motherboard = Motherboard;
            return this;
        }

        public ComputerBuilder GPU(string Gpu)
        {
            _computer.GPU = Gpu;
            return this;
        }

        public ComputerBuilder RAM(int Ram)
        {
            _computer.RAM = Ram;
            return this;
        }

        public Computer build()
        {
            return _computer;
        }

    }
}
