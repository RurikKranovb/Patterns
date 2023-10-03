using Command.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command.Infrastructure
{
    public class TVOnCommand : Core.ICommand
    {

        TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }


        public void Execute()
        {
            tv.On();
        }

        public void Unde()
        {
            tv.Off();
        }
    }
}
