using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AllGoods
{
    public interface Goods
    {
        string Item { get; }
        double Price { get; }
        bool IsimportTax { get; }
        bool Isexempt { get; }
    }
}
