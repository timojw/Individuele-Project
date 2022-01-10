using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Logic
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public int ReviewerID { get; set; }
        protected string Text { get; set; }
        protected int Stars { get; set; }

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
        protected string changeStars(int _Stars)
        {
            if (_Stars < 6)
            {
                this.Stars = _Stars;
                return "Succes";
            }
            else
            {
                return "Failed";
            }
        }
    }
}
