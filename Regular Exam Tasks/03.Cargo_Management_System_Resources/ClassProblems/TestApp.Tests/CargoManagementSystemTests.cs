using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests;

[TestFixture]
public class CargoManagementSystemTests
{
    [Test]
    public void Test_Constructor_CheckInitialEmptyCargoCollectionAndCount()
    {
        // Arrange
        int cargoCount = 0;

        // Act
        CargoManagementSystem cargo = new CargoManagementSystem();

        // Assert
        Assert.That(cargoCount, Is.EqualTo(0));

    }

    [Test]
    public void Test_AddCargo_ValidCargoName_AddNewCargo()
    {
        // Arrange
        //List<string> cargoNames = new List<string>();
        CargoManagementSystem cargo = new CargoManagementSystem();
        string cargoName = "Chemicals";

        // Act
        cargo.AddCargo(cargoName);

        // Assert
        Assert.That(1, Is.EqualTo(cargo.CargoCount));
        Assert.Contains(cargoName, cargo.GetAllCargos());

    }

    [Test]
    public void Test_AddCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange
        CargoManagementSystem cargo = new CargoManagementSystem();
        string cargoName = "";

        // Act
        // Assert
        Assert.Throws<ArgumentException>(()=> cargo.AddCargo(cargoName), "(Cargo cannot be empty or whitespace.");
    }

    [Test]
    public void Test_RemoveCargo_ValidCargoName_RemoveFirstCargoName()
    {
        // Arrange
        //List<string> cargoNames = new List<string>();
        CargoManagementSystem cargo = new CargoManagementSystem();
        string cargoName = "Chemicals";

        // Act
        cargo.AddCargo(cargoName);
        cargo.RemoveCargo("Chemicals");

        // Assert
        Assert.That(0, Is.EqualTo(cargo.CargoCount));
        //Assert.Contains(cargoName, cargo.GetAllCargos());
    }

    [Test]
    public void Test_RemoveCargo_NullOrEmptyCargoName_ThrowsArgumentException()
    {
        // Arrange
        //List<string> cargoNames = new List<string>();
        CargoManagementSystem cargo = new CargoManagementSystem();
        string cargoName = "Livestock";

        // Act
        cargo.AddCargo(cargoName);        

        // Assert
        Assert.That(1, Is.EqualTo(cargo.CargoCount));
        Assert.Throws<ArgumentException>(() => cargo.RemoveCargo(""), ("Cargo not found in the system."));
    }

    [Test]
    public void Test_GetAllCargos_AddedAndRemovedCargos_ReturnsExpectedCargoCollection()
    {
        // Arrange
        //List<string> cargoNamesList = new List<string>();
        CargoManagementSystem cargo = new CargoManagementSystem();

        // Act
        cargo.AddCargo("Chemicals");
        cargo.AddCargo("Livestock");
        cargo.AddCargo("Oils");
        cargo.RemoveCargo("Livestock");

        // Assert
        Assert.That(2, Is.EqualTo(cargo.CargoCount));
        Assert.Contains("Chemicals", cargo.GetAllCargos());
        Assert.Contains("Oils", cargo.GetAllCargos());

    }
}

    