﻿using System.Web;
using System.Web.Optimization;

namespace DeGaverbeekProject
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/materialize.js",
                      "~/Content/VideoPlayer/mediaelement-and-player.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/Site.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/materialize.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/DeGaverbeekStore/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/materialize.css",
                      "~/Content/DeGaverbeekStore/css/Navigation.css",
                      "~/Content/DeGaverbeekStore/css/site.css"));

            bundles.Add(new ScriptBundle("~/Content/DeGaverbeekStore/js").Include(
                     "~/Content/DeGaverbeekStore/js/site.js"));
        }
        
    }
}
