using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDienThoai.DTO
{
    public class TaiKhoan
    {
        private int staffId;
        private string userName;
        private string password;
        private int permissId;
        private int status;

        public TaiKhoan()
        {

        }

        public TaiKhoan(int staffId, string userName, string password, int permissId,int status)
        {
            this.staffId = staffId;
            this.userName = userName;
            this.password = password;
            this.permissId = permissId;
            this.status = status;
        }

        public int StaffId { get => staffId; set => staffId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int PermissId { get => permissId; set => permissId = value; }
        public int Status { get => status; set => status = value; }
    }
}
