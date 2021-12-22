using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    class Review
    {
        public int reviewID { get; set; }
        public string reviewerID { get; set; }
        protected string text { get; set; }
        protected string stars { get; set; }
        
        protected string changeText(string tempText)
        {
            if (tempText.Length < 100)
            {
                this.text = tempText;
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
