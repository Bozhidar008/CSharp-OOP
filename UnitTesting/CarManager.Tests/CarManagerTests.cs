namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void SetUp()
        {
            this.car = new Car("Make", "Model", 10, 20);
        }

        [Test]
        [TestCase("","Model", 10, 20)]
        [TestCase(null,"Model", 10, 20)]
        [TestCase("Make","", 10, 20)]
        [TestCase("Make",null, 10, 20)]
        [TestCase("Make","Model", 0, 20)]
        [TestCase("Make","Model", -10, 20)]
        [TestCase("Make","Model", 10, 0)]
        [TestCase("Make","Model", 10, -20)]
        public void Ctor_ThrowException_WhenDataIsNotValid(string make, string model, double fuelConsuption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(()=> new Car(make, model, fuelConsuption, fuelCapacity));
        }

        [Test]
        public void Ctor_CreateCar_WhenDataIsValid()
        {
            string make = "Make";
            string model = "Model";
            double fuelConsumpsion = 10;
            double fuelCapacity = 20;

            Car car = new Car(make,model, fuelConsumpsion, fuelCapacity);

            Assert.That(car.Make, Is.EqualTo(make));
            Assert.That(car.Model, Is.EqualTo(model));
            Assert.That(car.FuelConsumption, Is.EqualTo(fuelConsumpsion));
            Assert.That(car.FuelCapacity, Is.EqualTo(fuelCapacity));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-20)]
        public void Refuel_ThrowException_WhenIsNegativeOrZero(double fuel)
        {
            Assert.Throws<ArgumentException>(()=>car.Refuel(fuel));
        }

        [Test]
        public void Refuel_IncreaseFuel_WhenValidAmount()
        {
            this.car.Refuel(10);

            Assert.That(this.car.FuelAmount, Is.EqualTo(10));
        }

        [Test]
        public void Refuel_SetFuelToCapacity_WhenCapacityIsExceeded()
        {
           
            this.car.Refuel(500);

            Assert.That(this.car.FuelAmount, Is.EqualTo(20));
        }

        [Test]
        public void Drive_ThrowException_WhenFuelIsZero()
        {
            

            Assert.Throws<InvalidOperationException>(()=>this.car.Drive(50));
        }

        [Test]
        public void Drive_DecreaseFuel_WhenValidDistance()
        {
            this.car.Refuel(20);
            car.Drive(100);

            Assert.That(this.car.FuelAmount, Is.EqualTo(20 - this.car.FuelConsumption));
        }

        [Test]
        public void Drive_DecreaseFuelAmountToZero_WhenRequiredFuelIsEqualToFuelAmount()
        {
            this.car.Refuel(20);
            double distance = this.car.FuelCapacity * this.car.FuelConsumption;

            this.car.Drive(distance);
            Assert.That(this.car.FuelAmount, Is.EqualTo(0));
        }

        [Test]
        public void FuelAmount_ThrowException_WhenNegativeValue()
        {
            Assert.Throws<ArgumentException>(() => this.car.Refuel(-20));
        }

        [Test]
        public void FuelAmount_ThrowException_WhenNegative()
        {
            this.car.Refuel(this.car.FuelCapacity);
            double beforeDrive = this.car.FuelAmount;

            this.car.Drive(100);
            double afterDrive = this.car.FuelAmount;

            Assert.That(afterDrive, Is.LessThan(beforeDrive));
        }
    }
}