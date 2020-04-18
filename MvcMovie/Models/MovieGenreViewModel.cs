using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    //Add Search by genre
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        //包含內容類型清單的 SelectList 這可讓使用者從清單中選取內容類型
        public SelectList Genres { get; set; }
        //包含所選取內容類型的 MovieGenre
        public string MovieGenre { get; set; }
        //SearchString，其中包含使用者在搜尋文字方塊中輸入的文字
        public string SearchString { get; set; }
    }
}