using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DubrovinSN.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            char firstbykva = value[0];
            string orabl = value.Substring(1);
            string itogslovo  = orabl + firstbykva;
            return itogslovo;           
        }
    }
}
