﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattleApp.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Bananas { get; set; } = 1000;

        public void EatBananas(int amount)
        {
            Bananas -= amount;
            BannasChanged();
        }

        public void AddBananas(int amount)
        {
            Bananas += amount;
            BannasChanged();
        }

        void BannasChanged() => OnChange.Invoke();
    }
}
