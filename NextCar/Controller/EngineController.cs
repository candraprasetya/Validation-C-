using NextCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar.Controller
{
    class EngineController
    {
        private Engine engine;

        public EngineController()
        {
            this.engine = new Engine(800);
        }

        public Boolean engineIsOn()
        {
            return this.engine.isRot();
        }

        public void turnOn()
        {
            this.engine.turnOn();
        }
        public void turnOff()
        {
            this.engine.turnOff();
        }
    }
}
