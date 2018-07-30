using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.Models.ReviewModel
{
    public class ReviewModel : List<CommentModel>
    {
        public string UserName { get; set; }

        public string Avatar { get; set; }

        public string MessageText { get; set; }
        /// <summary>
        /// дата и время 00.00.0000 00:00
        /// </summary>
        public string Date { get; set; }

        public string MessageInfo => $"{UserName}・{Date}";

        public int PositivRating { get; set; }

        public int NegativeRating { get; set; }
    }
}
