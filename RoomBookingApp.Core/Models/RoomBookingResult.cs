using RoomBookingApp.Core.Enums;
using System;

namespace RoomBookingApp.Core.Models
{
    public class RoomBookingResult : RoomBookingBase
    {
        public BookingResultFlag Flag { get; internal set; }
        public int? RoomBookingId { get; set; }
    }
}