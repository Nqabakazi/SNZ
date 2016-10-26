using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace My_work.Models
{
    public class ProductDetails
    {
        public List<Products> pro = new List<Products>();
        Products pr1 = new Products();
        Products pr2 = new Products();
        Products pr3 = new Products();
        Products pr4 = new Products();
        Products pr5 = new Products();
        Products pr6 = new Products();


        public void ProInfo()
        {
            pro.Clear();
            // pic1
           
            pr1.ProductName = "Food";
            pr1.ProductDiscription = "";
            pr1.ProPrice = 10000.00;
            pr1.ItemNumber = "125516";
            pro.Add(pr1);

            // pic2
            
            pr2.ProductName = "Food";
            pr2.ProductDiscription = "";
            pr2.ProPrice = 10000.00;
            pr2.ItemNumber = "1255112";
            pro.Add(pr2);

            // pic3
            
            pr3.ProductName = "Food";
            pr3.ProductDiscription = "";
            pr3.ProPrice = 10000.00;
            pr3.ItemNumber = "125517";
            pro.Add(pr3);

            // pic4
            
            pr4.ProductName = "Food";
            pr4.ProductDiscription = "";
            pr4.ProPrice = 10000.00;
            pr4.ItemNumber = "125518";
            pro.Add(pr4);

            // pic5
            
            pr5.ProductName = "Food";
            pr5.ProductDiscription = "";
            pr5.ProPrice = 10000.00;
            pr5.ItemNumber = "1255119";
            pro.Add(pr5);

            // pic6
            
            pr6.ProductName = "Food";
            pr6.ProductDiscription = "";
            pr6.ProPrice = 10000.00;
            pr6.ItemNumber = "1255110";
            pro.Add(pr6);

        }
        public Products getProInfo(string ProductName)

        {
            Products filter = null;
            foreach (Products item in pro)
            {
                if (item.ItemNumber == ProductName)
                {
                    filter = item;
                }
            }

            return filter;

        }
    }
}