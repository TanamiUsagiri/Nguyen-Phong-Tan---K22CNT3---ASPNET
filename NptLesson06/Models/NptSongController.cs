using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NptLesson06.Models
{
    public class NptSongController : Controller
    {
        private static List<NptSong> NptSongs = new List<NptSong>()
        {
            new NptSong{ID = 2210900,NptTitle="NguyenPhongTan",NptAuthor="K22CNT3",NptArtist="NTU",NptYearRelease=2020 },
            new NptSong{ID = 1,NptTitle="NguyenPhongTan",NptAuthor="K22CNT3",NptArtist="Tanami",NptYearRelease=2020 }
        };
        // GET: NptSong
        //<summary>
        //Song List
        // Author: Tanami
        //<summary>
        //<returns></returns>
        public ActionResult NptIndex()
        {
            return View(NptSongs);
        }
        //Get NptCreate
        public ActionResult NptCreate()
        {
            var NptSong = new NptSong();
            return View(NptSong);
        }
    }
}