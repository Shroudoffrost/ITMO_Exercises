using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentScore.Models
{
    public class Student
    {
        public virtual int StudentId    { get; set; }
        [DisplayName("FirstName")]
        public virtual string FirstName { get; set; }
        [DisplayName("LastName")]
        public virtual string LastName  { get; set; }
        [DisplayName("Group")]        
        public virtual string Group     { get; set; }
        [DisplayName("Task2")]
        public virtual int ScoreTask1   { get; set; }
        [DisplayName("Task2")]
        public virtual int ScoreTask2   { get; set; }
    }
}