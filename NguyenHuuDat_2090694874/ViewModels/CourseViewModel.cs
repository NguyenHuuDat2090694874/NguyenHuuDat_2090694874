using NguyenHuuDat_2090694874.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenHuuDat_2090694874.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }
    }
}