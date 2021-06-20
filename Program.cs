using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo _instance = new StudentInfo();
            _instance.SetId("S100");
            _instance.SetName("tom");
            _instance.SetMarks(60);

            string idValue = _instance.GetId();
            string nameValue = _instance.GetName();
            int marksValue = _instance.GetMarks();
        }
    }
}
