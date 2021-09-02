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
		public string FirstName { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
		[Display(Name = "Last Name")]
		[StringLength(30)]
		public string LastName { get; set; }

		[Range(16, 99)]
		public int Age { get; set; }

		public string HouseNumber { get; set; }
		public string StreetName { get; set; }

		[DataType(DataType.PostalCode)]
		public string PostCode { get; set; }

		[DataType(DataType.PhoneNumber)]
		public int PhoneNumber { get; set; }

        public string FullName {
            get { return $"{UserId} {FirstName} {LastName}"; }
		}
    }
}