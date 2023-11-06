using System;
using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities
{
	public class Order:BaseEntitiy
	{
		public Guid CustomerId { get; set; }
		public string Description { get; set; }
		public string Address { get; set; }

		public ICollection<Product>	Products { get; set; } //Çoktan 1 e ve  çoka ilişkidecollection ref.
		public Customer Customer { get; set; } // 1 cutomer olabilir
	}
}

