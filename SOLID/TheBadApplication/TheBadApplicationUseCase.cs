using System;
using TheBadApplicationDependency;

namespace TheBadApplication
{
    // Imagine the CreateAirport Use Case
    public class TheBadApplicationUseCase
    {
        private readonly EmailService emailService;

        // The EmailService is injected Using DI.
        public TheBadApplicationUseCase(EmailService emailService)
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
