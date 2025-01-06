using FeedOptimisationApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedOptimisationApp.Database;

public class ApplicationDbContext
{
    public SQLiteAsyncConnection _dbConnection;

    //Application Db
    public static readonly string nameSpace = "FeedOptimisationApp.Database.";

    public const string DatabaseFileName = "FeedOptimisationApp.Database.db3";

    public static string databasePath = Path.Combine(FileSystem.AppDataDirectory, DatabaseFileName);

    public const SQLiteOpenFlags Flags =
        SQLiteOpenFlags.ReadWrite |
        SQLiteOpenFlags.Create |
        SQLiteOpenFlags.SharedCache;

    public ApplicationDbContext()
    {
        if (_dbConnection == null)
        {
            _dbConnection = new SQLiteAsyncConnection(databasePath, Flags);
            _dbConnection.CreateTableAsync<Calculation>().Wait();
            _dbConnection.CreateTableAsync<CalculationHasFeed>().Wait();
            _dbConnection.CreateTableAsync<CalculationHasResult>().Wait();
            _dbConnection.CreateTableAsync<CountryTranslation>().Wait();
            _dbConnection.CreateTableAsync<Feed>().Wait();
            _dbConnection.CreateTableAsync<FeedTranslation>().Wait();
            _dbConnection.CreateTableAsync<FeedOptimisationApp.Models.Label>().Wait();
            _dbConnection.CreateTableAsync<LabelTranslation>().Wait();
            _dbConnection.CreateTableAsync<LanguageTranslation>().Wait();
            _dbConnection.CreateTableAsync<RefCountry>().Wait();
            _dbConnection.CreateTableAsync<RefLanguage>().Wait();
            _dbConnection.CreateTableAsync<RefSpecies>().Wait();
            _dbConnection.CreateTableAsync<SpeciesTranslation>().Wait();
            _dbConnection.CreateTableAsync<User>().Wait();
        }
    }
}