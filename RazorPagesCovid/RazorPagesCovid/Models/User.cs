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
		[StringLength(30)]
		[Required]
		public string FirstName { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
		[Display(Name = "Last Name")]
		[StringLength(30)]
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
		[StringLength(100)]
		[Display(Name = "Street Name")]
		public string StreetName { get; set; }

		[DataType(DataType.PostalCode)]
		[Required]
		public string PostCode { get; set; }

		[DataType(DataType.PhoneNumber)]
		[Required]
		[Display(Name = "Phone Number")]
		public int PhoneNumber { get; set; }


	}
}