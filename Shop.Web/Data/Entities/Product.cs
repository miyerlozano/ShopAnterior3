

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

		[Display(Name = "Productos y Servicios")]
		[MaxLength(100,ErrorMessage = "El campo {0} solo puede contener 50 caracteres de longitud.")]
		[Required]
		public string ProSer { get; set; }

		[Display(Name = "Descripcion")]
		public string Descripcion { get; set; }

		[Display(Name = "Imagen")]
		public string ImageUrl { get; set; }

		[Display(Name = "Direccion")]
		public string Direccion { get; set; }

		[Display(Name = "Contacto")]
		public string Contacto { get; set; }

		[Display(Name = "Presentacion")]
		public bool Presentacion { get; set; }

		
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
