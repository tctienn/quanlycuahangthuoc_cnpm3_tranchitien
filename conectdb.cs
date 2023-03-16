using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace quanlycuahangthuoc
{
    class conectdb
    {
        string connStr = @"Data Source=DESKTOP-MA3LKHC\SQLEXPRESS;Initial Catalog=do_an_net;Integrated Security=True";

        protected SqlConnection conn;

        public void openConnect()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        public void closeConnect()
        {
            conn.Close();
        }


        // lấy số tháng còn lại
        //DECLARE @InvoiceDate DATE = '2016-08-01';
        //SELECT* ,DATEDIFF(MONTH, ngayhethan, GETDATE()) as 'ui' from sanpham where DATEDIFF(MONTH, ngayhethan, GETDATE())>1;


        public DataTable Load_sanpham()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from sanpham where  deleteed =0 ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_nhanvien()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from nhanvien ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_nhanvien_on()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from nhanvien where trangthai=1 ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }




        public DataTable Load_loaisp()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from loaisp ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_lohang()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from lohang ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_thuocHH()
        {
            DataTable bang = new DataTable();
            openConnect();  //CURRENT_TIMESTAMP và CURRENT_TIMESTAMP() là những hàm có chức năng tương tự như hàm NOW()   Hàm CAST trong SQL chủ yếu được sử dụng để chuyển đổi biểu thức từ kiểu dữ liệu này sang kiểu dữ liệu khác
            string sql = "SELECT * from sanpham where ngayhethan < CAST(CURRENT_TIMESTAMP AS DATE) and deleteed =0  ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_taikhoan()
        {
            DataTable bang = new DataTable();
            openConnect();  //CURRENT_TIMESTAMP và CURRENT_TIMESTAMP() là những hàm có chức năng tương tự như hàm NOW()   Hàm CAST trong SQL chủ yếu được sử dụng để chuyển đổi biểu thức từ kiểu dữ liệu này sang kiểu dữ liệu khác
            string sql = "SELECT * from taikhoan ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_ngaytao_hoadon()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT DISTINCT ngaytao  from hoadon   ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_sanphamhoadon(string mahd)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from sanphamhoadon  " +mahd;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public string tong_sp()  // lấy tổng sản phẩm
        {
            
            openConnect(); 
            string sql = "select sum(soluong) from sanpham where deleteed = 0 ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            string  tong = reader[0].ToString();


            
            closeConnect();
            return tong;
        }

      

        //public DataTable Load_lohang()
        //{
        //    DataTable bang = new DataTable();
        //    openConnect();
        //    string sql = "SELECT * from lohang ";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    bang.Load(reader);
        //    closeConnect();
        //    return bang;
        //}


        //insert
        public bool them_sp(string lo_lohang, string tenthuoc, string id_loaisp, string ngaynhap, string manv_nhanvien, string ngayhethan, string soluong, string gia)
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed) values(@lo_lohang, @tenthuoc, @id_loaisp, @ngaynhap, @manv_nhanvien, @ngayhethan, @soluong, @gia, '0')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@lo_lohang", lo_lohang);
            cmd.Parameters.AddWithValue("@tenthuoc", tenthuoc);
            cmd.Parameters.AddWithValue("@id_loaisp", id_loaisp);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cmd.Parameters.AddWithValue("@manv_nhanvien", manv_nhanvien);
            cmd.Parameters.AddWithValue("@ngayhethan", ngayhethan);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@gia", gia);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool them_lohang(string ngaynhap, string manv_nhanvien, string nhacungcap)
        {
            bool ktthem;
           
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into lohang(ngaynhap, manv_nhanvien, nhacungcap) values(@ngaynhap, @manv_nhanvien, @nhacungcap)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cmd.Parameters.AddWithValue("@manv_nhanvien", manv_nhanvien);
            cmd.Parameters.AddWithValue("@nhacungcap", nhacungcap);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool them_nhanvien(string tennv, string diachi,string gioitinh, string sdt ,string namsinh )
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into nhanvien(tennv,diachi,gioitinh,sdt,namsinh,trangthai) values (@tennv,@diachi,@gioitinh,@sdt,@namsinh,'1')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@namsinh", namsinh);
            
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }


        public bool them_loaisanpham(string loai )
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into loaisp(loai) values (@loai)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@loai", loai);
        
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool them_thongkehuy(string id_lohang , string mathuoc_sanpham , string ngayhethan , string ngayhuy , string manv ,  string soluong )
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into thongkehuy(id_lohang,mathuoc_sanpham ,ngayhethan ,ngayhuy , manv_nhanvien,  soluong) values (@id_lohang,@mathuoc_sanpham , @ngayhethan , @ngayhuy , @manv , @soluong  )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_lohang", id_lohang);
            cmd.Parameters.AddWithValue("@mathuoc_sanpham", mathuoc_sanpham);
            cmd.Parameters.AddWithValue("@ngayhethan", ngayhethan);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@soluong", soluong);


            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool them_taikhoan(string tk, string mk, string cap)
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into taikhoan(tk,mk ,cap) values (@tk,@mk , @cap  )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);
            cmd.Parameters.AddWithValue("@cap", cap);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool them_khachhang(string id, string ten, string sdt )
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into khachhang(id, ten ,sdt ) values (@id ,@ten , @sdt   )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@sdt", sdt);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }


        public bool them_hoadon(string mahd, string id_khachhang, string ngaytao, string nhanvien , string tongtien )
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into hoadon(mahd, id_khachhang ,ngaytao , nhanvien , tongtien ) values (@mahd ,@id_khachhang , @ngaytao , @nhanvien  ,@tongtien )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahd", mahd);
            cmd.Parameters.AddWithValue("@id_khachhang", id_khachhang);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@nhanvien", nhanvien);
            cmd.Parameters.AddWithValue("@tongtien", tongtien);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool them_sanpham_hoadon(string mahd_hoadon, string mathuoc_sanpham, string tenthuoc, string gia ,string soluong)
        {
            bool ktthem;
            openConnect();
            //insert into sanpham(lo_lohang, tenthuoc, id_loaisp, ngaynhap, manv_nhanvien, ngayhethan, soluong, gia, deleteed)
            string sql = "insert into sanphamhoadon(mahd_hoadon, mathuoc_sanpham ,tenthuoc , gia ,soluong ) values (@mahd_hoadon ,@mathuoc_sanpham , @tenthuoc , @gia  ,@soluong )";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahd_hoadon", mahd_hoadon);
            cmd.Parameters.AddWithValue("@mathuoc_sanpham", mathuoc_sanpham);
            cmd.Parameters.AddWithValue("@tenthuoc", tenthuoc);
            cmd.Parameters.AddWithValue("@gia", gia);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }



        //kiểm tra tồn tại
        public bool check_sanpham(string lo_lohang , string tenthuoc)
        {
            bool kq = false;

            openConnect();
            string sql = "SELECT * from sanpham where lo_lohang =@lo_lohang and tenthuoc=@tenthuoc and deleteed =0 ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@lo_lohang", lo_lohang);
            cmd.Parameters.AddWithValue("@tenthuoc", tenthuoc);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;

        }

        public bool check_loaisp(string loai)
        {
            bool kq = false;

            openConnect();
            string sql = "SELECT * from loaisp where loai=@loai ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@loai", loai);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;

        }

        public bool check_key_loai(string loai)
        {
            bool kq = false;

            openConnect();
            string sql = "SELECT loaisp.loai as 'loai' from loaisp , sanpham where loaisp.id = sanpham.id_loaisp and loaisp.loai=@loai ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@loai", loai);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;

        }

        public bool check_taikoan(string tk)
        {
            bool kq = false;

            openConnect();
            string sql = "SELECT * from taikhoan where tk=@tk ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;

        }


        public bool check_dangnhap(string tk , string mk)
        {
            bool kq = false;

            openConnect();
            string sql = "SELECT * from taikhoan where tk=@tk and mk = @mk  ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
                kq = true;
            closeConnect();
            return kq;

        }

        public string captaikhoan(string tk, string mk)
        {
            string kq = "";

            openConnect();
            string sql = "SELECT * from taikhoan where tk=@tk and mk = @mk  ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@mk", mk);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows == true)
            {
                while(reader.Read())
                {
                    kq = reader["cap"].ToString();
                    break;
                }
            }
            else
            {

            }
            closeConnect();
            return kq;

        }
        //public bool check_admin()  // kiem tra xem có nhiều hơn 1 tài khoản admin
        //{
        //    bool kq = false;

        //    openConnect();
        //    string sql = "select  'ok'   from taikhoan where (select count(cap) from taikhoan where cap =1 )>1 ";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.HasRows == true)
        //        kq = true;
        //    closeConnect();
        //    return kq;

        //}


        // update 

        public bool update_nhanvien(string manv, string tennv, string diachi , string gioitinh , string sdt , string namsinh)
        {                       
            bool ktthem;
            openConnect();
            string sql = "update nhanvien set  tennv=@tennv , diachi=@diachi , gioitinh=@gioitinh , sdt=@sdt , namsinh=@namsinh    where manv=@manv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Parameters.AddWithValue("@namsinh", namsinh);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool update_trangthai_nv(string manv, string trangthai)
        {
            bool ktthem;
            openConnect();
            string sql = "update nhanvien set trangthai=@trangthai   where manv=@manv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@trangthai", trangthai);
     
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool update_loaisp(string id, string loai)
        {
            bool ktthem;
            openConnect();
            string sql = "update loaisp set loai=@loai   where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@loai", loai);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool update_huythuoc(string mathuoc)
        {
            bool ktthem;
            openConnect();
            string sql = "update sanpham set deleteed=1   where mathuoc=@mathuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mathuoc", mathuoc);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool upate_sanpham(string mathuoc ,string tenthuoc , string id_loaisp ,string ngayhethan , string soluong ,string gia)
        {
            bool ktthem;
            openConnect();
            string sql = "update sanpham set tenthuoc=@tenthuoc , id_loaisp=@id_loaisp , ngayhethan = @ngayhethan ,soluong = @soluong ,gia = @gia   where mathuoc=@mathuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mathuoc", mathuoc);
            cmd.Parameters.AddWithValue("@tenthuoc", tenthuoc);
            cmd.Parameters.AddWithValue("@id_loaisp", id_loaisp);
            cmd.Parameters.AddWithValue("@ngayhethan", ngayhethan);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@gia", gia);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }
        public bool upate_sanpham_hoadon(string mathuoc , string soluong)
        {
            bool ktthem;
            openConnect();
            string sql = "update sanpham set soluong = @soluong    where mathuoc=@mathuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mathuoc", mathuoc);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        public bool update_taikhoan(string tk , string up_str)
        {
            bool ktthem;
            openConnect();
            string sql = "update taikhoan  "+ up_str +"  where tk= @tk";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            cmd.Parameters.AddWithValue("@up_str", up_str);

            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;
        }

        // delete
        public bool xoa_loai(string loai)
        {
            bool ktthem;

            openConnect();
            string sql = "DELETE FROM loaisp WHERE loai=@loai ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@loai", loai);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;


        }

        public bool xoa_tk(string tk)
        {
            bool ktthem;

            openConnect();
            string sql = "DELETE FROM taikhoan WHERE tk=@tk ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tk", tk);
            try
            {
                cmd.ExecuteNonQuery();
                ktthem = true;
            }
            catch
            {
                ktthem = false;
            }
            closeConnect();
            return ktthem;


        }

        // tìm kiếm
        public DataTable tim_sanpham(string giatri)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT sanpham.mathuoc as'mathuoc',lohang.ngaynhap as'lo' , sanpham.tenthuoc as 'tenthuoc' , loaisp.loai as 'loai' , sanpham.ngaynhap as 'ngaynhap' , nhanvien.tennv as 'nhanvien' , sanpham.ngayhethan as 'ngayhethan' , sanpham.soluong as 'soluong' , sanpham.gia as 'gia'  from sanpham , loaisp , lohang,nhanvien  where sanpham.lo_lohang = lohang.lo and sanpham.id_loaisp = loaisp.id and sanpham.manv_nhanvien = nhanvien.manv and   deleteed =0  " + giatri;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable tim_thongkehuy(string giatri)
        {
            //giatri = "and lohang.ngaynhap = ' 2001/01/14 ' ";
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select thongkehuy.sophieu as 'sophieu' , lohang.ngaynhap as 'lo' , thongkehuy.mathuoc_sanpham 'mathuoc_sanpham' , sanpham.ngayhethan as 'ngayhethan' , thongkehuy.ngayhuy as 'ngayhuy', thongkehuy.manv_nhanvien  as 'manv_nhanvien' , thongkehuy.soluong  as 'soluong' from thongkehuy ,sanpham , nhanvien , lohang  where thongkehuy.id_lohang = lohang.lo  and  thongkehuy.mathuoc_sanpham = sanpham.mathuoc  " + giatri + " group by thongkehuy.sophieu  , lohang.ngaynhap , thongkehuy.mathuoc_sanpham  , sanpham.ngayhethan  , thongkehuy.ngayhuy , thongkehuy.manv_nhanvien   , thongkehuy.soluong  ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable tim_sanpham_thanhtoan(string giatri)
        {
            //giatri = "and lohang.ngaynhap = ' 2001/01/14 ' ";
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select mathuoc as 'mã thuốc' , tenthuoc as 'tên thuốc' , gia as 'giá' , soluong as 'số lượng'  from sanpham  " + giatri ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable tim_taikhoan(string giatri)
        {
            
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from taikhoan  " + giatri ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable tim_hoadonbykhach(string giatri)
        {
            DataTable bang = new DataTable();
            openConnect();  
            string sql = "select  hoadon.mahd as 'mahd' , hoadon.id_khachhang as'id_khach' , khachhang.ten as 'tenkhach' , hoadon.ngaytao as 'ngaythanhtoan' , khachhang.sdt as 'sdt' , hoadon.tongtien as 'tổng tiền'   from hoadon, khachhang  where hoadon.id_khachhang = khachhang.id " + giatri + "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        // mã hóa md5

        public string mahoa(string data)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(data);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
            //MessageBox.Show(sb.ToString());
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa 
            //trong "X2" thành "x"
        }

        /// biểu đồ
        /// 
        public DataTable load_nam_hoadon()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT DISTINCT year(ngaytao) as 'nam' from hoadon   ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable tim_hoadon(string giatri)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * from hoadon   " + giatri;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_tong(string giatri)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT sum(tongtien) as 'tong' from hoadon " +giatri;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_tong_max(string giatri)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT max(tongtien) as 'tong' from hoadon " + giatri;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }


        public DataTable load_thoc_ganhh(string giatri) // load thuoc gan het han
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT COUNT(mathuoc) as 'soluong'  from sanpham where deleteed=0   " +giatri;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable load_thuoc_shh() // load thuoc sắp hết hạn < 2 tháng là hết hạn
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * , DATEDIFF(day, GETDATE(), ngayhethan )  as 'số ngày còn lại'  from sanpham where deleteed=0 and DATEDIFF(MONTH, GETDATE(), ngayhethan ) <2 ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }



    }
}
