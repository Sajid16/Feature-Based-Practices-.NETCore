using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.V1;
using WebApi.Models;

namespace WebApi.Services.Abstractions
{
    public interface IPostServices
    {
        public bool Add(Posts model, out string error);
        public List<Post> GetAll(out string error);
        public dynamic GetById(string id, out string error);
        public bool Update(string id, Posts model, out string error);
        public bool Delete(string id, out string error);
    }
}
