using System;
using Xunit;
using System.Collections.Generic;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        public Shelter newShelter = new Shelter();

        [Fact]
        public void ShelterClassContainShelterList()
        {
            Assert.NotNull(newShelter.ShelterList);
        }

        [Fact]
        public void ShelterList_Is_Empty_By_Default()
        {
            Assert.Empty(newShelter.ShelterList);
        }

        [Fact]
        public void ShelterList_Can_Have_Items_Added_Using_AddToShelter()
        {
            Pet newPet = new Pet();
            newShelter.AddToShelter(newPet);

            // Assert
            Assert.NotEmpty(newShelter.ShelterList);
        }

        [Fact]
        public void ShelterList_Can_Have_Items_Removed_Using_RemoveFromShelter()
        {
            Pet newPet = new Pet();
            newShelter.AddToShelter(newPet);
            newShelter.RemoveFromShelter(newPet);
            // Assert
            Assert.Empty(newShelter.ShelterList);
        }
    }
}

