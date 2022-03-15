using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Productreview> list = new List<Productreview>()
            {
                new Productreview(){productid=1,userid=1,rating=5,review="good",isLike=true },
                new Productreview(){productid=2,userid=2,rating=3,review="Awesome",isLike=true },
                new Productreview(){productid=3,userid=3,rating=4,review="bad",isLike=false },
                new Productreview(){productid=4,userid=10,rating=1,review="nice",isLike=true },
                new Productreview(){productid=5,userid=5,rating=5,review="nice",isLike=true },
                new Productreview(){productid=5,userid=5,rating=3,review="Great",isLike=true },
                new Productreview(){productid=5,userid=10,rating=2,review="ok ok",isLike=true },
                new Productreview(){productid=5,userid=10,rating=1,review="nice",isLike=true },
                new Productreview(){productid=5,userid=10,rating=5,review="Good",isLike=true },
                new Productreview(){productid=5,userid=10,rating=4,review="nice",isLike=true },
            };
            //foreach (Productreview item in list)
            //{
            //    Console.WriteLine(item.productid + " " + item.userid + " " + item.rating + " " + item.review + " " + item.isLike);
            //}
            ProductReviewManagement productReviewManagement = new ProductReviewManagement();
            productReviewManagement.RetrieveRecordbyuserid(list);
        }
    }
}
