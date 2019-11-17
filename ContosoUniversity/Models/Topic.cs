using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Topic
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TopicId { get; set; }
        public int PostCount { get; set; }
        public string Title { get; set; }
        public string OriginalPoster { get; set; }
    }

    public class Post
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        public int TopicId { get; set; }
        [ForeignKey("TopicId")]
        public DateTime TimeStamp { get; set; }
        public string Poster { get; set; }
        public string Body { get; set; }
    }
}
