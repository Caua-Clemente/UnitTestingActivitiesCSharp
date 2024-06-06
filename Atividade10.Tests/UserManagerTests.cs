using System.ComponentModel.Design;
using NSubstitute;

namespace Atividade10.Tests
{
    public class UserManagerTests
    {
        [Fact]
        public void FetchUserInfo_ShouldReturnUser_WhenUserExists()
        {
            var service = Substitute.For<IUserService>();
            var manager = new UserManager(service);

            var user = new User("Caua", "cauaclemente@gmail.com");

            Assert.Equal(user, manager.FetchUserInfo(1));
        }

        [Fact]
        public void FetchUserInfo_ShouldThrowArgumentException_WhenUserDoesNotExist()
        {
            var service = Substitute.For<IUserService>();
            var manager = new UserManager(service);

            Assert.Throws<ArgumentException>(() => manager.FetchUserInfo(1));
        }
    }
}

