using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charts.DAL;

namespace Charts.DAL
{
    public class Repository
    {
        private ChartsContext _context;

        public Repository()
        {
            _context = new ChartsContext();
        }
    
        public List<Transaction> GetAllTransaction()
        {
            List<Transaction> result = _context.Transactions.ToList();
            return result;
        }
    }
}
