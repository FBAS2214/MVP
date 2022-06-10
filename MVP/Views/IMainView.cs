using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Views
{
    public interface IMainView
    {
        string Make { get; set; }
        string Model { get; set; }
        string Color { get; set; }
        string Year { get; set; }
        string Transmission { get; set; }


        event EventHandler? AddButtonClicked;
        event EventHandler? ListBoxIndexChanged;
        void SetCarListBindingSource(BindingSource carList);

    }
}
