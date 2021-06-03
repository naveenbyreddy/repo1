using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AssignBAL;
using AssignDAL;
using WebApiAssignment.Models;

namespace WebApiAssignment.Controllers 
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        InvoiceGeneration dal = new InvoiceGeneration();
        // GET api/values/5
        public List<Details> Get(int id)
        {
            List<InvoiceDetails> glist = new List<InvoiceDetails>();
            List<Details> list = new List<Details>();
            glist = dal.GetDetails(id);
            foreach (var item in glist)
            {
                Details d = new Details();
                d.CustomerID = item.CustomerID;
                d.CompanyName = item.CustomerName;
                d.City = item.City;
                d.EmployeeID = item.EmployeeID;
                d.OrderID = item.OrderID;
                d.OrderDate = item.OrderDate;
                d.ProductID = item.ProductID;
                d.ProductName = item.ProductName;
                d.QuantityPerUnit = item.QuantityPerUnit;
                d.UnitPrice = item.UnitPrice;
                d.Discount = item.Discount;
                d.Amt = Convert.ToInt32(item.Amt);
                d.Total = Convert.ToInt32(item.Total);

                list.Add(d);
            }

            return list;
        }



        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }













}
