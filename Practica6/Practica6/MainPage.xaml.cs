﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;

namespace Practica6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            SQLiteAsyncConnection database;

            string db;

            db = DependencyService.Get<SQLI>().GetLocalFilePath("Practica");
            database = new SQLiteAsyncConnection(db);
            database.CreateTableAsync<BaseDatos>().Wait();
        }
    }
}
