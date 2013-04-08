using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Projects\Fun\StateMachine\StateMachineGenerator\StateMachineConsole\scxml\SCTurnstile.xml";
            StateMachine.StateMachine sm = new StateMachine.StateMachine(file);
            
            string code = sm.TransformText();
            System.IO.File.WriteAllText(@"C:\temp\StateMachine.cs", code);

        }
    }
}
