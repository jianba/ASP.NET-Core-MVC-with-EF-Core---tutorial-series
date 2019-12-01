using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.TestViewModels
{
    public class ArticleViewModel
    {
        public ArticleViewModel()
        {
            Sections = new List<ArticleSection>();
        }

        public string AuthorName { get; set; }
        public List<ArticleSection> Sections { get; set; }
    }

    public class ArticleSection
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
