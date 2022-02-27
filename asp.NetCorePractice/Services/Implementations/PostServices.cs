using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain.V1;
using WebApi.Models;
using WebApi.Services.Abstractions;

namespace WebApi.Services.Implementations
{
    public class PostServices : IPostServices
    {
        //private List<Post> _post = new List<Post>();
        private List<Post> _post;
        public PostServices()
        {
            _post = new List<Post>();
            //for (var i = 0; i < 5; i++)
            //{
            //    _post.Add(new Post { Id = Guid.NewGuid().ToString() });
            //}
        }
        public bool Add(Posts model, out string error)
        {
            error = "";
            try
            {
                _post.Add(new Post {
                    Id = Guid.NewGuid().ToString(),
                    Title = model.Title,
                    Description = model.Description
                });
                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }

        public List<Post> GetAll(out string error)
        {
            error = "";
            try
            {
                return _post;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return new List<Post>();
            }
        }
    }
}
