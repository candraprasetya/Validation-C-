using NextCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar.Controller
{
    class AccubaterryController
    {
        private Accubattery accubattery;

        public AccubaterryController()
        {
            this.accubattery = new Accubattery(12);
        }

        public Boolean accubatterryIsOn()
        {
            return this.accubattery.isOn();
        }

        public void turnOn()
        {
            this.accubattery.turnOn();
        }
        public void turnOff()
        {
            this.accubattery.turnOff();
        }
    }
}
