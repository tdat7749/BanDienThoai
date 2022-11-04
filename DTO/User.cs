using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;

        private string phoneNumber;
        private string address;

        private DateTime dateCreate;
        public User()
        {

        }

        public User(int id, string firstName, string lastName, string phoneNumber, string address, DateTime dateCreate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            DateCreate = dateCreate;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
    }
}
