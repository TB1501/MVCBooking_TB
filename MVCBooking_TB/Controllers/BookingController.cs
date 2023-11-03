using Microsoft.AspNetCore.Mvc;
using MVCBooking_TB.Models;

namespace MVCBooking_TB.Controllers
{
	public class BookingController : Controller
	{
		public static List<HotelBooking> bookings = new List<HotelBooking>();
		public IActionResult Index()
		{
			return View(bookings);
		}

		public IActionResult Create()
		{
			HotelBooking booking = new HotelBooking();
			return View(booking);
		}

		public IActionResult CreateBooking(HotelBooking booking)
		{
			bookings.Add(booking);
			return RedirectToAction("Index");
		}
	}
}
