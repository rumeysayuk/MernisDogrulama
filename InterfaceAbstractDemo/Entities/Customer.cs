using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public DateTime DataOfBirth { get; set; }


    }
}
