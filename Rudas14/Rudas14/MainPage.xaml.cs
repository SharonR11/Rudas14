using Rudas14.Models;
using Rudas14.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Rudas14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            List<Matricula> people = new List<Matricula>();

            for (int i = 0; i < 3; i++)
                people.Add(new Matricula { Nombre = txtNombre.Text,
                    Fecha = DatePicker.Date, Curso = txtCurso.Text, Genero = txtGenero.Text });

            //service.Create(new Person { LastName = txtLastName.Text, FirstName = txtName.Text });

            service.CreateRange(people);


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            lvMatricular.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            MatriculaService service = new MatriculaService();
            lvMatricular.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
