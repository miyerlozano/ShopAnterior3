﻿

namespace Shop.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
	using System.ComponentModel.DataAnnotations;



	public class Product:IEntity
    {
		public int Id { get; set; }

		[MaxLength(50,ErrorMessage = "El campo {0} solo puede contener 50 caracteres de longitud.")]
		[Required]
		public string Name { get; set; }

		[DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
		public decimal Price { get; set; }

		[Display(Name = "Image")]
		public string ImageUrl { get; set; }

		[Display(Name = "Last Purchase")]
		public DateTime? LastPurchase { get; set; }

		[Display(Name = "Last Sale")]
		public DateTime? LastSale { get; set; }

		[Display(Name = "Is Availabe?")]
		public bool IsAvailabe { get; set; }

		[DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
		public double Stock { get; set; }

		public User User { get; set; }


		public string ImageFullPath
		{
			get {
				if(string.IsNullOrEmpty(this.ImageUrl))
				{
					return null;
				}

				return $"https://shopzulu.azurewebsites.net{this.ImageUrl.Substring(1)}";

			}
		
		
		}

	}
}
