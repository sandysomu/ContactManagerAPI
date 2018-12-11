using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContentManagerAPI.Database.Data;
using ContentManagerAPI.Database.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ContentManagerAPI.Database.Services
{
    public interface IExampleService
    {
        void GetExamples();
        void AddExample(string name);
    }



    public class ExampleService : IExampleService
    {
        private readonly ContactsApiContext context;

        public ExampleService( ContactsApiContext ContactsApiContext)
        {
            context = ContactsApiContext;
        }

        public void GetExamples()
        {
            var examples = context.Examples
                .OrderBy(e => e.Name)
                .ToList();
        }

        public void AddExample(string name)
        {
            var example = new Example()
            {
               Id = 13,
                Name = name
            };

            context.Examples.Add(example);
            context.SaveChanges();
        }

    }


}
