using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentUnitTests.Tests {
    [TestClass()]
    public class CarTests{
        [TestMethod()]
        public void CarTest(){
            Car car = new Car("Mercedes", 700000, "XE3215S");
            Car car2 = new Car("Four", 1, "LE");
            Assert.AreEqual("Mercedes", car.Model);
            Assert.AreEqual(1, car.ID);
            Assert.AreEqual(700000, car.Price);
            Assert.AreEqual("XE3215S", car.LicensePlate);
            Assert.AreEqual("Four", car2.Model);
            Assert.AreEqual("LE", car2.LicensePlate);
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = "S");
            Assert.ThrowsException<ArgumentException>(() => car.LicensePlate = "TooLongX");
            Assert.ThrowsException<ArgumentException>(() => car.Model = "dk2");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = -1);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = 0);
            
        }
        [TestMethod]
        public void ConstructorTest(){
            try{
                Car car = new Car("Ipu", 3000, "SKSS2");
            }
            catch (ArgumentException e){
                Assert.IsNotNull(e.Message);
            }

            try{
                Car car = new Car("SuperCarModel", 0, "SCM3000");
            }
            catch(ArgumentOutOfRangeException rangeException){
                Assert.IsNotNull(rangeException.Message);
            }

            try{
                Car car = new Car("DifferentModel", 2, "X");
            }
            catch (ArgumentException plateTooShort){
                Assert.IsNotNull(plateTooShort.Message);
            }

            try{
                Car car = new Car("AnotherCarModel", 50000, "ToolongX");
            }
            catch (ArgumentException plateTooLong){
                Assert.IsNotNull(plateTooLong.Message);
            }

        }
    }
}       