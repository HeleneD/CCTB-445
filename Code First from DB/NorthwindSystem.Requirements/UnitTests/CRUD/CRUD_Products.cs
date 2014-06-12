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
    class CRUD_Products
    {
          //[Fact]
        //public void Should_Add_Numbers()
        //{
        //    // arrange
        //    int first = 5, second = 7;
        //    //act
        //    int actual = first + second;
        //    //assert
        //    Assert.Equal(12, actual);
        //}
        //[Fact]  // indicats tht this is a test
        //[AutoRollback] // undo db changes after tst
        //public void Should_Add_Product()
        //{
        //    // Arrange
        //    var sut = new NorthwindManager(); // sut is short for "Situation under test"
        //    var expected = new Product()
        //    {
        //        CompanyName = "Montgomery Scott's Transporter Service",
        //        Phone = "780.555.1212"
        //    };
        //    //Act
        //    var actualId = sut.AddProduct(expected);

        //    //assert
        //    Assert.True(actualId > 0);
        //    Product actual = sut.GetProduct(actualId);
        //    Assert.Equal(expected.CompanyName, actual.CompanyName);
        //    Assert.Equal(expected.Phone, actual.Phone);
        //    Assert.Equal(actualId, actual.ProductID);

        //}

        //#region Properties for Test Data
        //// backing field
        //private static IEnumerable<object[]> _CurrentProducts = null;
        //public static IEnumerable<object[]> CurrentProducts
        //{
        //    get
        //    {
        //        if (_CurrentProducts == null) //lazy loading, null until you need it
        //        {
        //            var controller = new NorthwindManager();
        //            var temp = new List<object[]>(); /// empty list

        //            foreach (Product company in controller.ListProducts())
        //            {
        //                temp.Add(new object[] { company });
        //            }
        //            _CurrentProducts = temp;
        //        }
        //        return _CurrentProducts;
        //    }
        //}
        //#endregion

        //[Theory] // indicates that this is a test with (potentially) external data
        //[PropertyData("CurrentProducts")]
        //[AutoRollback]
        //public void Should_Update_Product(Product existing)
        //{
        //// arrange
        //    existing.Phone = "780.999.9999";
        //    var sut = new NorthwindManager();
        //     //Act
        //    sut.UpdateProduct(existing);

        //    //Assert
        //    var actual = sut.GetProduct(existing.ProductID);
        //    Assert.NotNull(actual);
        //    Assert.Equal(existing.Phone, actual.Phone);
        //    Assert.Equal(existing.CompanyName, actual.CompanyName);
        
        //}

        //[Fact]  // indicates tht this is a test - what indicates this is a method, attributes and  ...
        //[AutoRollback] // undo db changes after tst
        //public void Should_Delete_Product()
        //{
        //    // Arrange
        //    var sut = new NorthwindManager(); // sut is short for "Situation under test"
        //    var expected = new Product()
        //    {
        //        CompanyName = "Montgomery Scott's Transporter Service",
        //        Phone = "780.555.1212"
        //    };
            
        //    expected.ProductID = sut.AddProduct(expected);
        //    //Act  - probably a fk constraint
        //    sut.DeleteProduct(expected);

        //    //assert
        //   // 
        //    Product actual = sut.GetProduct(expected.ProductID);
        //    Assert.Null(actual);

        //}
    //}
    }
}
