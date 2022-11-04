﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class Staff
    {
        private int id;
        private string firstName;
        private string lastName;
        private string gioiTinh;
        private string chucVu;

        public Staff()
        {

        }

        public Staff(int id, string firstName, string lastName, string gioiTinh, string chucVu)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gioiTinh = gioiTinh;
            this.chucVu = chucVu;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
