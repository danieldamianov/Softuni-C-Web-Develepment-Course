﻿using IRunes.App.Controllers;
using SIS.HTTP.Enums;
using SIS.MvcFramework;
using SIS.MvcFramework.Results;
using SIS.MvcFramework.Routing;
using System;

namespace IRunes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            WebHost.Run(new StartUp());
            //IServerRoutingTable serverRoutingTable = new ServerRoutingTable();
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/", (_) => new RedirectResult("/Home/Index"));
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Home/Index", new HomeController().HomePage);

            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Users/Login", new UsersController().Login);
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Users/Register", new UsersController().Register);
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/All", new AlbumsController().All);
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Create", new AlbumsController().Create);
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Albums/Details", new AlbumsController().Info);
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Tracks/Create", new TracksController().Create);
            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Tracks/Details", new TracksController().Info);
           

            //serverRoutingTable.Add(HttpRequestMethod.Get, "/Users/Logout", new UsersController().HandleLoggingOut);
            //serverRoutingTable.Add(HttpRequestMethod.Post, "/Users/Login", new UsersController().HandleLogingIn);
            //serverRoutingTable.Add(HttpRequestMethod.Post, "/Users/Register", new UsersController().HandleRegistration);
            //serverRoutingTable.Add(HttpRequestMethod.Post, "/Albums/Create", new AlbumsController().HandleCreatingAlbum);
            //serverRoutingTable.Add(HttpRequestMethod.Post, "/Tracks/Create", new TracksController().HandleCreatingTrack);

            /////Tracks/Details?albumId={albumId}&trackId={trackId}


            //Server server = new Server(8000,serverRoutingTable);

            //server.Run();


        }
    }
}
