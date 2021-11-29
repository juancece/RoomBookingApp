using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;
using Shouldly;
using System;
using Xunit;

namespace RoomBookingApp.Core
{
    public class RoomBookingRequestProcessorTest
    {
        [Fact]
        public void Should_Return_Room_Booking_Response_With_Request_Values()
        {
            var request = new RoomBookingRequest
            {
                FullName = "Test Name",
                Email = "test@request.com",
                Date = new DateTime(2021, 11, 28)
            };

            var processor = new RoomBookingRequestProcessor();

            var result = processor.BookRoom(request);

            //Assert.NotNull(result);

            //Assert.Equal(request.FullName, result.FullName);
            //Assert.Equal(request.Email, result.Email);
            //Assert.Equal(request.Date, result.Date);

            result.ShouldNotBeNull();
            result.FullName.ShouldBe(request.FullName);
            result.Email.ShouldBe(request.Email);
            result.Date.ShouldBe(request.Date);
        }
    }
}
