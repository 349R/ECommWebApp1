using ECommWebApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ECommWebApp1.Controllers
{
    public class ProductsEntriesController : ApiController
    {

        public IHttpActionResult GetProducts()
        {
            // get data from two tables
            try
            {
                using (var context = new AppDbContext())
                {
                    var Product_entries = context.EntryProducts
                        .Join(
                        context.EntryCategories.Where(x => x.Parent == 0),
                        d => d.MainCategoryID,
                        f => f.CategoryID,
                        (d, f) => d)
                        .ToList();
                    return Ok(Product_entries);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

    }
}

/*         var studentViewModel = from s in student
                       join st in studentAdditionalInfo on s.Id equals st.StudentId into st2
                                      from st in st2.DefaultIfEmpty()
                                      select new StudentViewModel { studentVm = s, studentAdditionalInfoVm = st };
                       return View(studentViewModel);
*/
