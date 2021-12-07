using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem
{
    class Question
    {
        public int ID { get; set; }
        public string question { get; set; }


        public Question() { }

        public override string ToString()
        {
            return this.ID.ToString() + ". " + this.question.ToString();
        }

    }
}
