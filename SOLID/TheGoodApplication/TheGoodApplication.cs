using System;
using TheGoodApplication.EmailService;

namespace TheGoodApplication
{
    // Imagine the CreateAirport Use Case
    public class TheGoodApplicationUseCase
    {
        private readonly IEmailService emailService;

        public TheGoodApplicationUseCase(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void Execute()
        {
            try
            {
                // do some business logic here ...
            }
            catch (Exception)
            {
                throw;
            }

            // Send a notification when done
            emailService.SendEmail();
        }
    }
}
