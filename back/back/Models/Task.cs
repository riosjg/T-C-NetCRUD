using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back.Models
{
    public class Task
    {
        private int id;
        private string description;
        private bool status;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public bool Status { get => status; set => status = value; }
    }
}