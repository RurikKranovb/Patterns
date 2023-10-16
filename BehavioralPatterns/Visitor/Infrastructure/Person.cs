using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Core;

namespace Visitor.Infrastructure
{
    public class Person : IAccont
    {
        public string FIO { get; set; } //Фамилия Имя Отчество
        public string AccNumber { get; set; } // номер счета


        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }

        //public void ToHtml()
        //{
        //    string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
        //    result += "<tr><td>FIO<td><td>" + FIO + "</td></tr>";
        //    result += "<tr><td>Number<td><td>" + AccNumber + "</td></tr></table>";
        //    Console.WriteLine(result);
        //}
    }
}
