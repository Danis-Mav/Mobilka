using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ExamUser11.Pages;


namespace ExamUser11.Data
{
    public class DataAccess
    {
        SQLiteConnection database;
        public DataAccess(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<users>();
            database.CreateTable<passwords>();
        }
        //public int SavePass(users user)
        //{
            //return database.Insert();
        //}
        public List<passwords> GetPass()
        {
            return database.Table<passwords>().ToList();
        }
    }
}
