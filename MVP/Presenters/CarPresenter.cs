using MVP.Models;
using MVP.Repository;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenters
{
    public class CarPresenter
    {
        private readonly ICarRepository _repository;
        private readonly IMainView _view;
        private readonly BindingSource _bindingSource;

        public CarPresenter(ICarRepository repository, IMainView view)
        {
            _repository = repository;
            _view = view;

            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _repository.ReadAll();
            _view.SetCarListBindingSource(_bindingSource);

            _view.AddButtonClicked += _view_AddButtonClicked;
            _view.ListBoxIndexChanged += _view_ListBoxIndexChanged;
        }

        private void _view_ListBoxIndexChanged(object? sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void _view_AddButtonClicked(object? sender, EventArgs e)
        {
            var car = new Car
            {
                Make = _view.Make,
                Model = _view.Model,
                Color = _view.Color,
                Year = int.Parse(_view.Year),
                Transmission = _view.Transmission
            };

            _repository.Create(car);
            _bindingSource.Add(car);
        }
    }
}
