using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandartGradeBook :BaseGradeBook
    { 
        public StandartGradeBook (string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
