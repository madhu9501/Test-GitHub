using System;
using UnityEngine;

namespace TestGitHub
{
    public class TestClass
    {
        private int _id;
        private string _name;
        private string _health;

        public TestClass(int id, string name,string health)
        {
            _id = id;
            _name = name;
            _health = health;
        }
    }
}