using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    interface ITrafficJamForm
    {
        public event EventHandler CarMovedEventHandler;
        public event EventHandler HelpKeyPressedEventHandler;
        public event EventHandler ResetKeyPressedEventHandler;
        public event EventHandler SkipKeyPressedEventHandler;
        public void AddModel(TrafficJamModel model);
    }
}
