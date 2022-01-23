using System;
using System.Data;
using Libapp.Models;

namespace Libapp.Database
{
    public abstract class BaseDatabaseManager
    {
        // Login
        abstract protected void addLogin(MemberLogin memberLogin);
        abstract public void deleteLogin(Member member);
        abstract public bool isUserExists(MemberLogin memberLogin);
        abstract public Member GetMemberFromMemberLogin(MemberLogin memberLogin);
        abstract public int GetAuthority(MemberLogin memberLogin);

        abstract public bool emailControl(string email);
        abstract public bool memberControl(Member member);
        abstract public int getId(string mail);
        abstract public void resetPassword(int id, string password);
        
        // User control ->  books
        abstract public DataTable booksGridDataSource();

        // User control -> members
        abstract public DataTable membersGridDataSource();
        abstract public DataTable usersGridDataSource();

        // User control -> logs
        abstract public DataTable logsGridDataSource();

        // Book
        abstract public void addBook(Book book);
        abstract public void editBook(Book book);
        abstract public void deleteBook(Book book);
        abstract public void deliverBook(Book book, Member member);
        abstract public void receiveBook(Book book);
        abstract public DataTable listMyBook(int teID);

        // Shelf
        abstract public bool isShelfExists(string name);
        abstract public DataTable fillShelfs();
        abstract public DataTable filterShelfs(string name);
        abstract public void shelfDeValue(Shelf shelf);
        abstract public void shelfReValue(Shelf shelf);
        abstract public void addShelf(Shelf shelf);
        abstract public void editShelf(Shelf shelf);
        abstract public void deleteShelf(Shelf shelf);

        // Members
        abstract public Member getMember(int id);
        abstract public void addMember(Member member, int authority);
        abstract public void editMember(Member member);
        abstract public void deleteMember(Member member);

        // Logs
        abstract public void addLog(string log);
        abstract public void deteleLogs();

    }
}
