using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.Models;

namespace WebApplication13.Service
{
    public interface IRepository
    {
        List<Response> responses();
        List<Response> getById(int Id);
    }
}
