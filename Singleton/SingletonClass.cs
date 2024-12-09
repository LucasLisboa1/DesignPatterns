using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance;
        private int data = 0;

        private SingletonClass(int data)
        {
            this.data = data;
        }

        public static SingletonClass getInstance(int data)
        {
            if (_instance == null)
            {
                return new SingletonClass(data);
            }

            return _instance;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
