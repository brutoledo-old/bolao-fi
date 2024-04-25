using BolaoDoFi.Core.Models;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;

namespace BolaoDoFi.Import // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var files = Directory.GetFiles("Bets/", "*.xlsx").ToList();
            Console.WriteLine($"Found {files.Count} Excels");

            var players = new List<PlayerBets>();
            foreach (var file in files)
            {
                //var fileInfo = new FileInfo("Bets/BOLÃO DA COPA DO MUNDO 2022 QATAR_Bruno Toledo.xlsx")
                var fileInfo = new FileInfo(file);
                
                var fileNameSplit = Path.GetFileNameWithoutExtension(fileInfo.Name).Split(new[] { '_' });
            
                using (var package = new ExcelPackage(fileInfo))
                {
                    var palpitesSheet = package.Workbook.Worksheets["Palpites"];

                    var playerBets = new PlayerBets()
                    {
                        Name = fileNameSplit[1],
                        GameA1 = new BetOnTheGame(palpitesSheet.Cells["D5"].Text, palpitesSheet.Cells["F5"].Text),
                        GameA2 = new BetOnTheGame(palpitesSheet.Cells["D6"].Text, palpitesSheet.Cells["F6"].Text),
                        GameA3 = new BetOnTheGame(palpitesSheet.Cells["D7"].Text, palpitesSheet.Cells["F7"].Text),
                        GameA4 = new BetOnTheGame(palpitesSheet.Cells["D8"].Text, palpitesSheet.Cells["F8"].Text),
                        GameA5 = new BetOnTheGame(palpitesSheet.Cells["D9"].Text, palpitesSheet.Cells["F9"].Text),
                        GameA6 = new BetOnTheGame(palpitesSheet.Cells["D10"].Text, palpitesSheet.Cells["F10"].Text),

                        GameB1 = new BetOnTheGame(palpitesSheet.Cells["D14"].Text, palpitesSheet.Cells["F14"].Text),
                        GameB2 = new BetOnTheGame(palpitesSheet.Cells["D15"].Text, palpitesSheet.Cells["F15"].Text),
                        GameB3 = new BetOnTheGame(palpitesSheet.Cells["D16"].Text, palpitesSheet.Cells["F16"].Text),
                        GameB4 = new BetOnTheGame(palpitesSheet.Cells["D17"].Text, palpitesSheet.Cells["F17"].Text),
                        GameB5 = new BetOnTheGame(palpitesSheet.Cells["D18"].Text, palpitesSheet.Cells["F18"].Text),
                        GameB6 = new BetOnTheGame(palpitesSheet.Cells["D19"].Text, palpitesSheet.Cells["F19"].Text),

                        GameC1 = new BetOnTheGame(palpitesSheet.Cells["D23"].Text, palpitesSheet.Cells["F23"].Text),
                        GameC2 = new BetOnTheGame(palpitesSheet.Cells["D24"].Text, palpitesSheet.Cells["F24"].Text),
                        GameC3 = new BetOnTheGame(palpitesSheet.Cells["D25"].Text, palpitesSheet.Cells["F25"].Text),
                        GameC4 = new BetOnTheGame(palpitesSheet.Cells["D26"].Text, palpitesSheet.Cells["F26"].Text),
                        GameC5 = new BetOnTheGame(palpitesSheet.Cells["D27"].Text, palpitesSheet.Cells["F27"].Text),
                        GameC6 = new BetOnTheGame(palpitesSheet.Cells["D28"].Text, palpitesSheet.Cells["F28"].Text),

                        GameD1 = new BetOnTheGame(palpitesSheet.Cells["D32"].Text, palpitesSheet.Cells["F32"].Text),
                        GameD2 = new BetOnTheGame(palpitesSheet.Cells["D33"].Text, palpitesSheet.Cells["F33"].Text),
                        GameD3 = new BetOnTheGame(palpitesSheet.Cells["D34"].Text, palpitesSheet.Cells["F34"].Text),
                        GameD4 = new BetOnTheGame(palpitesSheet.Cells["D35"].Text, palpitesSheet.Cells["F35"].Text),
                        GameD5 = new BetOnTheGame(palpitesSheet.Cells["D36"].Text, palpitesSheet.Cells["F36"].Text),
                        GameD6 = new BetOnTheGame(palpitesSheet.Cells["D37"].Text, palpitesSheet.Cells["F37"].Text),

                        GameE1 = new BetOnTheGame(palpitesSheet.Cells["D41"].Text, palpitesSheet.Cells["F41"].Text),
                        GameE2 = new BetOnTheGame(palpitesSheet.Cells["D42"].Text, palpitesSheet.Cells["F42"].Text),
                        GameE3 = new BetOnTheGame(palpitesSheet.Cells["D43"].Text, palpitesSheet.Cells["F43"].Text),
                        GameE4 = new BetOnTheGame(palpitesSheet.Cells["D44"].Text, palpitesSheet.Cells["F44"].Text),
                        GameE5 = new BetOnTheGame(palpitesSheet.Cells["D45"].Text, palpitesSheet.Cells["F45"].Text),
                        GameE6 = new BetOnTheGame(palpitesSheet.Cells["D46"].Text, palpitesSheet.Cells["F46"].Text),

                        GameF1 = new BetOnTheGame(palpitesSheet.Cells["D50"].Text, palpitesSheet.Cells["F50"].Text),
                        GameF2 = new BetOnTheGame(palpitesSheet.Cells["D51"].Text, palpitesSheet.Cells["F51"].Text),
                        GameF3 = new BetOnTheGame(palpitesSheet.Cells["D52"].Text, palpitesSheet.Cells["F52"].Text),
                        GameF4 = new BetOnTheGame(palpitesSheet.Cells["D53"].Text, palpitesSheet.Cells["F53"].Text),
                        GameF5 = new BetOnTheGame(palpitesSheet.Cells["D54"].Text, palpitesSheet.Cells["F54"].Text),
                        GameF6 = new BetOnTheGame(palpitesSheet.Cells["D55"].Text, palpitesSheet.Cells["F55"].Text),

                        GameG1 = new BetOnTheGame(palpitesSheet.Cells["D59"].Text, palpitesSheet.Cells["F59"].Text),
                        GameG2 = new BetOnTheGame(palpitesSheet.Cells["D60"].Text, palpitesSheet.Cells["F60"].Text),
                        GameG3 = new BetOnTheGame(palpitesSheet.Cells["D61"].Text, palpitesSheet.Cells["F61"].Text),
                        GameG4 = new BetOnTheGame(palpitesSheet.Cells["D62"].Text, palpitesSheet.Cells["F62"].Text),
                        GameG5 = new BetOnTheGame(palpitesSheet.Cells["D63"].Text, palpitesSheet.Cells["F63"].Text),
                        GameG6 = new BetOnTheGame(palpitesSheet.Cells["D64"].Text, palpitesSheet.Cells["F64"].Text),

                        GameH1 = new BetOnTheGame(palpitesSheet.Cells["D68"].Text, palpitesSheet.Cells["F68"].Text),
                        GameH2 = new BetOnTheGame(palpitesSheet.Cells["D69"].Text, palpitesSheet.Cells["F69"].Text),
                        GameH3 = new BetOnTheGame(palpitesSheet.Cells["D70"].Text, palpitesSheet.Cells["F70"].Text),
                        GameH4 = new BetOnTheGame(palpitesSheet.Cells["D71"].Text, palpitesSheet.Cells["F70"].Text),
                        GameH5 = new BetOnTheGame(palpitesSheet.Cells["D72"].Text, palpitesSheet.Cells["F72"].Text),
                        GameH6 = new BetOnTheGame(palpitesSheet.Cells["D73"].Text, palpitesSheet.Cells["F73"].Text)
                    };

                    players.Add(playerBets);
                }
            }


            // Generate all players bet
            //var json = JsonConvert.SerializeObject(players);
            //File.WriteAllText(@"C:\temp\player_bets.json", json);

            var game1Bets = players.Select(p => new { p.Name, p.GameA1 });

            var gameA1Statistics = game1Bets
                .OrderBy(b => b.GameA1.Team1Goals)
                .ThenBy(b => b.GameA1.Team2Goals)
                .GroupBy(p => p.GameA1.Formatted)
                .ToDictionary(g => g.Key, g => g.ToList());

            var json = JsonConvert.SerializeObject(gameA1Statistics);
            foreach (var results in gameA1Statistics)
            {
                
            }


        }

        private void Sample(ExcelPackage package)
        {
            var firstSheet = package.Workbook.Worksheets["First Sheet"];
            Console.WriteLine("Sheet 1 Data");
            Console.WriteLine($"Cell A2 Value   : {firstSheet.Cells["A2"].Text}");
            Console.WriteLine($"Cell A2 Color   : {firstSheet.Cells["A2"].Style.Font.Color.LookupColor()}");
            Console.WriteLine($"Cell B2 Formula : {firstSheet.Cells["B2"].Formula}");
            Console.WriteLine($"Cell B2 Value   : {firstSheet.Cells["B2"].Text}");
            Console.WriteLine($"Cell B2 Border  : {firstSheet.Cells["B2"].Style.Border.Top.Style}");
            Console.WriteLine("");

            var secondSheet = package.Workbook.Worksheets["Second Sheet"];
            Console.WriteLine($"Sheet 2 Data");
            Console.WriteLine($"Cell A2 Formula : {secondSheet.Cells["A2"].Formula}");
            Console.WriteLine($"Cell A2 Value   : {secondSheet.Cells["A2"].Text}");
        }
    }
}