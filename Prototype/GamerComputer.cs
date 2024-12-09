using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class GamerComputer : Computer
    {
        private bool _hasRGB;
        
        public bool HasRGB
        {
            get { return _hasRGB; }
            set { _hasRGB = value; }
        }

        public GamerComputer()
        {

        }

        public GamerComputer(GamerComputer gamer) : base(gamer)
        {
            this._hasRGB = gamer.HasRGB;
            var test = this;
        }

        public override GamerComputer clone()
        {
            return new GamerComputer(this);
        }
    }

    public class ServerComputer : Computer
    {
        private int _numberOfHDs;

        public int NumberOfHDs
        {
            get { return _numberOfHDs; }
            set { _numberOfHDs = value; }
        }

        public ServerComputer()
        {

        }

        public ServerComputer(ServerComputer gamer) : base(gamer)
        {
            this._numberOfHDs = 40;
        }

        public override Computer clone()
        {
            return new ServerComputer(this);
        }
    }
}
