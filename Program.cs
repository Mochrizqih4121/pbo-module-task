    using System;

    class Laptop
    {
        public string merk;
        public string tipe;
        public string Vga;
        public string processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "ASUS";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
            Vga = "Merk Vga = Nvidia";
            merk = "Merk Processor = Intel";
            processor = "Tipe Processor = Core i5";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER()
        {
            merk = "ACER";
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
            Vga = "AMD";
            processor = "Core i7";
            merk = "ACER";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
            Vga = "AMD";
            processor = "Ryzen";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }

    class Processor
    {
        public string merk;
        public string tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }

    class Corei3 : Intel
    {
        public Corei3()
        {
            tipe = "Core i3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5()
        {
            tipe = "Core i5";
        }
    }

    class Corei7 : Intel
    {
        public Corei7()
        {
            tipe = "Core i7";
        }
    }

    class Processor1
    {
        public string merk;
        public string tipe;
    }

    class AMD1 : Processor1
    {
        public AMD1()
        {
            merk = "AMD";
        }
    }

    class Ryzen : AMD1
    {
        public Ryzen() 
        {
            tipe = "RAYZEN";
        }
    }

    class Athlon : AMD1
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }

    class Vga
    {
        public string merk;
    }

    class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }

    class program 
    {
        public static void Main(string[] args)
        {
            Vivobook Laptop1 = new Vivobook();
            Laptop1.Ngoding();
            Console.WriteLine(Laptop1.Vga);
            Console.WriteLine(Laptop1.merk);
            Console.WriteLine(Laptop1.processor);
            Console.WriteLine("\n");

            Laptop Laptop2 = new IdeaPad();
            Laptop2.LaptopDinyalakan();
            Laptop2.LaptopDimatikan();
            Console.WriteLine("\n");

            Predator predator = new Predator();
            predator.BermainGame();
            Console.WriteLine("\n");

            ACER acer = new Predator();
            predator.BermainGame();
            Console.WriteLine("\n");
        }
    }
