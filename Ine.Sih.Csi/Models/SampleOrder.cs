using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ine_Sih_Csi.Models {
    public class SampleOrder {
        public int OrderID { get; set; }
        [DisplayName("Fecha de orden")]
        public DateTime OrderDate { get; set; }
        public string CustomerID { get; set; }
        [Required(ErrorMessage = "{0} es un campo requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El primer nombre debe tener un mínimo de 3 caracteres y un máximo de 50.")]
        [DataType(DataType.Text)]
        public string CustomerName { get; set; }
        [Required]
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}
