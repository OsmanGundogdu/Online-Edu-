using OnlineEdu.WebUI.DTOs.BlogDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.BlogCategoryDTOs
{
    public class ResultBlogCategoryDto
    {
        public int BlogCategoryID { get; set; }
        public string Name { get; set; }
        public List<ResultBlogDto> Blogs { get; set; }
    }
}
