using System;
using System.Collections.Generic;
using System.Text;

namespace _11_09_19_Exercise2
{


    class Building
    {
        private string Name;
        private string Place;
        private Int16 NOfFloor;
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        public string place
        {
            get
            {
                return this.Place;
            }
            set
            {
                this.Place = value;
            }
        }

        public Int16 noffloor
        {
            get
            {
                return this.NOfFloor;
            }
            set
            {
                this.NOfFloor = value;
            }
        }


    }

    class Mall : Building
    {
        private Int16 NOfVentilator;
        private Int16 NOfShop;
        private Int16 NOfRestaurant;
        private Boolean IsPartyHall;

        public Int16 nofventilator
        {
            get
            {
                return this.NOfVentilator;
            }
            set
            {
                this.NOfVentilator = value;
            }
        }

        public Int16 nofshop
        {
            get
            {
                return this.NOfShop;
            }
            set
            {
                this.NOfShop = value;
            }
        }

        public Int16 nofrestaurant
        {
            get
            {
                return this.NOfRestaurant;
            }
            set
            {
                this.NOfRestaurant = value;
            }
        }

        public Boolean ispartyhall
        {
            get
            {
                return this.IsPartyHall;
            }
            set
            {
                this.IsPartyHall = value;
            }
        }

        public Mall(string name, string place, Int16 noffloor, Int16 nofventilator, Int16 nofshop, Int16 nofrestaurant, Boolean ispartyhall)
        {
            this.name = name;
            this.place = place;
            this.noffloor = noffloor;
            this.NOfVentilator = nofventilator;
            this.NOfShop = nofshop;
            this.NOfRestaurant = nofrestaurant;
            this.IsPartyHall = ispartyhall;
        }



    }

    class Apartment : Building
    {
        private Int16 NOfWing;
        private Int16 NOfFlatePerFloar;
        private string FlatType;
        private Boolean IsGarden;

        public Int16 nofwing
        {
            get
            {
                return this.NOfWing;
            }
            set
            {
                this.NOfWing = value;
            }
        }

        public Int16 nofflateperfloar
        {
            get
            {
                return this.NOfFlatePerFloar;
            }
            set
            {
                this.NOfFlatePerFloar = value;
            }
        }

        public string flattype
        {
            get
            {
                return this.FlatType;
            }
            set
            {
                this.FlatType = value;
            }
        }

        public Boolean isgarden
        {
            get
            {
                return this.IsGarden;
            }
            set
            {
                this.IsGarden = value;
            }
        }

        public Apartment(string name, string place, Int16 noffloor, Int16 nofwing, Int16 nofflateperfloor, string flattype, Boolean isgarden)
        {
            this.name = name;
            this.place = place;
            this.noffloor = noffloor;
            this.NOfWing = nofwing;
            this.NOfFlatePerFloar = nofflateperfloor;
            this.IsGarden = isgarden;
        }


    }

    class Multiplex : Building
    {
        private Int16 NOfScreen;
        private Int16 NOfCurrentMovie;
        private Boolean IsAvaliable3D;

        public Int16 nofscreen
        {
            get
            {
                return this.NOfScreen;
            }
            set
            {
                this.NOfScreen = value;
            }
        }

        public Int16 nofcurrentmovie
        {
            get
            {
                return this.NOfCurrentMovie;
            }
            set
            {
                this.NOfCurrentMovie = value;
            }
        }


        public Boolean isavaliable3d
        {
            get
            {
                return this.IsAvaliable3D;
            }
            set
            {
                this.IsAvaliable3D = value;
            }
        }

        public Multiplex(string name, string place, Int16 noffloor, Int16 nofscreen, Int16 nofcurrentmovie, Boolean isavaliable3d)
        {
            this.name = name;
            this.place = place;
            this.noffloor = noffloor;
            this.NOfScreen = nofscreen;
            this.NOfCurrentMovie = nofcurrentmovie;
            this.IsAvaliable3D = isavaliable3d;
        }
    }


    class Building_PatternMatching
    {
        int nofloor = 0;
        string bname;
        string bplace;

        public void InsertData()
        {
            Console.WriteLine("Enter your building Name:");
            bname = Console.ReadLine();
            Console.WriteLine("Enter Your building place:");
            bplace = Console.ReadLine();
            Console.WriteLine("Enter No of total floor of yur building:");
            nofloor = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int ch = 0;
            Building b1;
            do
            {
                Console.WriteLine("Enter your choice:");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Which type of building you want?");
                        var buildingtype = Console.ReadLine();
                        switch (buildingtype)
                        {
                            case "Multiplex":
                                //b1 = new Multiplex(");
                                break;
                            case "Mall":
                                break;
                            case "Apartment":
                                break;
                            default:
                                Console.WriteLine("plz,enter valid type of building!..");
                                break;
                        }
                        break;
                    case 2:
                        break;
                }
            } while (ch != 0);


        }

        public static void InsertDataObject(object building)
        {
            switch (building)
            {

            }
        }
    }
}
