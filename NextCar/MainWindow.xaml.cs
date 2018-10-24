using NextCar.Controller;
using NextCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NextCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car nextCar;
        bool engine;
        bool accu;
        bool door;

        public MainWindow()
        {
            InitializeComponent();

            AccubaterryController accubaterryController = new AccubaterryController();
            DoorController doorController = new DoorController();
            EngineController engineController = new EngineController();

            nextCar = new Car();
            nextCar.setAccubaterryController(accubaterryController);
            nextCar.setDoorController(doorController);
            nextCar.setEngineController(engineController);
        }


        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            if (powerIsOn)
            {
                this.nextCar.turnOfPower();
                this.AccuState.Content = "no power";
                this.AccuButton.Content = "OFF";
                accu = true;
            }
            else
            {
                this.nextCar.turnOnPower();
                this.AccuState.Content = "power is ready";
                this.AccuButton.Content = "ON";
                accu = false;
            }
        }

        private void OnDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            nextCar.closeTheDoor();

            Boolean doorIsLocked = nextCar.doorIsLocked();
            Boolean doorIsClosed = nextCar.doorIsClosed();
            if (doorIsClosed && !doorIsLocked)
            {
                this.nextCar.lockTheDoor();
                this.DoorState.Content = "door is locked";
                this.DoorButton.Content = "ON";
                door = true;
            }
            else if(doorIsLocked && doorIsLocked)
            {
                this.nextCar.unlockTheDoor();
                this.DoorState.Content = "door is unlocked";
                this.DoorButton.Content = "OFF";
                door = false;
            }

        }
        private void OnEngineButtonClicked(object sender, RoutedEventArgs e)
        {
            Boolean rpmSet = nextCar.rpmIsSet();
            if (rpmSet)
            {
                this.nextCar.turnOfEngine();
                this.EngineState.Content = "Engine off";
                this.EngineButton.Content = "OFF";
                engine = true;
            }
            else
            {
                this.nextCar.turnOnEngine();
                this.EngineState.Content = "Engine rpm set";
                this.EngineButton.Content = "ON";
                engine = false;
            }
        }

        private void OnStartButtonClicked(object sender, RoutedEventArgs e)
        {
            
            Boolean powerIsOn = nextCar.powerIsReady();
            nextCar.closeTheDoor();
            Boolean doorIsLocked = nextCar.doorIsLocked();
            Boolean doorIsClosed = nextCar.doorIsClosed();
            Boolean rpmSet = nextCar.rpmIsSet();

            if (!powerIsOn)
            {
                MessageBox.Show("Ups! Turn on the accu power, please");
            }
            if (!doorIsLocked)
            {
                MessageBox.Show("Ups! Close the door, please");
            }
            if (!rpmSet)
            {
                MessageBox.Show("Ups! Turn on the engine, please");
            }
            if (powerIsOn && doorIsLocked && rpmSet)
            {
                MessageBox.Show("Broom! car is ready");

            }
        }
    }
}
