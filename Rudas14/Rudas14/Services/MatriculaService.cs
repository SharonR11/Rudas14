using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Rudas14.DataContext;
using Rudas14.Models;

namespace Rudas14.Services
{
    internal class MatriculaService
    {
        private readonly AppDbContext _context;

        public MatriculaService() => _context = App.GetContext();

        public bool Create(Matricula item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Matricular.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool CreateRange(List<Matricula> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Matricular.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Matricula> Get()
        {
            return _context.Matricular.ToList();
        }


        public List<Matricula> GetByText(string text)
        {
            return _context.Matricular.Where(x => x.Nombre.Contains(text)).ToList();
        }
    }
}
