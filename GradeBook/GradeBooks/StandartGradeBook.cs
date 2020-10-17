using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandartGradeBook :BaseGradeBook
    { 
        //adding isWeithe=t
        public StandartGradeBook (string name ,bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
