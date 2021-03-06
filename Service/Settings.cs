﻿using Gecko.WebIDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Diplom2
{
    static class Settings
    {
        static public int countQuestions = 10;
        static public bool ShowAnswers = true;
        static public bool ShowMenuStrip = false;
        public static int textQuestion = 90;
        public static int checkQuestion = 60;
        public static int radioQuestion = 45;
        public static string pathContent = "";

        public static string DBUser = "root";
        public static string DBPassword = "";
        public static string DBServer = "localhost";
        public static string DBName = "ремонтиукладкакровли";
        public static SettingsData getSettings() 
        {
            SettingsData settingsData = new SettingsData
            {
                checkQuestion = checkQuestion,
                ShowAnswers = ShowAnswers,
                ShowMenuStrip = ShowMenuStrip,
                textQuestion = textQuestion,
                countQuestions = countQuestions,
                radioQuestion = radioQuestion,
                pathContent = pathContent,
                DBUser = DBUser,
                DBPassword = DBPassword,
                DBServer = DBServer,
                DBName = DBName
            };
            return settingsData;
        }

        public static void setSettings(SettingsData settingsData)
        {
            checkQuestion = settingsData.checkQuestion;
            ShowAnswers = settingsData.ShowAnswers;
            ShowMenuStrip = settingsData.ShowMenuStrip;
            textQuestion = settingsData.textQuestion;
            countQuestions = settingsData.countQuestions;
            radioQuestion = settingsData.radioQuestion;
            pathContent = settingsData.pathContent;
            DBUser = settingsData.DBUser;
            DBPassword = settingsData.DBPassword;
            DBServer = settingsData.DBServer;
            DBName = settingsData.DBName;
        }
    }

    class SettingsData 
    {
        public int countQuestions { get; set; }
        public bool ShowAnswers { get; set; }
        public bool ShowMenuStrip { get; set; }
        public int textQuestion { get; set; }
        public int checkQuestion { get; set; }
        public int radioQuestion { get; set; }
        public string pathContent { get; set; }
        public string DBUser { get; set; }
        public string DBPassword { get; set; }
        public string DBServer { get; set; }
        public string DBName { get; set; }

    }
}
