﻿using AbstractJewelryShopListImplement.Models;
using System.Collections.Generic;

namespace AbstractJewelryShopListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;

        public List<Component> Components { get; set; }

        public List<Order> Orders { get; set; }

        public List<Jewel> Jewels { get; set; }

        public List<Client> Clients { get; set; }

        private DataListSingleton()
        {
            Components = new List<Component>();
            Orders = new List<Order>();
            Jewels = new List<Jewel>();
            Clients = new List<Client>();
        }

        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
