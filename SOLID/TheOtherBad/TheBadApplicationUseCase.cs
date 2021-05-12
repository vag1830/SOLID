using System;
using TheOtherBadApplicationDependency;

namespace TheOtherBadApplication
{
    // Imagine the CreateAirport Use Case
    public class TheBadApplicationUseCase
    {
        private readonly IEmailService emailService;

        // The EmailService is injected Using DI.
        public TheBadApplicationUseCase(IEmailService emailService)
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
