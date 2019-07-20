using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface PieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);        
    }
}
