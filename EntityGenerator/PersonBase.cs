using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityGenerator
{
    [GUID("efa3e159-7591-427e-a690-c8eb607f2a7f")]
    public class PersonBase
    {
        [GUID("38923767-b8ee-4e29-a90b-5d76f1f6c447")]
        public Int32 id { get; set; }
        [GUID("5e32ce63-c7ec-459e-820f-242f0bb87be6")]
        public String name { get; set; }
        [GUID("f505fb64-4986-4efb-88ff-abd8fd23f6c9")]
        public String address { get; set; }
        [GUID("8e2249fc-d0c6-45b0-8ca9-3bb3c0cf6ca6")]
        public Int32 age { get; set; }
        [GUID("ff10d0f3-23a1-43b1-a623-45d8633ad3c6")]
        public Boolean gender { get; set; }
        [GUID("d40c9fb2-7d1b-4c03-b8fb-e95696f86c96")]
        public List<String> list { get; set; }

        public PersonBase() { }

        public Int32 getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public String getAddress()
        {
            return address;
        }

        public Int32 getAge()
        {
            return age;
        }

        public Boolean getGender()
        {
            return gender;
        }

        public List<String> getList()
        {
            return list;
        }


        public void setId(Int32 newValue)
        {
            id = newValue;
        }

        public void setName(String newValue)
        {
            name = newValue;
        }

        public void setAddress(String newValue)
        {
            address = newValue;
        }

        public void setAge(Int32 newValue)
        {
            age = newValue;
        }

        public void setGender(Boolean newValue)
        {
            gender = newValue;
        }

        public void setList(List<String> newValue)
        {
            list = newValue;
        }

    }
}