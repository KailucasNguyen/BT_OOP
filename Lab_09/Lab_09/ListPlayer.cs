﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    public class PlayerList : ISerializable
    {
        private List<Player> players = new List<Player>();
        public List<Player> Players { get => players; set => players = value; }
        public PlayerList() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Players", Players);
        }
        public PlayerList(SerializationInfo info, StreamingContext context)
        {
            Players = (List<Player>)info.GetValue("players", typeof(List<Player>));
        }
        public void Add(Player item)
        {
            Players.Add(item);
        }
    }
}
