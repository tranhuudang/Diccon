﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccon
{
    internal class quote
    {
        private string[] quote_english =
        {
            "Don’t wish it were easier; wish you were better.",
            "There are no limits!",
            "Courage + work = success",
            "There are no shortcuts to any place worth going.",
            "One day, all your hard work will pay off.",
            "Do what is right, not what is easy.",
            "It’s never too late to be what you might have been.",
            "To change your life, you must first change your day.",
            "Don’t stop until you’re proud.",
            "You may see me struggle but you will never see me quit.",
            "Work hard in silence. Let success make the noise.",
            "Winners will fail over and over again until they succeed.",
            "Allow yourself to be a beginner. No one starts off being excellent.",
            "The man on top of the mountain didn’t fall there.",
            "The difference between ordinary and extraordinary is that little extra.",
            "Be so good they can’t ignore you.",
            "Vision without execution is just hallucination.",
            "If your dreams don’t scare you, they aren’t big enough.",
            "The distance between dreams and reality is called action.",
            "The thing about motivated people chasing their dream is they look crazy to lazy people.",
            "If you have self-esteem, you give yourself the audacity to dream big.",
            "Never let small minds convince you that your dreams are too big.",
            "What we truly need to do is often what we most feel like avoiding.",
            "Productivity boils down to two steps: identify the essential, then eliminate the rest.",
            "The goal is not simply to get more done, but also to have less to do.",
            "Hard work beats talent when talent doesn’t work hard.",
            "Focus on being productive instead of busy.",
            "Worrying is silly. It’s like wandering around with an umbrella waiting for it to rain.",
            "Impossible is not a fact. It is an opinion.",
        };
        string[] quote_vietnamese = { };
        /// <summary>
        /// Get a specific quote with given language
        /// </summary>
        /// <param name="number">An integer number</param>
        /// <param name="language">Use vi as Vietnamese and en English</param>
        /// <returns></returns>
        public string getQuote(int number, string language)
        {
            string outQuote= null;
            switch (language)
            {
                case "vi":
                    outQuote = quote_vietnamese[number];
                    break;
                    case "en":
                    outQuote = quote_english[number];
                    break;
                default:
                    break;
            }
            return "\"" + outQuote + "\"";
        }
        /// <summary>
        /// Get a random quote by a given language
        /// </summary>
        /// <param name="language">Use vi as Vietnamese and en English</param>
        /// <returns></returns>
        public string getQuote(string language)
        {
            Random random = new Random();
            string outQuote = null;
            switch (language)
            {
                case "vi":
                    outQuote = quote_vietnamese[random.Next(quote_vietnamese.Length)];
                    break;
                case "en":
                    outQuote =  quote_english[random.Next(quote_english.Length)];
                    break;
                default:
                    break;
            }
            return "\"" + outQuote + "\"";
        }
    }
}