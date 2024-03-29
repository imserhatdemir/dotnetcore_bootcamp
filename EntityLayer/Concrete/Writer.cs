﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterAbout { get; set; }
        public string WriterMail { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public bool WriterStatus { get; set; }
        public DateTime WriterCreateDate { get; set; }
        public List<Blog> Blogs { get; set; }
        public virtual ICollection<Message2> WriterSender { get; set; }
        public virtual ICollection<Message2> WriterReciver { get; set; }
    }
}
