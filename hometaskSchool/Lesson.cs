﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskSchool
{
    public class Lesson
    {
        public string Name { get; set; }
        public List<Class> Classes { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
