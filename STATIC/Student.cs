using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC
{
    internal class Student
    {
        public int Id { get; set; } 
        public static string? Name { get; set; }

        private string? cardStudent { get; set; }   

        public static void getNoteStudent()
        {
            MessageBox.Show("Get note Static");
        }

    }
}
