﻿using IRunes.Database;
using IRunes.Database.Models;

using SIS.MvcFramework;
using SIS.MvcFramework.Attributes.HttpAttributes;
using SIS.MvcFramework.Attributes.SecurityAttributes;
using SIS.MvcFramework.Results;

using System;
using System.Linq;
using System.Web;

namespace IRunes.App.Controllers
{
    public class TracksController : Controller
    {
        [Authorize]
        public ActionResult Create()
        {
            string albumId = (string)this.Request.QueryData["albumId"];
            this.ViewData.Clear();
            this.ViewData.Add("@albumId", albumId);
            return this.View();
        }

        [Authorize]
        [HttpPost(ActionName = "Create")]
        public ActionResult HandleCreatingTrack()
        {
            string albumId = (string)this.Request.QueryData["albumId"];

            string trackName = (string)this.Request.FormData["name"];
            string link = (string)this.Request.FormData["link"];
            decimal price = decimal.Parse((string)this.Request.FormData["price"]);

            using (IRunesDbContext runesDbContext = new IRunesDbContext())
            {
                runesDbContext.Albums.Find(albumId).Tracks.Add(new Track()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = HttpUtility.UrlDecode(trackName),
                    Link = HttpUtility.UrlDecode(link),
                    Price = price
                });

                runesDbContext.SaveChanges();
            }

            return this.Redirect($"/Albums/Details?id={albumId}");
        }

        [Authorize]
        public ActionResult Details()
        {
            string albumId = (string)this.Request.QueryData["albumId"];
            string trackId = (string)this.Request.QueryData["trackId"];

            using (IRunesDbContext dbContext = new IRunesDbContext())
            {
                Album album = dbContext.Albums.Find(albumId);
                Track track = album.Tracks.First(t => t.Id == trackId);
                this.ViewData.Clear();
                this.ViewData.Add("@Link", track.Link);
                this.ViewData.Add("@Name", track.Name);
                this.ViewData.Add("@Price", track.Price.ToString());
                this.ViewData.Add("@albumId", album.Id);

                return this.View();

            }
        }
    }
}
