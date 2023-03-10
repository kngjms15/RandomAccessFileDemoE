using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RandomAccessFileDemoE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //User user1 = new User("Joe Blow", "password", 29);
            //User user2 = new User("Joe Schmoe", "secret", 75);

            FileStream fileStream = new FileStream("users.bin", FileMode.Open);//bin short for "binary"

            //FileStream fileStream = new FileStream("users.bin", FileMode.OpenOrCreate);
            //using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            using (BinaryReader binaryReader = new BinaryReader(fileStream)) // usning * different from 
            {
                //binaryWriter.Write(user1.Name);//overload when you have same method that takes in different args vs override provides different implementations  
                //binaryWriter.Write(user1.Password);
                //binaryWriter.Write(user1.age);

                //binaryWriter.Write(user2.Name);//overload when you have same method that takes in different args vs override provides different implementations  
                //binaryWriter.Write(user2.Password);
                //binaryWriter.Write(user2.age);
                string user1Name = binaryReader.ReadString();
                string user1Password = binaryReader.ReadString();
                int user1Age = binaryReader.ReadInt32();

                string user2Name = binaryReader.ReadString();
                string user2Password = binaryReader.ReadString();
                int user2Age = binaryReader.ReadInt32();



                Console.WriteLine($"{user1Name}, {user1Password}, {user1Age}");
                Console.WriteLine($"{user2Name}, {user2Password}, {user2Age}");
            }

            //Console.WriteLine("Wrote to binary file");
            //Console.WriteLine($"{user1.Name},{user1.Password}, {user1.age}");
            //Console.WriteLine($"{user2.Name},{user2.Password}, {user2.age}");

            

                Console.ReadLine();  


        }
    }
}
