namespace Atividade07.UserServiceTests
{
    public class UserServiceTests
    {
        [Fact]
        public void SaveUser_ReturnsNoException()
        {
            var user = new User("Caua", "cauaclemente@gmail.com");
            var database = new Database();
            var service = new UserService(database);

            var exception = Record.Exception(() => service.SaveUser(user));

            Assert.Null(exception);
        }

        [Fact]
        public void SaveUser_EmptyOrNullName_ReturnsException()
        {
            var userEmpty = new User("", "cauaclemente@gmail.com");
            var userNull = new User(null , "cauaclemente@gmail.com");
            var database = new Database();
            var service = new UserService(database);

            Assert.Throws<ArgumentException> (() => service.SaveUser(userEmpty));
            Assert.Throws<ArgumentException> (() => service.SaveUser(userNull));
        }

        [Fact]
        public void SaveUser_EmptyOrNullEmail_ReturnsException()
        {
            var userEmpty = new User("Caua", "");
            var userNull = new User("Caua" , null);
            var database = new Database();
            var service = new UserService(database);

            Assert.Throws<ArgumentException> (() => service.SaveUser(userEmpty));
            Assert.Throws<ArgumentException> (() => service.SaveUser(userNull));
        }
    }
}

