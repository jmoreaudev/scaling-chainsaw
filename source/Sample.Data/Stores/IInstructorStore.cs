using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.Data.Models;

namespace Sample.Data.Stores
{
    public interface IInstructorStore
    {
        List<Instructor> GetInstructors();

        Instructor GetInstructorById(int id);
    }
}
