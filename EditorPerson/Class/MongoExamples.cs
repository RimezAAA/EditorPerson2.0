using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Windows;
using System.Windows.Controls;

namespace EditorPerson
{
    class MongoExamples
    {
        public static void AddToDB(Character user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharactersDataBaseArt");
            var collection = database.GetCollection<Character>("Characters");
            collection.InsertOne(user);

        }
        public static void FindAll(ListView listWin)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharactersDataBaseArt");
            var collection = database.GetCollection<Character>("Characters");
            var list = collection.Find(x => true).ToList();
            listWin.ItemsSource = list;
        }

        public static Character Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharactersDataBaseArt");
            var collection = database.GetCollection<Character>("Characters");
            var one = collection.Find(x => x.name == name).FirstOrDefault();
            return one;
        }

        public static void ReplaceByName(string name, Character character)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CharactersDataBaseArt");
            var collection = database.GetCollection<Character>("Characters");
            collection.ReplaceOne(x => x.name == name, character);
        }
    }
}
