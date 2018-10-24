using NextCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar.Controller
{
    class DoorController
    {
        private Door door;

        public DoorController()
        {
            this.door = new Door();
        }

        public void close()
        {
            this.door.close();
        }

        public void open()
        {
            this.door.open();
        }
            
        public void activateLock()
        {
            if (this.door.isClosed())
            {
                this.door.activateLock();
            }
            else
            {
                Console.WriteLine("Upps, can't lock the door because it is opened");
            }
        }

        public void unlock()
        {
            this.door.unlock();
        }
        public bool isClose()
        {
            return this.door.isClosed();
        }
        public bool isLocked()
        {
            return this.door.isLocked();
        }
    }
}
