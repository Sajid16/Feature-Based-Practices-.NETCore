using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Contracts.V1
{
    public static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        public const string Base = Root+"/"+Version;

        public static class Posts
        {
            public const string PostBase= Base+"/posts";
            //public const string GetAll= PostBase+"/get-all";
            //public const string Create= PostBase+"/create";
        }
    }
}
