using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace View.Models
{
    class ReviewViewModel
    {
        [Key]
        public int ID { get; set; }
        public int ReviewerID { get; set; }
        protected string Text { get; set; }
        protected string Stars { get; set; }

        protected void changeText(string tempText)
        {
            if (tempText.Length < 100)
            {
                this.Text = tempText;
            }
            else
            {
            }
        }
        protected void changeStars(string tempStars)
        {
            if (tempStars.Length < 6)
            {
                this.Stars = tempStars;
            }
            else
            {
            }
        }

    }
}
