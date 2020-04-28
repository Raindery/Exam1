using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Realization
    {
        public int Id { get; set; }

        public string Clinet { get; set; }

        public int Count { get; set; }

        public DateTime RealizeTime { get; set; }

        public int PhoneId { get; set; }

        public Phone Phone{ get; set; }



        public Realization()
        {

        }


        public Realization(string client, int count, DateTime reealizeTime, int phoneId)
        {
            Clinet = client;
            Count = count;
            RealizeTime = reealizeTime;
            PhoneId = phoneId;

        }

        public static Realization CreateRealization(string client, int count, DateTime reealizeTime, int phoneId)
        {
            return new Realization(client, count, reealizeTime, phoneId);
        }

       
    }
}
