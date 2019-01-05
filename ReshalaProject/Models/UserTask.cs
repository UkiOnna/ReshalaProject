using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReshalaProject.Models
{
    public class UserTask
    {
       public Guid Id { get; set; }
       public ApplicationUser Executor { get; set; }
       public string Cabinet { get; set; }
       public string Commentario { get; set; }
       public ApplicationUser Creator { get; set; }
       public DateTime CreationDate { get; set; }
       public bool IsComplete { get; set; }


        public UserTask()
        {

        }
        public UserTask(ApplicationUser creator,string cabinet,string commit)
        {
            Id = Guid.NewGuid();
            Creator = creator;
            Cabinet = cabinet;
            Commentario = commit;
            IsComplete = false;
        }
    }
}