﻿using Server;
using System;
using System.Collections.Generic;
namespace Server
{
    public class Table
    {
        public const string CreateTableSuccess = "Table created";
        public const string InsertSuccess = "Tuple added";
        public const string TupleDeleteSuccess = "Tuple(s) deleted";
        public const string TupleUpdateSuccess = "Tuple(s) updated";
        public const string TableAlreadyExists = Error + "Table exists already";
        public const string ColumnDoesNotExist = Error + "Column does not exist";
        public const string TableDoesNotExist = Error + "Table does not exist";
        public const string Error = "ERROR: ";
        public const string WrongSyntax = Error + "Syntactical error";
        public const string IncorrectDataType = Error + "Incorrect data type";
        public Table newTable;
        List<TableColumn> ListTableCol = new List<TableColumn>(){};

        public Table()
        {
        }
        public Table(string tableName, int numColumns)
        {
            Table newtable = new Table(tableName, numColumns);
        }
        public string createTable(string tableName, int numColumns)
        {
            newTable = new Table(tableName, numColumns);
            return CreateTableSuccess;
        }
        public void addAttribute(string name, DataType newTipo)
        {
            this.newTable.ListTableCol.Add(new TableColumn(name, newTipo));      
        }
        //Create the table

            void EXAMPLE(DataType2 dataType)
        {
            if (dataType == DataType2.DOUBLE)
                ;

        }
        
        DataType asdf = new DataType();
        //TableColumn colName = new TableColumn("name", DataType2.TEXT); 
        //TableColumn colEmail= new TableColumn("Email",DataType.Email); 
        //List<TableColumn> tableColumns = new List<TableColumn>(){colId, colName, colEmail};

        //Insert data

        //Table.AddTuple(new List<string>(){“1”, “Maider”, “maider@hotmail.com”}; 
        //table.AddTuple(new List<string>(){“2”, “Adolfo”, “adolfo@gmail.com”}; 

        //Add the table to the database 

        //db.AddTable(table); 

        //Print all the tuples from the tables and close it 

        //Console.WriteLine(db.SelectAllTuples(“myTable”)); db.Close(); 


    }


}