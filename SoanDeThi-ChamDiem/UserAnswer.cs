using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoanDeThi_ChamDiem
{
    class UserAnswer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Answer { get; set; }

        public override string ToString()
        {
            //return this.ID.ToString() + ". " + this.content.ToString();
            return this.Name + " ID " + this.ID + " Answer: " + this.Answer;
        }

    }
}
