using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow.Model
{
    
    public class User
    {
        public long ID { get; set; }

        public string Displayname { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }


    }
}
