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

        private string userName;
        private string passWord;

        private string email;
        private string phoneNumber;
        private string address;

        private int permissId;

        private DateTime dateCreate;
        public User()
        {

        }

        public User(int id, string firstName, string lastName, string userName, string password, string email, string phoneNumber, string address, int permissId, DateTime dateCreate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            PermissId = permissId;
            DateCreate = dateCreate;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => passWord; set => passWord = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public int PermissId { get => permissId; set => permissId = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
    }
}
