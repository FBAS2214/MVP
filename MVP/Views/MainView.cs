using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            btn_Add.Click += (s, e) => { AddButtonClicked?.Invoke(this, EventArgs.Empty); };
            listBox_Cars.SelectedIndexChanged += (s, e) => { ListBoxIndexChanged?.Invoke(s, e); };
        }

        public string Make
        {
            get { return txt_Make.Text; }
            set { txt_Make.Text = value; }
        }
        public string Model
        {
            get { return txt_Model.Text; }
            set { txt_Model.Text = value; }
        }
        public string Color
        {
            get { return txt_Color.Text; }
            set { txt_Color.Text = value; }
        }
        public string Year
        {
            get { return txt_Year.Text; }
            set { txt_Year.Text = value; }
        }
        public string Transmission
        {
            get { return txt_Transmission.Text; }
            set { txt_Transmission.Text = value; }
        }


        public event EventHandler? AddButtonClicked;
        public event EventHandler? ListBoxIndexChanged;

        public void SetCarListBindingSource(BindingSource carList)
        {
            listBox_Cars.DataSource = carList;
        }
    }
}
