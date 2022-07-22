using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StudentScore.Models;

namespace Student_scores.Models
{
    public class StudentDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {
        base.Seed(context);

    }
}