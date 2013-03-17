using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachine
{
    public partial class StateMachine
    {
        private string xml_file;

        public StateMachine(string file)
        {
            xml_file = file;
        }
    }
}
