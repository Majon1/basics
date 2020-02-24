using System;

namespace exercise_96
{
    private class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfSeats)
        {
            this.code = classCode;
            this.seats = 0;
        }
    }
}