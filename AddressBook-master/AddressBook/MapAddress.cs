using System;
using System.Drawing;
using System.Net;

namespace AddressBook
{
	static class MapAddress
	{
		/// <summary>
		/// Get an image from Google's Maps API
		/// </summary>
		/// <param name="address"></param>
		/// <param name="city"></param>
		/// <param name="state"></param>
		/// <returns></returns>
		public static Image GetImage(String address, String city, US_State state)
		{
			String fullAddress = String.Format("{0}, {1}, {2}", address, city, state.Abbreviation);
			String requestUri = String.Format("http://maps.googleapis.com/maps/api/staticmap?center={0}&zoom=17&size=400x400&sensor=false", Uri.EscapeDataString(fullAddress));

			WebRequest request = WebRequest.Create(requestUri);

			return Image.FromStream(request.GetResponse().GetResponseStream());
		}
	}
}
