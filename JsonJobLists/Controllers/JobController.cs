using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JsonJobLists.Models;

namespace JsonJobLists.Controllers
{
    public class JobController : Controller
    {
        // GET: Job

        public List<getData> GetUsers()
        {
            var usersList = new List<getData>  
            {  
                new getData
    {
		client= "Faucibus Corp.",
		Jobnumber =  7,
		JobName = "Ontario",
		Due = "2014-07-11 00:36:20",
		status = "closed"
	}, 
    new getData
    {
		client= "Vulputate Associates",
		Jobnumber =  8,
		JobName = "Istanbul",
		Due = "2016-01-05 21:58:28",
		status = "closed"
	}, 
    new getData{
		client= "Fringilla Incorporated",
		Jobnumber =  9,
		JobName = "BU",
		Due = "2015-07-25 08:19:36",
		status = "open"
	}, 
    new getData{
		client= "Lectus Sit Associates",
		Jobnumber =  10,
		JobName = "CA",
		Due = "2015-05-29 04:01:22",
		status = "open"
	}, 
    new getData{
		client= "Magna Malesuada Vel Company",
		Jobnumber =  11,
		JobName = "Ontario",
		Due = "2014-10-15 00:27:04",
		status = "open"
	}, 
    new getData{
		client= "Magna Lorem Institute",
		Jobnumber =  12,
		JobName = "HE",
		Due = "2014-11-11 17:11:00",
		status = "open"
	}, 
    new getData{
		client= "Arcu Vestibulum Ante Institute",
		Jobnumber =  13,
		JobName = "Catalunya",
		Due = "2015-08-28 08:22:56",
		status = "open"
	}, 
    new getData{
		client= "Eros Incorporated",
		Jobnumber =  14,
		JobName = "Ontario",
		Due = "2014-09-19 02:33:59",
		status = "open"
	}, 
    new getData{
		client= "Suspendisse Tristique Neque Corporation",
		Jobnumber =  15,
		JobName = "Rio de Janeiro",
		Due = "2014-07-10 02:06:29",
		status = "open"
	}, 
    new getData{
		client= "Lorem Sit LLC",
		Jobnumber =  16,
		JobName = "Veneto",
		Due = "2014-03-30 02:04:42",
		status = "open"
	}, 
    new getData{
		client= "Interdum Limited",
		Jobnumber =  17,
		JobName = "VIC",
		Due = "2015-06-10 07:16:53",
		status = "open"
	}, 
    new getData{
		client= "In Tincidunt Congue Ltd",
		Jobnumber =  18,
		JobName = "New South Wales",
		Due = "2014-06-04 04:41:24",
		status = "open"
	}, 
            
            new getData
            {
		client= "Vestibulum Ltd",
		Jobnumber =  19,
		JobName = "NW",
		Due = "2016-09-13 14:22:02",
		status = "open"
	}, 
            new getData
            {
		client= "Aliquam Institute",
		Jobnumber =  20,
		JobName = "WV",
		Due = "2014-08-14 01:32:43",
		status = "open"
	}, 
            
            new getData
            {
		client= "Purus Duis Company",
		Jobnumber =  21,
		JobName = "Podkarpackie",
		Due = "2016-05-27 07:48:59",
		status = "open"
	},
            new getData
            {
		client= "At Augue Institute",
		Jobnumber =  22,
		JobName = "Bursa",
		Due = "2015-04-23 21:09:14",
		status = "open"
	}, 
            new getData
            {
		client= "Gravida Sit Inc.",
		Jobnumber =  23,
		JobName = "Vienna",
		Due = "2016-10-05 04:49:12",
		status = "open"
	}, 
            new getData
            {
		client= "Aptent Taciti Ltd",
		Jobnumber =  24,
		JobName = "Zeeland",
		Due = "2014-09-14 16:47:31",
		status = "open"
	}, 
            new getData
            {
		client= "Odio Ltd",
		Jobnumber =  25,
		JobName = "SL",
		Due = "2014-04-28 09:32:18",
		status = "open"
	}, 
            new getData
            {
		client= "Vel Turpis Aliquam LLP",
		Jobnumber =  26,
		JobName = "South Island",
		Due = "2016-01-26 14:01:47",
		status = "open"
	}, 
            new getData
            {
		client= "Sem LLP",
		Jobnumber =  27,
		JobName = "Michigan",
		Due = "2014-05-07 17:07:57",
		status = "open"
	}, 
            new getData
            {
		client= "Aenean Eget Magna Company",
		Jobnumber =  28,
		JobName = "MI",
		Due = "2014-11-16 08:57:21",
		status = "open"
	}, 
            new getData
            {
		client= "Eleifend Vitae Associates",
		Jobnumber =  29,
		JobName = "Maryland",
		Due = "2016-05-12 07:49:44",
		status = "open"
	}, 
            new getData
            {
		client= "Et Magnis Dis Corp.",
		Jobnumber =  30,
		JobName = "Munster",
		Due = "2014-05-17 04:58:45",
		status = "open"
	
            }
            };

            return usersList;
        }

        public List<getData> GetUsersHugeData()
        {
            var usersList = new List<getData>();
            getData user;
            for (int i = 1; i < 51000; i++)
            {
                user = new getData
                {
                    client = " " +i,
                    Jobnumber = i,
                    JobName = "JobName -" + i,
                    Due = " " + 1,
                    status = " " + 1
                };
                usersList.Add(user);
            }

            return usersList;
        }  

        public ActionResult Index(getData db)
        {
            return View(db);
        }
    }
}