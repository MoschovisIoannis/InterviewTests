using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreEFProject.DataAccessLibrary.Models
{
	public class Customer
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
        public Guid Id { get; set; }

		[Required]
		[Column("CompanyName", TypeName = "varchar(100)")]
		public string CompanyName { get; set; }

		[Required]
		[Column("ContactName", TypeName = "varchar(100)")]
		public string ContactName { get; set; }

		[Required]
		[Column("Address", TypeName = "varchar(100)")]
		public string Address { get; set; }

		[Required]
		[Column("City", TypeName = "varchar(100)")]
		public string City { get; set; }

		[Required]
		[Column("Region", TypeName = "varchar(100)")]
		public string Region { get; set; }

		[Required]
		[Column("PostalCode", TypeName = "varchar(5)")]
		[MaxLength(5)]
		public string PostalCode { get; set; }

		[Required]
		[Column("Country", TypeName = "varchar(100)")]
		public string Country { get; set; }

		[Required]
		[Column("Phone", TypeName = "varchar(13)")]
		[MaxLength(13)]
		public string Phone { get; set; }
	}
}
