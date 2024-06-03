namespace PCCO104L.Activity._8_1_
{
    using System;

    namespace Program
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                SuperCar Bugatti = new SuperCar(304, "Bugatti Chiron", "7 Speed");
                Bugatti.Super();

                SportsCar Porsche = new SportsCar(205, "Porsche 911 Carrera", "7 Speed");
                Porsche.Sports();

                FaveCar Lancer = new FaveCar(160, "Lancer Evo X", "6 Speed");
                Lancer.Fave();

                Pickup RamTrx = new Pickup(160, "Ram 1500 Trx", "8 Speed");
                RamTrx.Truck();

                BigBike Kawasaki = new BigBike(260, "Kawasaki Ninja Z1000", "6 Speed");
                Kawasaki.Big();

                JDM Nissan = new JDM(180, "Nissan GT-R R34 ", "6 Speed");
                Nissan.JDMsss();
            }
        }

        public abstract class Car
        {
            private string CarModel { get; set; }
            public string Speed { get; set; }
            private double Top { get; set; }

            public Car() { }

            public Car(double top)
            {
                Top = top;
            }
            public Car(double top, string carModel) : this(top)
            {
                CarModel = carModel;
            }
            public Car(double top, string carModel, string speed) : this(top, carModel)
            {
                Speed = speed;
            }

            protected string GetCarInfo()
            {
                return $"{Speed} - {CarModel} - {Top} Top Speed";
            }
        }

        public class SuperCar : Car
        {
            public SuperCar() { }

            public SuperCar(double top) : base(top) { }

            public SuperCar(double top, string carModel) : base(top, carModel) { }

            public SuperCar(double top, string carModel, string speed) : base(top, carModel, speed) { }

            public void Super()
            {
                Console.WriteLine(GetCarInfo());
            }
        }

        public class SportsCar : Car
        {
            public SportsCar() { }

            public SportsCar(double top) : base(top) { }

            public SportsCar(double top, string carModel) : base(top, carModel) { }

            public SportsCar(double top, string carModel, string speed) : base(top, carModel, speed) { }

            public void Sports()
            {
                Console.WriteLine(GetCarInfo());
            }
        }

        public class FaveCar : Car
        {
            public FaveCar() { }

            public FaveCar(double top) : base(top) { }

            public FaveCar(double top, string carModel) : base(top, carModel) { }

            public FaveCar(double top, string carModel, string speed) : base(top, carModel, speed) { }

            public void Fave()
            {
                Console.WriteLine(GetCarInfo());
            }
        }

        public class Pickup : Car
        {
            public Pickup() { }

            public Pickup(double top) : base(top) { }

            public Pickup(double top, string carModel) : base(top, carModel) { }

            public Pickup(double top, string carModel, string speed) : base(top, carModel, speed) { }

            public void Truck()
            {
                Console.WriteLine(GetCarInfo());
            }
        }

        public class BigBike : Car
        {
            public BigBike() { }

            public BigBike(double top) : base(top) { }

            public BigBike(double top, string carModel) : base(top, carModel) { }

            public BigBike(double top, string carModel, string speed) : base(top, carModel, speed) { }

            public void Big()
            {
                Console.WriteLine(GetCarInfo());
            }
        }

        public class JDM : Car
        {
            public JDM() { }

            public JDM(double top) : base(top) { }

            public JDM(double top, string carModel) : base(top, carModel) { }

            public JDM(double top, string carModel, string speed) : base(top, carModel, speed) { }

            public void JDMsss()
            {
                Console.WriteLine(GetCarInfo());
            }
        }
    }
}
