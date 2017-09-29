using MyBookstore.App_Code;
using MyBookstore.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MyBookstore.Controllers
{
    public class PublisherController : Controller
    {
        // GET: Publisher
        public ActionResult Index()
        {
            List<PublisherModels> list = new List<PublisherModels>();
            using (SqlConnection MyCon = new SqlConnection(Helper.GetCon()))
            {
                MyCon.Open();
                string query = @"SELECT pubID, pubName FROM publishers";
                using (SqlCommand cmd = new SqlCommand(query, MyCon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            foreach (DataRow row in dt.Rows)
                            {
                                var publisher = new PublisherModels();
                                publisher.ID = Convert.ToInt32(row["pubID"].ToString());
                                publisher.Name = row["pubName"].ToString();
                                
                                list.Add(publisher);


                            }
                        }
                    }
                }
            }
            return View(list);
        }

        // GET: Publisher/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Publisher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publisher/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publisher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publisher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publisher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publisher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
