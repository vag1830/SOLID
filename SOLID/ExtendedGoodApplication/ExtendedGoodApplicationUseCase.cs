using System;
using ExtendedGoodApplication.NotificationService;

namespace ExtendedGoodApplication
{
    // Imagine the CreateAirport Use Case
    public class ExtendedGoodApplicationUseCase
    {
        private readonly INotificationService notificationService;

        public ExtendedGoodApplicationUseCase(INotificationService notificationService)
        {
            this.notificationService = notificationService;
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
            notificationService.Send();
        }
    }
}
