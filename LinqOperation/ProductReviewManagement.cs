using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperation
{
    public class ProductReviewManagement
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<Productreview> productreviewlist, int top)
        {
            var recorddata = (from productreviews in productreviewlist orderby productreviews.rating descending select productreviews).Take(top);
            foreach (var record in recorddata)
            {
                Console.WriteLine(record.productid + " " + record.userid + " " + record.rating + " " + record.review);
            }
        }
        public void SelectedRecords(List<Productreview> list)
        {
            var recorddata = from productreviews in list where (productreviews.rating > 3) && ((productreviews.productid == 1) || (productreviews.productid == 4) || (productreviews.productid == 9)) select productreviews;
            foreach (var record in recorddata)
            {
                Console.WriteLine(record.productid + " " + record.review);
            }
        }

        public void RetrieveCountOfRecord(List<Productreview> list)
        {
            var recorddata = list.GroupBy(x => x.productid).Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach(var record in recorddata)
            {
                Console.WriteLine(record.ProductId + " " + record.Count);
            }
        }
        public void RetrieveProductIdandReview(List<Productreview>list)
        {
            var recorddata = from product in list select  new { product.productid,product.review};

            foreach (var record in recorddata)
            {
                Console.WriteLine(record.productid + " " + record.review);
            }

        }
        public void Skiptopfive(List<Productreview> list)
        {
            var recorddata = (from product in list select product).Skip(5);
            foreach (Productreview item in recorddata)
            {
                Console.WriteLine(item.productid + " " + item.userid + " " + item.rating + " " + item.review + " " + item.isLike);
            }
        }
       public void IsLikeValue(List<Productreview> list)
        {
            var recorddata = from product in list where (product.isLike == true) select product;
            foreach (Productreview item in recorddata)
            {
                Console.WriteLine(item.productid + " " + item.userid + " " + item.rating + " " + item.review + " " + item.isLike);
            }
        }
        public void RetrieveAverageOfRecord(List<Productreview> list)
        {
            var proids= (from product in list select product.productid).Distinct();
            Console.WriteLine("Productid  AverageRating");
            foreach (var pp in proids)
            {
                var recorddata = (from product in list where product.productid == pp select product).Average(x => x.rating);
                Console.WriteLine(pp+"           "+ recorddata);
            }
        }
        public void ReteriveNiceReviewRecord(List<Productreview> list)
        {
            var recorddata = from product in list where (product.review == "nice") select product;
            foreach (Productreview item in recorddata)
            {
                Console.WriteLine(item.productid + " " + item.userid + " " + item.rating + " " + item.review + " " + item.isLike);
            }
        }
        public void RetrieveRecordbyuserid(List<Productreview> list)
        {
            var recorddata =from product in list where(product.userid==10)orderby product.rating descending select product;
            foreach (Productreview item in recorddata)
            {
                Console.WriteLine(item.productid + " " + item.userid + " " + item.rating + " " + item.review + " " + item.isLike);
            }

        }


    }
}