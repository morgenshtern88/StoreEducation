using DataLayer.Enteties;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducationApp.BusinessLogicLayer.Services.Interfaces
{
    public interface IAuthorServices
    {
        IEnumerable<Author> Authors { get; }
    }
}
