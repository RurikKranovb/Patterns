using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Core;

namespace Visitor.Infrastructure
{
    public class Company : IAccont
    {
        public string Name { get; set; } // название
        public string RegNumber { get; set; } // гос регистрационный номер
        public string Number { get; set; } // номер счета


        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAc(this);
        }

        //public void ToHtml()
        //{
        //    string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
        //    result += "<tr><td>Name<td><td>" + Name + "</td></tr>";
        //    result += "<tr><td>RegNumber<td><td>" + RegNumber + "</td></tr>";
        //    result += "<tr><td>Number<td><td>" + Number + "</td></tr></table>";
        //    Console.WriteLine(result);
        //}
    }
}
