using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IBook_detailRepository
    {
        List<Book_detail> GetAll();
        Book_detail Get(int id);
        int Insert(Book_detail book);
        int Update(Book_detail book);
        int Delete(int id);
    }
}
