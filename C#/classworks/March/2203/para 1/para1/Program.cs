using static para1.SmartHomeFacade;

namespace para1
{
    public class LightSystem()
    {
        public bool isTurnedOn { get; set; } = false;
        public void TurnOnLights()
        {
            if (isTurnedOn == false)
            {
                Console.WriteLine("Lights is turned on");
                isTurnedOn = true;
            }
            else
            {
                Console.WriteLine("Done");
            }
        }

        public void TurnOffLights()
        {
            if (isTurnedOn == true)
            {
                Console.WriteLine("Lights is turned off");
                isTurnedOn = false;
            }
            else
            {
                Console.WriteLine("Done");
            }

        }
    }

    public class HeatingSystem()
    {
        public bool isTurnedOn { get; set; } = false;
        public void TurnOnHeating()
        {
            if (isTurnedOn == false)
            {
                Console.WriteLine("Heating is turned on");

                isTurnedOn = true;
            }
            else
            {
                Console.WriteLine("Done");
            }
        }

        public void TurnOffHeating()
        {
            if (isTurnedOn == true)
            {
                Console.WriteLine("Heating is turned off");
                isTurnedOn = false;
            }
            else
            {
                Console.WriteLine("Done");
            }
        }
    }

    public class SecuritySystem()
    {
        public bool isTurnedOn { get; set; } = false;
        public void ActivateAlarm()
        {
            if (isTurnedOn == false)
            {
                Console.WriteLine("Alarm is turned on");

                isTurnedOn = true;
            }
            else
            {
                Console.WriteLine("Done");
            }
        }

        public void DeactivateAlarm()
        {
            if (isTurnedOn == true)
            {
                Console.WriteLine("Alarm is turned off");
                isTurnedOn = false;
            }
            else
            {
                Console.WriteLine("Done");
            }
        }
    }

    public class SmartHomeFacade()
    {

        private int PIN = 1043;

        private readonly LightSystem lightSystem = new LightSystem();

        private readonly HeatingSystem heatingSystem = new HeatingSystem();

        private readonly SecuritySystem securitySystem = new SecuritySystem();

        public void TurnOn()
        {
            Console.Write("Enter PIN:");
            int PIN = int.Parse(Console.ReadLine());

            if (this.PIN == PIN)
            {
                lightSystem.TurnOnLights();
                heatingSystem.TurnOnHeating();
                securitySystem.DeactivateAlarm();
            }
            else
            {
                Console.WriteLine("Wrong PIN");
            }
        }

        public void TurnOff()
        {
            Console.Write("Enter PIN:");
            int PIN = int.Parse(Console.ReadLine());

            if (this.PIN == PIN)
            {
                lightSystem.TurnOffLights();
                heatingSystem.TurnOffHeating();
                securitySystem.ActivateAlarm();
            }
            else
            {
                Console.WriteLine("Wrong PIN");
            }
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                #region SmartHomeFacade
                Console.WriteLine("Enter key");

                string choice = Console.ReadLine();

                SmartHomeFacade smartHomeFacade = new SmartHomeFacade();

                if (choice == "off")
                {
                    smartHomeFacade.TurnOff();
                }
                else if (choice == "on")
                {
                    smartHomeFacade.TurnOn();
                }
                #endregion
            }


        }
    }
}
