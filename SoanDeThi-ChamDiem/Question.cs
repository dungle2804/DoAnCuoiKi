using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoanDeThi_ChamDiem
{
    class Question
    {
        public int ID { get; set; }
        public string content { get; set; }


        public Question() { }

        public override string ToString()
        {
            //return this.ID.ToString() + ". " + this.content.ToString();
            return this.content.ToString();
        }


    }
}
