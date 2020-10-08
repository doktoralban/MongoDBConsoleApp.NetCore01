using MongoDB.Entities;
using System;

namespace MongoDBConsoleApp.NetCore01
{
    internal class Person : Entity
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int SiblingCount { get; set; }
    }
}