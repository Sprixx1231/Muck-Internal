using UnityEngine;
using Steamworks;
using Steamworks.Data;

namespace Muckus_Fuckus_Internal
{
    public class Achievement : MonoBehaviour
    {
        public void Start()
        {

            SteamUserStats.AddStat("WinsEasy", 1);
            SteamUserStats.AddStat("WinsNormal", 1);
            SteamUserStats.AddStat("WinsGamer", 1);
            SteamUserStats.AddStat("GamerMove", 1);

            SteamUserStats.AddStat("Speedrunner", 1);
            SteamUserStats.AddStat("NoPowerups", 1);
            
            SteamUserStats.AddStat("Untouchable", 1);
            SteamUserStats.AddStat("Dream Team", 1);
            SteamUserStats.AddStat("The bois", 1);
            SteamUserStats.AddStat("Sweat and tears", 1);
            
            SteamUserStats.AddStat("Caveman", 1);
            SteamUserStats.AddStat("Muck", 1); 
            SteamUserStats.AddStat("GamesWon", 999);
            
            SteamUserStats.AddStat("Set sail", 1);
            
            SteamUserStats.AddStat("Kills", 999999);
            SteamUserStats.AddStat("TotalKills", 9999999);
            SteamUserStats.AddStat("BowKills", 99999);
            SteamUserStats.AddStat("BuffKills", 9999);
            SteamUserStats.AddStat("Cow Kills", 9999);
            SteamUserStats.AddStat("BigChunkKills", 9999);
            SteamUserStats.AddStat("GronkKills", 9999);
            SteamUserStats.AddStat("GuardianKills", 9999);
            SteamUserStats.AddStat("GoblinKills", 9999);
            SteamUserStats.AddStat("WoodmanKills", 9999);
            
            SteamUserStats.AddStat("Fearless", 1);
            SteamUserStats.AddStat("Battle totems started", 9999);
            SteamUserStats.AddStat("Revives", 9999);
            
            SteamUserStats.AddStat("Drown", 9999);
            SteamUserStats.AddStat("Deaths", 9999);
            SteamUserStats.AddStat("TotalDeaths", 9999);
            
            SteamUserStats.AddStat("Chests opened", 9999);
            SteamUserStats.AddStat("TotalChestsOpened", 9999);
            
            SteamUserStats.AddStat("CoinsCrafted", 9999);
            
            SteamUserStats.AddStat("Builds", 9999);
            
            SteamUserStats.SetStat("Longest survived", 9999);
            
            SteamUserStats.AddStat("The Black Swordsman", 9999);
            
            SteamUserStats.AddStat("Milkman", 9999);
            
            SteamUserStats.AddStat("Move Distance", 999999999);
            SteamUserStats.AddStat("Swim distance", 999999999);
            
            SteamUserStats.AddStat("Red shrooms eaten", 99999);
            
            SteamUserStats.AddStat("Friendly Kills", 9999);
            
            SteamUserStats.AddStat("Jumps", 99999);
            
            SteamUserStats.AddStat("AllGems", 9999);
            
            SteamUserStats.AddStat("Karlson monitor", 9999);
            
            SteamUserStats.AddStat("Muck started", 9999);
            
            SteamUserStats.AddStat("GamesStarted", 99999);
            SteamUserStats.AddStat("Easy", 9999);
            SteamUserStats.AddStat("Normal", 9999);
            SteamUserStats.AddStat("Gamer", 9999);
            
            SteamUserStats.AddStat("ChiefChests", 9999);
            
            SteamUserStats.AddStat("Muck Off", 50); 

            SteamUserStats.AddStat("Salty", 1); 
            
            SteamUserStats.StoreStats();
        }

    }
}