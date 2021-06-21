using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp10.Data;
using WindowsFormsApp10.View;

namespace WindowsFormsApp10.Presenter
{
    class OILPresenter
    {
        private readonly OILContext _db;
        private IOILView _view;

        public MainPresenter(IOILView view)
        {
            _view = view;
            _view.AddButtonClick += ViewAddButtonClick;
            

            _db = new CarContext();
        }


        private void ViewAddButtonClick(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Model = _view.ModelText,
                Vendor = _view.VendorText,
                Year = int.Parse(_view.YearText),
                Color = _view.Colortext,
                Transmission = _view.TransmissionText
            };

            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        private void ViewLoadButtonClick(object sender, EventArgs e)
        {
            var list = _db.Cars.ToList();
            _view.Cars = list;
        }
    }
}
