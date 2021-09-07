using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    interface IGameController
    {
        public void AddTrafficJamFormReference(TrafficJamForm form);
        public void StartGame();
    }
}
