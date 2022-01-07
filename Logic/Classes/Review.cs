using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class Review
    {
        public int ReviewID { get; set; }
        public string ReviewerID { get; set; }
        protected string Text { get; set; }
        protected string stars { get; set; }
        
        protected string changeText(string tempText)
        {
            if (tempText.Length < 100)
            {
                this.Text = tempText;
                return "Succes";
            }
            else
            {
                return "Failed";
            }
        }
        protected string changeStars(string tempStars)
        {
            if (tempStars.Length < 6)
            {
                this.stars = tempStars;
                return "Succes";
            }
            else
            {
                return "Failed";
            }
        }
        protected int generateReviewID(int ReviewType)
        {
            Random random = new Random();
            int i = random.Next();
            string tempIDString = i.ToString();
            tempIDString = "1" + tempIDString;

            return Convert.ToInt32(tempIDString);
        }
        }
    }
