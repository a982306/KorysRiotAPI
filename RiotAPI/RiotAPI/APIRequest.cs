using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Globalization;
using System.Collections;
using System.Threading;

namespace RiotAPI
{
    class APIRequest
    {
        #region Global Variables
        static RiotAPI.Properties.Settings ps = Properties.Settings.Default;
        #endregion

        #region Methods
        public static Dictionary<string, object> GetURL(string s)
        {
            WebRequest wrGetURL = WebRequest.Create(s);
            wrGetURL.Proxy = WebProxy.GetDefaultProxy();
            int i = 0;
            while (i < 3)
            {
                try
                {
                    Stream objstream = wrGetURL.GetResponse().GetResponseStream();
                    //throw new WebException();
                    StreamReader objreader = new StreamReader(objstream);
                    string read = "";
                    read = objreader.ReadLine();
                    if (read == null)
                        return null;
                    while (objreader.EndOfStream == false)
                    {
                        read += objreader.ReadLine();
                    }
                    var dic = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(read);
                    return dic;
                }
                catch (WebException ex)
                {
                    Thread.Sleep(1000);
                    i++;
                }
            }
            //throw new WebException();
            return null;
        }
        #endregion

        #region SubClasses
        public class MySummoner
        {
            #region Global Variables
            private static string Ranked = "https://prod.api.pvp.net/api/" +
                                                  ps.saveRegion +
                                                  "/v2.2/league/by-summoner/" +
                                                  ps.summonerID +
                                                  "?api_key=" +
                                                  ps.saveAPI;

            private static string SummonerURLString = "https://prod.api.pvp.net/api/lol/" +
                                                        ps.saveRegion +
                                                        "/v1.1/summoner/by-name/" +
                                                        ps.saveSummonerName +
                                                        "?api_key=" +
                                                        ps.saveAPI;

            public static string TierSolo;
            // public static string Tier5v5; // Not Yet Active
            // public static string Tier3v3; // Not Yet Active
            public static int Level;
            public static string SoloRank;
            public static int SoloWins;
            public static int SoloLosses;
            public static int SoloLeaguePoints;
            public static bool isSoloVeteran;
            public static bool isSoloFreshBlood;
            public static bool isSoloHotStreak;
            public static bool isSoloInactive;
            public static string SoloLeagueName;
            public static Dictionary<string, object> SummonerDic;
            public static List<Dictionary<string, object>> LeagueItemList = new List<Dictionary<string, object>>();
            #endregion

            #region Methods
            #region Web Requests
            //Web Requests
            public static Dictionary<string, object> SummonerWebRequest()
            {
                try
                {
                    SummonerDic = GetURL(SummonerURLString);
                }
                catch (Exception ex)
                {
                    throw new WebException();
                }
                return SummonerDic;
            }

            public static Dictionary<string, object> RankedDataWebRequest()
            {
                return GetURL(Ranked);
            }
            #endregion

            #region Data Requests
            public static void GetRankedQueueInfo(Dictionary<string, object> dic)
            {
                var RankedData = (Dictionary<string, object>)dic[ps.summonerID];
                var entries = (ArrayList)RankedData["entries"];
                TierSolo = RankedData["tier"].ToString();
                for (int i = 0; i < entries.Count; i++)
                {
                    var myEntry = (Dictionary<string, object>)entries[i];
                    if (myEntry["playerOrTeamId"].Equals(ps.summonerID))
                    {
                        SoloRank = myEntry["rank"].ToString();
                        SoloWins = (int)myEntry["wins"];
                        SoloLosses = (int)myEntry["losses"];
                        SoloLeaguePoints = (int)myEntry["leaguePoints"];
                        isSoloVeteran = (bool)myEntry["isVeteran"];
                        isSoloFreshBlood = (bool)myEntry["isFreshBlood"];
                        isSoloHotStreak = (bool)myEntry["isHotStreak"];
                        isSoloInactive = (bool)myEntry["isInactive"];
                        SoloLeagueName = (string)myEntry["leagueName"];
                    }

                    var everyEntry = (Dictionary<string, object>)entries[i];
                    LeagueItemList.Add(everyEntry);
                }

                //var Ranked5v5Data = (Dictionary<string, object>)dic.Where(pv => pv.Key.StartsWith("TEAM"));
                //for (int i = 0; i < Ranked5v5Data.Count; i++)
                {
                    //var temp = (Dictionary<string, object>)Ranked5v5Data.ElementAt(i);
                }
                return;
            }

            public static string GetName()
            {
               return SummonerDic["name"].ToString();
            }

            public static string GetID()
            {
                return SummonerDic["id"].ToString();
            }

            public static int GetSummonerLevel()
            {
                Level = (int)SummonerDic["summonerLevel"];
                return Level;
            }

            public static string GetRevisionDate()
            {
                string s = SummonerDic["revisionDateStr"].ToString();
                DateTime reviseTime = DateTime.ParseExact(s,
                    "MM/dd/yyyy hh:mm tt 'UTC'",
                    CultureInfo.InvariantCulture);
                reviseTime.AddHours(-5);
                return reviseTime.ToString("MM/dd/yyyy");
            }

            public static Image GetIcon()
            {
                WebRequest wrGetURL = WebRequest.Create(
                    "http://ddragon.leagueoflegends.com/cdn/" +
                    DDragVersion.GetCurrentDDRAGVersion() +
                    "/img/profileicon/" +
                    (int)SummonerDic["profileIconId"] +
                    ".png");
                wrGetURL.Proxy = WebProxy.GetDefaultProxy();
                Stream objstream = wrGetURL.GetResponse().GetResponseStream();
                return Image.FromStream(objstream);
            }

            public static void GetLeagueInfo()
            {
                var dic = (Dictionary<string, object>)MySummoner.RankedDataWebRequest();
                GetRankedQueueInfo(dic);
            }
            #endregion

            public static void UpdateURLRequest()
            {
                Ranked = "https://prod.api.pvp.net/api/" +
                                                  ps.saveRegion +
                                                  "/v2.1/league/by-summoner/" +
                                                  ps.summonerID +
                                                  "?api_key=" +
                                                  ps.saveAPI;

                SummonerURLString = "https://prod.api.pvp.net/api/lol/" +
                                                        ps.saveRegion +
                                                        "/v1.1/summoner/by-name/" +
                                                        ps.saveSummonerName +
                                                        "?api_key=" +
                                                        ps.saveAPI;
            }
            #endregion
        }
            

        class DDragVersion
        {
            #region Global Variables
            private static string VersionString = "http://ddragon.leagueoflegends.com/realms/na.json";
            #endregion

            #region Methods
            public static string GetCurrentDDRAGVersion()
            {
                return GetURL(VersionString)["v"].ToString();
                // Current v: 3.15.5
                // My ID: 35509949
                // http://ddragon.leagueoflegends.com/cdn/{version}/img/profileicon/{icon_id}.png
            }
            #endregion
        }
        #endregion
    }
}
