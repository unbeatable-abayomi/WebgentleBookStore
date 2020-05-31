using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebgentleBookStore.Data;
using WebgentleBookStore.Models;

namespace WebgentleBookStore.Repository
{
    public class CarRespositroy
    {
        private readonly BookStoreContext _bookStoreContext = null;
        public CarRespositroy(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }



        public int AddNewCar(CarModel model )
        {
            var newCar = new Cars()
            {
                Name = model.Name,
                Model = model.Model,
                Color = model.Color,
                Price = model.Price,
                Millage = model.Millage,

            };
            _bookStoreContext.Cars.Add(newCar);
            _bookStoreContext.SaveChanges();
            return newCar.Id;
        }
    }
}
