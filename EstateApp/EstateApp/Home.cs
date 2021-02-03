using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EstateApp.Enums;

namespace EstateApp
{
    public class Home
    {
        public int Room { get; set; }
        public int Lounge { get; set; }
        public string RoomCount
        {
            get
            {
                return Room + "+" + Lounge;
            }
        }
        public TypeOfHeating HeatingType { get; set; }
        public HomeTypeEnum HomeType { get; set; }
        public HomeStatus StatusHome { get; set; }
        public decimal Price { get; set; }

        private int _HomeAdvert;
        public int HomeAdvert
        {
            get
            {
                return _HomeAdvert;
            }
            set
            {
                if (value < 0)
                {
                    _HomeAdvert = 0;
                }
                else
                {
                    _HomeAdvert = value;
                }
            }
        }


    }

    public class PrivateHouse : Home
    {
        public bool Garden { get; set; }
        public bool Garage { get; set; }

        public PrivateHouse() { }
        public PrivateHouse(int room, int lounge, TypeOfHeating heating, HomeStatus homestatus, int field, decimal price)
        {
            Room = room;
            Lounge = lounge;
            HeatingType = heating;
            HomeType = HomeTypeEnum.Müstakil;
            StatusHome = homestatus;
            HomeAdvert = field;
            Price = price;
        }
        public PrivateHouse(string[] PrivateH)
        {
            if (PrivateH[3] == "Müstakil")
            {
                Room = Convert.ToInt32(PrivateH[0]);
                Lounge = Convert.ToInt32(PrivateH[1]);
                HeatingType = (TypeOfHeating)Enum.Parse(typeof(TypeOfHeating), PrivateH[2]);
                HomeType = HomeTypeEnum.Müstakil;
                StatusHome = (HomeStatus)Enum.Parse(typeof(HomeStatus), PrivateH[4]);
                HomeAdvert = Convert.ToInt32(PrivateH[5]);
                Price = Convert.ToInt32(PrivateH[6]);
                Garage = Convert.ToBoolean(PrivateH[7]);
                Garden = Convert.ToBoolean(PrivateH[8]);
            }
        }
    }

    public class SummeryHouse : Home
    {
        public bool Pool { get; set; }
        public HouseView View { get; set; }

        public SummeryHouse()   {   }

        public SummeryHouse(string[] SummeryH)
        {
            if (SummeryH[3] == "Yazlık")
            {
                Room = Convert.ToInt32(SummeryH[0]);
                Lounge = Convert.ToInt32(SummeryH[1]);
                HeatingType = (TypeOfHeating)Enum.Parse(typeof(TypeOfHeating), SummeryH[2]);
                HomeType = HomeTypeEnum.Yazlık;
                StatusHome = (HomeStatus)Enum.Parse(typeof(HomeStatus), SummeryH[4]);
                HomeAdvert = Convert.ToInt32(SummeryH[5]);
                Price = Convert.ToInt32(SummeryH[6]);
                Pool = Convert.ToBoolean(SummeryH[7]);
                View = (HouseView)Enum.Parse(typeof(HouseView), SummeryH[8]);
            }
        }
    }

    public class ApartmentHouse : Home
    {
        public int Floor { get; set; }
        public bool Balcony { get; set; }

        public ApartmentHouse() { }

        public ApartmentHouse(string[] ApartmentH)
        {
            if (ApartmentH[3] == "Apartman")
            {
                Room = Convert.ToInt32(ApartmentH[0]);
                Lounge = Convert.ToInt32(ApartmentH[1]);
                HeatingType = (TypeOfHeating)Enum.Parse(typeof(TypeOfHeating), ApartmentH[2]);
                HomeType = HomeTypeEnum.Apartman;
                StatusHome = (HomeStatus)Enum.Parse(typeof(HomeStatus), ApartmentH[4]);
                HomeAdvert = Convert.ToInt32(ApartmentH[5]);
                Price = Convert.ToInt32(ApartmentH[6]);
                Balcony = Convert.ToBoolean(ApartmentH[7]);
                Floor = Convert.ToInt32(ApartmentH[8]);
            }
        }

    }
}
