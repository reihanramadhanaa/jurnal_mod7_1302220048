using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace modul7_1302220048
{

    class Address
    {
        public String streetAddress { get; set; }
        public String city { get; set; }
        public String state { get; set; }
    }

    class Courses
    {
        public String code { get; set; }
        public String name { get; set; }

        public static class DataMahasiswa1302220048
        {
            class Data
            {
                public Address address { get; set; }
                public string firstName { get; set; }
                public string lastName { get; set; }
                public string gender { get; set; }
                public int age { get; set; }
                public List<Courses> courses { get; set; }

            }

            public static void ReadJSON()
            {
                String jsonString = File.ReadAllText("C:\\semester 4\\konstruksi perangkat lunak\\jurnal7_1_1302220048.json");
                Data data = JsonSerializer.Deserialize<Data>(jsonString);
                Console.WriteLine("Nama  : " + data.firstName + data.lastName);
                Console.WriteLine("Gender : " + data.gender);
                Console.WriteLine("Age : " + data.age);
                Console.WriteLine("streetAddress : " + data.address.streetAddress);
                Console.WriteLine("city : " + data.address.city);
                Console.WriteLine("state : " + data.address.state);

                int i = 1;
                foreach (var item in data.courses ) 
                {
                    Console.WriteLine($"MK: {i} code: {item.code} nama: {item.name}");
                    i++;


                }


            }
        }
    }
}

