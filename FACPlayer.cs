﻿#region Using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Timers;
using Terraria;
using TShockAPI;
#endregion

namespace FACommands
{
    public class FACPlayer
    {
        public int Index { get; set; }
        public TSPlayer TSPlayer { get { return TShock.Players[Index]; } }
        public string ranklist { get; set; }
        public int moreCD { get; set; }
        public int slayCD { get; set; }
        public int fartCD { get; set; }
        public int tickleCD { get; set; }
        public int pokeCD { get; set; }
        public int spokeCD { get; set; }
        public int hugCD { get; set; }
        public int lickCD { get; set; }
        public int facepalmCD { get; set; }
        public int kissCD { get; set; }
        public int babyCD { get; set; }
        public int stabCD { get; set; }
        public int loveCD { get; set; }
        public int faceplantCD { get; set; }
        public int slapallCD { get; set; }
        public int giftCD { get; set; }
        public int disturbCD { get; set; }
        public int bankCD { get; set; }
        public FACPlayer(int index)
        { this.Index = index; }
    }
}