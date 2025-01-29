using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudBlazorSample.Entity;

namespace MudBlazorSample.Service
{
    public interface IBookService
    {
      Task<List<Book>> GetBooksAsync();
      Task<Book?> GetBookByIdAsync(int id);

    }
}
