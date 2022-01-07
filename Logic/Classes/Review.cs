using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logic
{
    class Review
    {
        [Key]
        public int ID { get; set; }
        public int ReviewerID { get; set; }
        protected string Text { get; set; }
        protected string Stars { get; set; }

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
                this.Stars = tempStars;
                return "Succes";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
