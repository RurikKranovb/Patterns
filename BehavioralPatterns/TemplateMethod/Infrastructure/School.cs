using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Core;

namespace TemplateMethod.Infrastructure
{
    public class School: Education
    {
        //public void Enter() { }
        //public void Study() { }
        //public void PassExams() { }
        //public void GetAttestat() { }
        //public new void Learn() { Console.WriteLine("Оп"); }
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }
    }
}
