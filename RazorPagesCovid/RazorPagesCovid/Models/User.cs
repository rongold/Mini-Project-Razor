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

		[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
		[Display(Name = "First Name")]
		[StringLength(30, MinimumLength = 3)]
		[Required]
		public string FirstName { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
		[Display(Name = "Last Name")]
		[StringLength(30, MinimumLength = 3)]
		[Required]
		public string LastName { get; set; }

		[Range(1, 99)]
		[Required]
		public int Age { get; set; }
		[Range(1, 9999)]
		[Required]
		[Display(Name = "House Number")]
		public string HouseNumber { get; set; }
		[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
		[Required]
		[StringLength(100, MinimumLength = 3)]
		[Display(Name = "Street Name")]
		public string StreetName { get; set; }

		[DataType(DataType.PostalCode)]
		[Required]
		[RegularExpression(@"^[A-Z]{1,2}[0-9]{1,2} ?[0-9][A-Z]{2}$")]
		public string PostCode { get; set; }
		
		[DataType(DataType.PhoneNumber)]
		[Required]
		[Display(Name = "Phone Number")]
		[RegularExpression(@"\(?\d{4}\)?-? *\d{3}-? *-?\d{4}|^\+(?:[0-9] ?){6,14}[0-9]$")]
		public string PhoneNumber { get; set; }


	}
}