using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using Libapp.Database;
using System;
using Libapp.Mail;
using Libapp.Models;

namespace Libapp.Functions
{
    class Members
    {
        BaseDatabaseManager dataBase = new MySqlDatabaseManager();
        public void clearDataGrid(ref GridControl gridControl)
        {
            gridControl.DataSource = null;
        }
        public void fillDataGrid(ref GridControl gridControl, int authority)
        {
            if (authority == 2)
            {
                gridControl.DataSource = dataBase.membersGridDataSource();
            }
            else
            {
                gridControl.DataSource = dataBase.usersGridDataSource();
            }
            
        }
        public void assignValue(ref Member member, ref GridView gridView)
        {
            member.memberID = Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            member.name = gridView.GetFocusedRowCellValue("adisoyadi").ToString();
            member.identity = gridView.GetFocusedRowCellValue("kimlikno").ToString();
            member.gender = gridView.GetFocusedRowCellValue("cinsiyet").ToString();
            member.date = gridView.GetFocusedRowCellValue("dogumtarihi").ToString();
            member.email = gridView.GetFocusedRowCellValue("email").ToString();
            member.phone = gridView.GetFocusedRowCellValue("telefonno").ToString();
            member.dateOfRegistration = gridView.GetFocusedRowCellValue("kayittarihi").ToString();
        }

        public void hideColumn(ref GridView gridView)
        {
            gridView.Columns["id"].Visible = false;
            gridView.Columns["kayittarihi"].Visible = false;

            //çizgi
            gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
        }

        public void filterData(string data, ref GridView gridView)
        {
            gridView.ActiveFilterString = $"adisoyadi LIKE '%{data}%' OR kimlikno LIKE '%{data}%' " +
                $"OR cinsiyet LIKE '%{data}%' OR email LIKE '%{data}%' OR telefonno LIKE '%{data}%'";
        }

        public bool memberControl(Member member)
        {
            return dataBase.memberControl(member);
        }
        public void addMember(Member member, int authority)
        {
            dataBase.addMember(member,authority);
        }
        public void editMember(Member member)
        {
            dataBase.editMember(member);
        }
        public void deleteMember(Member member)
        {
            dataBase.deleteMember(member);
        }
        public void deleteLogin(Member member)
        {
            dataBase.deleteLogin(member);
        }
        public Member getMember(int id)
        {
            return dataBase.getMember(id);
        }
        
    }
}
