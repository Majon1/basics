namespace Exercise
{
    using System;
    
    public class TemperatureSensor : Sensor
    {
        private bool isThisOn;

        public bool IsOn()
        { 
        return this.isThisOn;
        }
  
        public void SetOn()
        {
            this.isThisOn = true;
        }

        public void SetOff()
        {
            this.isThisOn = false;
        }

        public int Read()
        {   
            if (!this.isThisOn)
            {
                throw new InvalidOperationException("Sensor is off.");
            }
            
                Random number = new Random();
                int integer = number.Next(-30, 31);
                return integer;
            }
            
        }
    }
