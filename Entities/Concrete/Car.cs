using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Bir araba nesnesi oluşturunuz. "Car"

   // Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
    
    public class Car : IEntities
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }    
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
