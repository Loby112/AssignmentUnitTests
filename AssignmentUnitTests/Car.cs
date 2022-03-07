namespace AssignmentUnitTests
{
    public class Car {
        private string _licensePlate;
        private string _model;
        private double _price;
        private static int _nextID = 1;

        public Car(string model, double price, string licensePlate){
            ID = _nextID;
            _nextID++;
            Model = model;
            Price = price;
            LicensePlate = licensePlate;
        }

        public int  ID { get; }

        public string Model{
            get => _model;
            set{
                if (value.Length < 4){
                    throw new ArgumentException("Model name must be at least 4 characters");
                }
                _model = value;
            }
        }

        public double Price{
            get => _price;
            set{
                if (value <= 0){
                    throw new ArgumentOutOfRangeException("Price must be higher than 0");
                }
                _price = value;
            }
        }

        public string LicensePlate{ 
            get => _licensePlate;
            set{
                if (value.Length < 2 || value.Length > 7){
                    throw new ArgumentException("License plate must be 2 or more characters and max 7");
                }
                _licensePlate = value;
            }
        }
    }
}   