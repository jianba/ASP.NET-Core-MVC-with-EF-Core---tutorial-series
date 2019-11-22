using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.ViewModel
{
    
    public class TopicViewModel : Topic
    {
        public List<PostViewModel> Posts { get; set; }
    }
}
