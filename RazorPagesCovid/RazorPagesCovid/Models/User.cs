using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesCovid.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Display(Name = "First Name"),StringLength(30, MinimumLength = 1),Required ,RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Requires a Capital letter at the begining and can only contain letters, Minimum Length is 1")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name"), StringLength(30, MinimumLength = 1), Required, RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Requires a Capital letter at the begining and can only contain letters, Minimum Length is 1")]
		public string LastName { get; set; }

		[Range(1, 99), Required]
		public int Age { get; set; }

		[Display(Name = "House Number"), Required, Range(1, 9999)]
		public string HouseNumber { get; set; }

		[Display(Name = "Street Name"), Required,StringLength(1000, MinimumLength = 3), RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Requires a Capital letter at the begining and can only contain letters, Minimum Length is 3")]
		public string StreetName { get; set; }

		[Display(Name ="Postcode"), DataType(DataType.PostalCode), Required, RegularExpression(@"^[A-Z]{1,2}[0-9]{1,2} ?[0-9][A-Z]{2}$", ErrorMessage = "Requires the solution to be to have both letters [A-Z] and number [0-9] in the form [WE12 2GH] or [E2 3HF] or [GU2 9PL]")]
		public string PostCode { get; set; }
		

		[Display(Name = "Phone Number"), Required,DataType(DataType.PhoneNumber), RegularExpression(@"\(?\d{4}\)?-? *\d{3}-? *-?\d{4}|^\+(?:[0-9] ?){6,14}[0-9]$", ErrorMessage = "Requires Solution to be in the form of +44XXXXXXXXX or 07XXXXXXXXXX and only contain numbers")]
		public string PhoneNumber { get; set; }

        public string FullName {
            get { return $"{UserId} {FirstName} {LastName}"; }
		}
    }
}