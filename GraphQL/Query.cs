using System;
using System.Security.AccessControl;
using System.Linq;
using CommanderGQL.Models;
using CommandGQL.Data;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
           return context.Platforms;
        }
    }
}