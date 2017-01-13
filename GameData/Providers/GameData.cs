﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameData.Models;

namespace GameData
{
    public class GameDataProvider
    {
        private List<Game> _games = new List<Game>();

        public GameDataProvider()
        {
            _games.Add(new Game() { Id = 1, Name = "The Sims 4", Year = 2014, GameType = new List<GameType>() { GameType.Simulations } });
            _games.Add(new Game() { Id = 2, Name = "Goat Symulator", Year = 2015, GameType = new List<GameType>() { GameType.Simulations } });
            _games.Add(new Game() { Id = 3, Name = "Fallout 4", Year = 2015, GameType = new List<GameType>() { GameType.Action, GameType.FPS, GameType.RPG } });
            _games.Add(new Game() { Id = 4, Name = "Witcher 3", Year = 2016, GameType = new List<GameType>() { GameType.Action, GameType.RPG } });
            _games.Add(new Game() { Id = 5, Name = "Fifa 2017", Year = 2016, GameType = new List<GameType>() { GameType.Sports } });
        }

        public List<Game> Get()
        {
            return _games.OrderBy(x => x.Id).ToList();
        }

        public List<Game> GetAsync()
        {
            return _games;
        }

        public Game GetAsync(int id)
        {
            return _games.FirstOrDefault(x => x.Id == id);
        }
    }
}