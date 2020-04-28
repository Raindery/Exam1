using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Phone
    {
        public int Id { get; set; }

        public string Company { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        public bool HasCamera { get; set; }

        public int Count { get; set; }

        public ICollection<Realization> Phones { get; set; }

        


        public Phone()
        {

        }

        public Phone(string company, string model, string description, decimal cost, bool hasCamera, int count)
        {
            Company = company;
            Model = model;
            Description = description;
            Cost = cost;
            HasCamera = hasCamera;
            Count = count;
        }


        public static Phone CreatePhone(string company, string model, string description, decimal cost, bool hasCamera, int count)
        {
            return new Phone(company, model, description, cost, hasCamera, count);
        }
    }
}
