using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts.Classes
{
    //[Table("SomethingElse")]   Override table name to NOT be class name
    public class Contact
    {
        // SQLite attribute
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        //[Column("SomethingElse")]   Override column name to NOT be property name
        public string LastName { get; set; }
        public string Email { get; set; }
        [MaxLength(10)]
        public string Phone { get; set; }
        public string Address { get; set; }

        public Contact()
        {

        }
    }
}
