﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class User : INotifyPropertyChanged
    {
        public User(int id, string login, int points)
        {
            Id = id;
            Login = login;
            Points = points;
        }

        public int Id { get; set; }
        public string Login { get; set; }
        private int _points;
        public int Points 
        { 
            get
            {
                return _points;
            }
            set 
            {
                if(_points!=value)
                {
                    _points = value;
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Points"));
                }
                
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
