using NextCar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar
{
    class Car
    {

        AccubaterryController accubaterryController;
        DoorController doorController;
        EngineController engineController;
        LoginController loginController;

        //Main Controller
        public void setDoorController(DoorController doorController)
        {
            this.doorController = doorController;
        }

        public void setLoginController(LoginController loginController)
        {
            this.loginController = loginController;
        }

        public void setAccubaterryController(AccubaterryController accubaterryController)
        {
            this.accubaterryController = accubaterryController;
        }

        public void setEngineController(EngineController engineController)
        {
            this.engineController = engineController;
        }

        //Battery Controller
        public void turnOnPower()
        {
            this.accubaterryController.turnOn();
        }
        public void turnOfPower()
        {
            this.accubaterryController.turnOff();
        }
        public Boolean powerIsReady()
        {
            return this.accubaterryController.accubatterryIsOn();
        }

        //Engine Controller
        public void turnOnEngine()
        {
            this.engineController.turnOn();
        }
        public void turnOfEngine()
        {
            this.engineController.turnOff();
        }
        public Boolean rpmIsSet()
        {
            return this.engineController.engineIsOn();
        }

        //Door Controller
        public void closeTheDoor()
        {
            this.doorController.close();
        }
        public void openTheDoor()
        {
            this.doorController.open();
        }
        public void lockTheDoor()
        {
            this.doorController.activateLock();
        }
        public void unlockTheDoor()
        {
            this.doorController.unlock();
        }
        public bool doorIsClosed()
        {
            return this.doorController.isClose();
        }
        public bool doorIsLocked()
        {
            return this.doorController.isLocked();
        }
    }
}
