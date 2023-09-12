using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace H1_robots.Model
{
    internal class Robot
    {
        // How did i interpret this assignment?
        // There are 3 types of robot: Those with a "None" chip, and those with a "RX" chip and those with a "QT" chip.
        // Those with "None" chips are small robots. They can only clean the floors.
        // Those with "RX" can clean windows, as well as clean the floors.
        // Those with "QT" can change tires and clean floors.
        // Robots are by default white, however they can be painted. If they get painted, they will not run on batteries.
        // Some robots have Wi-Fi, these are picked by random.
        // Batteries have a capacity of maximum 255 and minimum 0.
        // The robots that can clean windows, have a soap container which has a maximum capacity of 2,3 liters.
        // The cleaning robots cannot have batteries, but they can have any color.
        // Not all robots can have wheels, however those with a "None" chip, cannot have wheels.

        private string _chip; 
        private Color _color; 
        private bool _hasWiFi; 
        private bool _hasBattery; 
        private int _wheels;

        public Robot()
        {
            _chip = string.Empty;
            _color = Color.White;
            _hasWiFi = false;
            _hasBattery = true;
            _wheels = 0;
        }

        public Robot(bool hasWiFI) : this()
        {
            _hasWiFi = hasWiFI;
        }

        Robot(Color color) : this()
        {
            _color = color;
        }

        Robot(string chip) : this()
        {
            _chip = chip;
        }

        Robot(int wheels, string chip) : this(chip)
        {
            _wheels = wheels;
        }

        Robot(Color color, bool hasBattery) : this(color)
        {
            _hasBattery = hasBattery;
        }
    }
}
