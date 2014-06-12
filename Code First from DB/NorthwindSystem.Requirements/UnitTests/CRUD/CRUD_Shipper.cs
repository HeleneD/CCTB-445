using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindSystem.BLL;  // for access to my system
using NorthwindSystem.Entities;  // for my EF Entities
using Xunit; // the core for testing
using Xunit.Extensions; // for theories, autorollback etc.



namespace NorthwindSystem.Requirements.UnitTests.CRUD
{
    public class CRUD_Shipper
    {
        [Fact]
        public void Should_Add_Numbers()
        {
            // arrange
            int first = 5, second = 7;
            //act
            int actual = first + second;
            //assert
            Assert.Equal(12, actual);
        }
        [Fact]  // indicats tht this is a test
        [AutoRollback] // undo db changes after tst
        public void Should_Add_Shipper()
        {
            // Arrange
            var sut = new NorthwindManager(); // sut is short for "Situation under test"
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };
            //Act
            var actualId = sut.AddShipper(expected);

            //assert
            Assert.True(actualId > 0);
            Shipper actual = sut.GetShipper(actualId);
            Assert.Equal(expected.CompanyName, actual.CompanyName);
            Assert.Equal(expected.Phone, actual.Phone);
            Assert.Equal(actualId, actual.ShipperID);

        }

        #region Properties for Test Data
        // backing field
        private static IEnumerable<object[]> _CurrentShippers = null;
        public static IEnumerable<object[]> CurrentShippers
        {
            get
            {
                if (_CurrentShippers == null) //lazy loading, null until you need it
                {
                    var controller = new NorthwindManager();
                    var temp = new List<object[]>(); /// empty list

                    foreach (Shipper company in controller.ListShippers())
                    {
                        temp.Add(new object[] { company });
                    }
                    _CurrentShippers = temp;
                }
                return _CurrentShippers;
            }
        }
        #endregion

        [Theory] // indicates that this is a test with (potentially) external data
        [PropertyData("CurrentShippers")]
        [AutoRollback]
        public void Should_Update_Shipper(Shipper existing)
        {
        // arrange
            existing.Phone = "780.999.9999";
            var sut = new NorthwindManager();
             //Act
            sut.UpdateShipper(existing);

            //Assert
            var actual = sut.GetShipper(existing.ShipperID);
            Assert.NotNull(actual);
            Assert.Equal(existing.Phone, actual.Phone);
            Assert.Equal(existing.CompanyName, actual.CompanyName);
        
        }

        [Fact]  // indicates tht this is a test - what indicates this is a method, attributes and  ...
        [AutoRollback] // undo db changes after tst
        public void Should_Delete_Shipper()
        {
            // Arrange
            var sut = new NorthwindManager(); // sut is short for "Situation under test"
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };
            
            expected.ShipperID = sut.AddShipper(expected);
            //Act  - probably a fk constraint
            sut.DeleteShipper(expected);

            //assert
           // 
            Shipper actual = sut.GetShipper(expected.ShipperID);
            Assert.Null(actual);

        }
    }
}
