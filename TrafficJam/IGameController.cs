using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    interface IGameController
    {
        void OnCarMoved(Car selectedCar);
        void OnHelpKeyPressed();
        void OnResetKeyPressed();
        void OnSkipKeyPressed();
        public void AddTrafficJamFormReference(TrafficJamForm form);
        public void StartGame();

    }
}
