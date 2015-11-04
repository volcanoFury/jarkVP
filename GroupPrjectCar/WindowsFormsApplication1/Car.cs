using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Car
    {
        private int year;
        private int miles;
        private string brand;
        private string model;
        private string bodyType;
        private string gearBox;
        private string inforamtion;
        private DateTime carAdded;
        private DateTime carLastEdited;
        private string carImage;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string BodyType
        {
            get { return bodyType; }
            set { bodyType = value; }
        }

        public string GearBox
        {
            get { return gearBox; }
            set { gearBox = value; }
        }

        public string Inforamtion
        {
            get { return inforamtion; }
            set { inforamtion = value; }
        }

        public DateTime CarAdded
        {
            get { return carAdded; }
            set { carAdded = value; }
        }

        public DateTime CarLastEdited
        {
            get { return carLastEdited; }
            set { carLastEdited = value; }
        }

        public string CarImage
        {
            get { return carImage; }
            set { carImage = value; }
        }
    }
}
