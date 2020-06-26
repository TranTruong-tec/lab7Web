using QuanLySach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySach.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach { Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName ="Nguyễn Nhật Ánh", Price = 1, Content="Truyện kể về Tuổi thơ..." },

            new Sach { Id = 2, Title = "Pro ASP.NET MVC5", AuthorName = "Adam Freeman", Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft’sASP.NET web platform.",  Price = 3.75M },
            new Sach { Id = 3, Title = "Sin bad phieu luu", AuthorName ="aladin", Price = 3.5M, Content="Truyen ke ve sin bad phieu lieu ky..." },
            new Sach { Id = 4, Title = "Cánh cửa thần kỳ", AuthorName ="Doraemon", Price = 5, Content="Đô rê mon và nobita..." },

        };

        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult GetSachById(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id );

            //var sach = sachs.FirstOrDefault((p) => p.Title == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
            
            
        }

        public IHttpActionResult GetSachByName( string id)
        {
            var sach1 = sachs.FirstOrDefault((p) => p.Title.Contains(id));
            if (sach1 == null)
            {
                return NotFound();
            }
            return Ok(sach1);
        }


        

    }
}
