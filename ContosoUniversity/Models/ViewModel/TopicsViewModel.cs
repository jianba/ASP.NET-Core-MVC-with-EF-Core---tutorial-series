using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.ViewModel
{
    public class TopicsViewModel 
    {
        public List<TopicViewModel> Topics { get; set; } = new List<TopicViewModel>();
    }
}
