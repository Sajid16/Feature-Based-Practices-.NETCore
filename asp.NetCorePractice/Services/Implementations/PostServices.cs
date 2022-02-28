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

        public bool Delete(string id, out string error)
        {
            error = "";
            try
            {
                var post = GetById(id, out string errorCheck);
                if (post is null)
                    return false;
                _post.Remove(post);
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

        public dynamic GetById(string id, out string error)
        {
            error = "";
            try
            {
                var singlePost = _post.SingleOrDefault(post => post.Id == id);
                if (singlePost == null)
                    return null;
                return singlePost;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return null;
            }
        }

        public bool Update(string id, Posts model, out string error)
        {
            error = "";
            try
            {
                bool isExist = GetById(id, out string errorCheck) != null;
                if (isExist)
                {
                    var index = _post.FindIndex(post => post.Id == id);
                    var updatedData = new Post
                    {
                        Id = id,
                        Title = model.Title,
                        Description = model.Description
                    };
                    _post[index] = updatedData;
                    return true;                
                }
                return false;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }
    }
}
