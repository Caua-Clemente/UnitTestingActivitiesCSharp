namespace Atividade14.Tests
{
    public class EventHandlerTests
    {
        [Fact]
        public void HandleEvent_SendEmail_WhenRequestIsValid()
        {
            var service = new EmailService();
            var handler = new EventHandler(service);
            var exception = Record.Exception(() => handler.HandleEvent("Email Content"));

            Assert.Null(exception);
        }


        //Dá erro
        [Fact]
        public void HandleEvent_ThrowArgumentException_WhenBodyContentIsEmpty()
        {
            var service = new EmailService();
            var handler = new EventHandler(service);

            Assert.Throws<ArgumentException>(() => handler.HandleEvent(""));
        }
    }
}

