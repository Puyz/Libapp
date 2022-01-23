using System;
using MySql.Data.MySqlClient;
using Libapp.Functions;
using Encrypt;
using System.Data;
using Libapp.Mail;
using Libapp.Models;

namespace Libapp.Database
{
    public class MySqlDatabaseManager : BaseDatabaseManager
    {
        MySqlConnection connection = new MySqlConnection("SERVER=trlinux.kayizer.com;DATABASE=puyznet_libapp;UID=puyznet_omer;PWD=Omertemel123.@1;SSL Mode=None");
        CodeCreator codeCreator = new CodeCreator();
        EncryptClass encryptClass = new EncryptClass();

        // Login
        protected override void addLogin(MemberLogin memberLogin)
        {
            if (connection.State != ConnectionState.Open) { connection.Open(); }
            string queryString = "insert into GirisBilgileri(kullanici_id,email,sifre,yetki) values (@kullanici_id, @email, @sifre, @yetki)";
            MySqlCommand cmd = new MySqlCommand(queryString, connection);
            cmd.Parameters.AddWithValue("@kullanici_id", memberLogin.memberID);
            cmd.Parameters.AddWithValue("@email", memberLogin.email);
            cmd.Parameters.AddWithValue("@sifre", encryptClass.Encrypt(memberLogin.password.ToString()));
            cmd.Parameters.AddWithValue("@yetki", memberLogin.authority);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void deleteLogin(Member member)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"delete from GirisBilgileri where kullanici_id='{member.memberID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public override bool isUserExists(MemberLogin memberLogin)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            memberLogin.password = encryptClass.Encrypt(memberLogin.password);
            string query = $"Select * from GirisBilgileri where email='{memberLogin.email}' AND sifre='{memberLogin.password}' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            bool isExists = (read.Read()) ? true : false;
            connection.Close();
            return isExists;
        }

