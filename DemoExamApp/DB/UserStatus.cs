using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExamApp.DB
{
    public class UserStatus
    {
        [Key]
        public int Id { get; set; }
        public string StatusName { get; set; }

        public List<User> users { get; set; }


    }
}
