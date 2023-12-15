using Rudas14.Models;
using Rudas14.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Rudas14.ViewModels
{
    public class ViewModelMatricula : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Matricula> matricular;
        public List<Matricula> Matricular
        {
            get { return this.matricular; }
            set { SetValue(ref this.matricular, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelMatricula()
        {

            SearchCommand = new Command(() =>
            {
                MatriculaService service = new MatriculaService();
                Matricular = service.GetByText(Filter);
                if (Matricular.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }


    }
}