        public override Member GetMemberFromMemberLogin(MemberLogin memberLogin)
        {
            Member member = new Member();
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"Select * from KullaniciBilgileri where email='{memberLogin.email}' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                member.memberID = Convert.ToInt32(read["id"].ToString());
                member.name = read["adisoyadi"].ToString();
                member.identity = read["kimlikno"].ToString();
                member.gender = read["cinsiyet"].ToString();
                member.date = read["dogumtarihi"].ToString();
                member.email = read["email"].ToString();
                member.phone = read["telefonno"].ToString();
                member.dateOfRegistration = read["kayittarihi"].ToString();
            }
            connection.Close();
            return member;
        }
        public override int GetAuthority(MemberLogin memberLogin)
        {
            int yetki = 0;
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"Select yetki from GirisBilgileri where email='{memberLogin.email}' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                yetki = Convert.ToInt32(read["yetki"].ToString());
            }
            connection.Close();
            return yetki;
        }



        public override bool emailControl(string email)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"Select * from  KullaniciBilgileri where email='{email}' ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            bool isExists = (read.Read()) ? true : false;
            connection.Close();
            return isExists;
        }

        public override bool memberControl(Member member)
        {
            string Query = $"Select * from KullaniciBilgileri where email='{member.email}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            bool isExists = (read.Read()) ? true : false;
            connection.Close();
            return isExists;
        }

        public override int getId(string mail)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"Select id from KullaniciBilgileri where email='{mail}' ";
            int id = 0;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                id = Convert.ToInt32(read["id"].ToString());
            }
            connection.Close();
            return id;
        }

        public override void resetPassword(int id, string sifre)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"UPDATE GirisBilgileri SET sifre='{encryptClass.Encrypt(sifre)}' WHERE kullanici_id='{id}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        // User control -> books
        public override DataTable booksGridDataSource()
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = "Select * from KitapListesi";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        //  User control -> members
        public override DataTable membersGridDataSource()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = "SELECT KullaniciBilgileri.* FROM GirisBilgileri INNER JOIN KullaniciBilgileri ON GirisBilgileri.kullanici_id = KullaniciBilgileri.id AND GirisBilgileri.yetki=1";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public override DataTable usersGridDataSource()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = "SELECT * FROM KullaniciBilgileri";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        // User control -> logs
        public override DataTable logsGridDataSource()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = "Select * from Gecmis";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        // Book
        public override void addBook(Book book)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string Query = "insert into KitapListesi(kitapAdi,yazarAdi,rafAdi,durum) values(@kitapAdi,@yazarAdi,@rafAdi,@durum)";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@kitapAdi", book.bookName);
            cmd.Parameters.AddWithValue("@yazarAdi", book.authorName);
            cmd.Parameters.AddWithValue("@rafAdi", book.shelfName);
            cmd.Parameters.AddWithValue("@durum", "Teslim edilebilir");
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void editBook(Book book)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"UPDATE KitapListesi SET kitapAdi='{book.bookName}', yazarAdi='{book.authorName}', rafAdi='{book.shelfName}' where id='{book.id}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void deleteBook(Book book)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"delete from KitapListesi where id='{book.id}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void deliverBook(Book book, Member member)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = $"UPDATE KitapListesi SET teId={member.memberID}, teKisi='{member.name}', teTarih='{DateTime.Now.ToString()}', durum='Teslim edildi' where id={book.id}";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void receiveBook(Book book)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = $"UPDATE KitapListesi SET teId=null, teKisi=null, teTarih=null, durum='Teslim edilebilir' where id={book.id}";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override DataTable listMyBook(int teID)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"Select * from KitapListesi where teId={teID}";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        // Shelf
        public override bool isShelfExists(string name)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = $"Select * from RafListesi where rafAdi='{name}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            bool isExists = (read.Read()) ? true : false;
            connection.Close();
            return isExists;
        }
        public override DataTable fillShelfs()
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = "Select * from RafListesi";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public override DataTable filterShelfs(string name)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = $"Select * from RafListesi where rafAdi like '%{name}%'";
            connection.Open();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public override void shelfDeValue(Shelf shelf)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string Query = $"UPDATE RafListesi SET eklenebilirKitapSayisi = eklenebilirKitapSayisi-1 where RafAdi='{shelf.name}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void shelfReValue(Shelf shelf)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string Query = $"UPDATE RafListesi SET eklenebilirKitapSayisi = eklenebilirKitapSayisi+1 where RafAdi='{shelf.name}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public override void addShelf(Shelf shelf)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string Query = $"insert into RafListesi(rafAdi,eklenebilirKitapSayisi,kapasite) values('{shelf.name}', {shelf.capacity}, {shelf.capacity})";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void editShelf(Shelf shelf)
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = $"UPDATE RafListesi SET rafAdi='{shelf.name}', eklenebilirKitapSayisi =eklenebilirKitapSayisi+{shelf.free}  ,kapasite='{shelf.capacity}' where id='{shelf.id}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void deleteShelf(Shelf shelf)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"delete from RafListesi where id='{shelf.id}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Member
        public override Member getMember(int id)
        {
            Models.Member member = new Models.Member();

            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string query = $"Select * from KullaniciBilgileri where id={id}";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                member.name = read["adisoyadi"].ToString();
                member.identity = read["kimlikno"].ToString();
                member.gender = read["cinsiyet"].ToString();
                member.date = read["dogumTarihi"].ToString();
                member.email = read["email"].ToString();
                member.phone = read["telefonNo"].ToString();
                member.dateOfRegistration = read["kayittarihi"].ToString();
            }
            connection.Close();
            return member;

        }
        public override void addMember(Member member, int authority)
        {
            MemberLogin memberLogin = new MemberLogin();
            MailManager mailManager = new MailManager();
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
            string Query = $"insert into KullaniciBilgileri(adisoyadi,kimlikno,cinsiyet,dogumtarihi,email,telefonno) values('{member.name}','{member.identity}','{member.gender}','{member.date}','{member.email}','{member.phone}')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            memberLogin.password = mailManager.RandomPassword().ToString();
            memberLogin.memberID = Convert.ToInt32(cmd.LastInsertedId); // Last id
            memberLogin.authority = authority;
            memberLogin.email = member.email;
            mailManager.SendPasswordToMail(member.email, memberLogin.password, "Giriş bilgilerin");

            addLogin(memberLogin);
        }
        public override void editMember(Member member)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"UPDATE KullaniciBilgileri SET adisoyadi='{member.name}', kimlikno='{member.identity}', cinsiyet='{member.gender}', dogumtarihi='{member.date}', telefonno='{member.phone}'  where id='{member.memberID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public override void deleteMember(Member member)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"delete from KullaniciBilgileri where id='{member.memberID}'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        // Logs

        public override void addLog(string log)
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string Query = $"insert into Gecmis(olay,tarih) values(@olay,'{DateTime.Now}')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@olay", log);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public override void deteleLogs()
        {
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            string query = $"delete from Gecmis";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

    }
}
