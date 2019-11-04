using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication13.Models;

namespace WebApplication13.Service
{
    public class Repository : IRepository
    {
        private SDbContext _sDbContext;
        public Repository(SDbContext sDbContext)
        {
            _sDbContext = sDbContext;
        }

        public List<Response> getById(int Id)
        {

            return _sDbContext.Responses.FromSql("GetById @p0", Id).ToList();
            
        }

        public List<Response> responses()
        {
            return _sDbContext.Responses.FromSql("SSS").ToList();
        }
    }
}
