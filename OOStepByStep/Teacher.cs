﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string n, int a) : base(n, a)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age, classNumber)
        {
        }

        public override string Introduce()
        {
            return $"{base.Introduce()} I am a teacher{this.GenerateClassIntroduce()}.";
        }
    }
}
