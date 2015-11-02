using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Car
    {
        private int carID;

        public int CarID
        {
            get { return carID; }
            set { carID = value; }
        }
        private int year;
        private int miles;
        private string brand;
        private string model;
        private string bodyType;
        private string gearBox;
        private string inforamtion;
        private DateTime carAdded; 
        private DateTime carLasrEdited;
    }
}
