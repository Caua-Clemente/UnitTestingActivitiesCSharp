using NSubstitute.Core;

namespace Atividade09.Tests
{
    public class ItemCollectionTests
    {
        [Fact]
        public void AddItem_AddItemToList_WhenItemIsValid()
        {
            var itemCollection = new ItemCollection();
            var item = new Item("Nome do item");
            
            itemCollection.AddItem(item);
            Assert.Contains(item, itemCollection.GetItems());
        }

        [Fact]
        public void AddItem_ThrowsArgumentException_WhenItemIsNull()
        {
            var itemCollection = new ItemCollection();

            Assert.Throws<ArgumentException>(()=> itemCollection.AddItem(null));
        }

        [Fact]
        public void RemoveItem_RemoveItemFromList_WhenItemExists()
        {
            var itemCollection = new ItemCollection();
            var item = new Item("Nome do item");
            itemCollection.AddItem(item);
            itemCollection.RemoveItem(item);

            Assert.Equal(new List<Item>(), itemCollection.GetItems());
        }

        [Fact]
        public void RemoveItem_RemoveItemFromPopulatedList_WhenItemExists()
        {
            var itemCollection = new ItemCollection();
            var itemA = new Item("Nome A");
            var itemB = new Item("Nome B");
            var itemC = new Item("Nome C");
            itemCollection.AddItem(itemA);
            itemCollection.AddItem(itemB);
            itemCollection.AddItem(itemC);
            itemCollection.RemoveItem(itemB);

            var collectionAC = new ItemCollection();
            collectionAC.AddItem(itemA);
            collectionAC.AddItem(itemC);
            
            Assert.Equal(collectionAC.GetItems(), itemCollection.GetItems());
        }

        [Fact]
        public void RemoveItem_ThrowsArgumentException_WhenItemDoesNotExist()
        {
            var itemCollection = new ItemCollection();
            var item = new Item("Nome do item");

            Assert.Throws<ArgumentException>(() => itemCollection.RemoveItem(item));
        }

        [Fact]
        public void GetItems_ReturnListOfItems_WhenListHaveItems()
        {
            var itemCollection = new ItemCollection();
            var itemA = new Item("Nome A");
            var itemB = new Item("Nome B");
            var itemC = new Item("Nome C");
            itemCollection.AddItem(itemA);
            itemCollection.AddItem(itemB);
            itemCollection.AddItem(itemC);

            var listOfItems = new List<Item>{itemA, itemB, itemC};
            Assert.Equal(listOfItems, itemCollection.GetItems());
        }

        [Fact]
        public void GetItems_ReturnEmptyList_WhenListIsEmpty()
        {
            var itemCollection = new ItemCollection();
            var listOfItems = new List<Item>();
            Assert.Equal(listOfItems, itemCollection.GetItems());
        }
    }
}

