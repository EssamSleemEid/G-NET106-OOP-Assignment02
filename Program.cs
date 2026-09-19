namespace G_NET106_OOP_Assignment02
{
    internal class Program
    {
        public struct DeliveryAddress
        {
            public string City;
            public string Street;
            public int BuldingNumber;
            public DeliveryAddress(string city, string street, int buldingNumber)
            {
                City = city;
                Street = street;
                BuldingNumber = buldingNumber;
            }
            public string GetFullAddress()
            {
                return $"bulding number : {BuldingNumber}, street : {Street}, city : {City}";
            }
        }

        public class Shipment
        {
            private string description;
            private double weight;
            private decimal deliveryFee;
            private string trackingCode;
            public DeliveryAddress Destination { get; set; }
            public string TrackingCode
            {
                get { return trackingCode; }
            }
            public string Description
            {
                get { return description; }

                set
                {
                    if (value != null)
                    {
                        description = value;
                    }
                }
            }
            public double Weight
            {
                get { return weight; }

                set
                {
                    if (value > 0)
                    {
                        weight = value;
                    }
                }
            }
            public decimal DeliveryFee
            {
                get { return deliveryFee; }

                set
                {

                    if (value > 0)
                    {
                        deliveryFee = value;
                    }
                }
            }
            public decimal EstimatedCost
            {
                get { return DeliveryFee + (decimal)(Weight * 5); }
            }
            public Shipment(string trackingCode)
            {
                this.trackingCode = trackingCode == null ? "unknown" : trackingCode;

                description = "unknown";
                weight = 1;
                deliveryFee = 50;
                Destination = new DeliveryAddress("Cairo", "Unknown Street", 0);
            }
            public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
            {
                this.trackingCode = trackingCode == null ? "Unknown" : trackingCode;
                this.description = description == null ? "Unknown" : description;
                this.weight = weight > 0 ? weight : 1;
                this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
                Destination = destination;
            }
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    deliveryFee = newFee;
                }
            }
            public void PrintShipment()
            {
                Console.WriteLine("trackingCode : " + TrackingCode);
                Console.WriteLine("description : " + Description);
                Console.WriteLine("weight : " + Weight + " kg");
                Console.WriteLine("deliveryFee : " + DeliveryFee);
                Console.WriteLine("Destination : " + Destination.GetFullAddress());
                Console.WriteLine("estimatedCost : " + EstimatedCost + " egy");
            }
        }

        public class DeliveryCenter
        {
            private Shipment[] shipments;

            public DeliveryCenter()
            {
                shipments = new Shipment[10];
            }

            public Shipment this[int index]
            {
                get
                {
                    if (index >= 0 && index < shipments.Length)
                        return shipments[index];

                    return default;
                }

                set
                {
                    if (index >= 0 && index < shipments.Length)
                        shipments[index] = value;
                }
            }

            public Shipment this[string trackingCode]
            {
                get
                {
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i].TrackingCode == trackingCode)
                            return shipments[i];
                    }

                    return default;
                }
            }

            public bool AddShipment(Shipment shipment)
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == null)
                    {
                        shipments[i] = shipment;
                        return true;
                    }
                }

                return false;
            }
        }


        static void Main(string[] args)
        {
            #region Question01 A 
            //a) What is the difference between a class and a struct?

            //class is reference type but struct is value type && class have inheritance but struct does not
            #endregion
            #region Question01 B
            //b) Why are classes more suitable than structs for large applications?

            //bc its support the inheritance and the polymorphism which make it easier to orgnize and reuse
            #endregion

            #region Question02

            #region Part01
            //a) Which class is the parent class?

            //shipment

            //b) Which class is the child class?

            //expressShipment

            //c) What members are inherited by ExpressShipment?

            //tracking code

            //d) Why is inheritance better than duplicating the same code in multiple classes?

            //bc its allow us to reuse the code from parent class without writting the same code again in every child class
            #endregion

            #region Part02


            #endregion
            #endregion
        }
    }
}
