using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar.Model
{
    class Engine
    {
        private int rpm;
        private Boolean isRotate = false;

        public Engine(int r)
        {
            this.rpm = r;
        }

        public void turnOn()
        {
            this.isRotate = true;
        }

        public void turnOff()
        {
            this.isRotate = false;
        }

        public Boolean isRot()
        {
            return this.isRotate;
        }
    }
}
