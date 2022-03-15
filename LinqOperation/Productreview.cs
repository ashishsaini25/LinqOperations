using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperation
{
    public  class Productreview
    {
        public int productid { get; set; }
        public int  userid { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
