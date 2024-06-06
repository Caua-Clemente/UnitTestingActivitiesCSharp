namespace Atividade11.Tests
{
    public class CustomSorterTests
    {
        [Fact]
        public void SortDescending_ReturnsDescendingList_WhenListIsUnsorted()
        {
            var sorter = new CustomSorter();
            var unsortedList = new List<int>{1, 5, 3, 100, 0, 99, 98};
            var sortedList = new List<int>{100, 99, 98, 5, 3, 1, 0};

            Assert.Equal(sortedList, sorter.SortDescending(unsortedList));
        }

        [Fact]

        public void SortDescending_ReturnsDescendingList_WhenListContainsNegatives()
        {
            var sorter = new CustomSorter();
            var unsortedList = new List<int>{-1, 5, 3, -100, 0, 99, 98, 1};
            var sortedList = new List<int>{99, 98, 5, 3, 1, 0, -1, -100};

            Assert.Equal(sortedList, sorter.SortDescending(unsortedList));
        }


        /* OBS
            Nessa parte pra baixo eu não sei é o correto ou não. Sei que estes
            testes darão erro porque não tem nada de ArgumentException no 
            Custom sorter, mas suponho que como todas as atividades até o momento
            utilizaram argument exception, então esse deveria ser o padrão? E
            no caso, o CustomSorter está errado por não utilizar um argument 
            exception para os casos de lista nula ou vazia? De qualquer forma,
            fiz os testes (que darão erro).
        */
        [Fact]
        public void SortDescending_ThrowsArgumentException_WhenListIsNull()
        {
            var sorter = new CustomSorter();

            Assert.Throws<ArgumentException>(() => sorter.SortDescending(null));
        }

        [Fact]
        public void SortDescending_ThrowsArgumentException_WhenListisEmpty()
        {
            var sorter = new CustomSorter();
            var emptyList = new List<int>();

            Assert.Throws<ArgumentException>(() => sorter.SortDescending(emptyList));
        }
    }    
}

