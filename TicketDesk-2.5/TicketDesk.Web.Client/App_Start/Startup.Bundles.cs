﻿// TicketDesk - Attribution notice
// Contributor(s):
//
//      Stephen Redd (stephen@reddnet.net, http://www.reddnet.net)
//
// This file is distributed under the terms of the Microsoft Public 
// License (Ms-PL). See http://opensource.org/licenses/MS-PL
// for the complete terms of use. 
//
// For any distribution that contains code from this file, this notice of 
// attribution must remain intact, and a copy of the license must be 
// provided to the recipient.

using System.Web.Optimization;

namespace TicketDesk.Web.Client
{
    //TODO: This may not be OWIN compliant if OWIN hosts other than Microsoft.Owin.Host.SystemWeb are used
    public partial class Startup
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/content/styles").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css",
                    "~/Content/font-awesome.css"
                    ));

            bundles.Add(new StyleBundle("~/content/wizard").Include("~/Content/wizard.css"));

            bundles.Add(new StyleBundle("~/content/editor")
                    .Include("~/Content/css/select2.css", new CssRewriteUrlTransform())
                    .Include("~/Content/css/select2-bootstrap.css", new CssRewriteUrlTransform())
                    .Include("~/Scripts/dropzone/css/dropzone.css", new CssRewriteUrlTransform())
                    .Include("~/Scripts/dropzone/css/basic.css", new CssRewriteUrlTransform()));

            bundles.Add(new ScriptBundle("~/bundles/editticket")
                .Include("~/Scripts/ticketdesk/edit-ticket.js"));


            bundles.Add(new ScriptBundle("~/bundles/ticketcenter").Include(
                    "~/Scripts/ticketdesk/ticketcenter.js",
                    "~/Scripts/jquery.clickable-{version}.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/editor").Include(
                    "~/Scripts/dropzone/dropzone.js",
                    "~/Scripts/ticketdesk/ticket-file-uploader.js",
                    "~/Scripts/ticketdesk/ticket-details.js",
                    "~/Scripts/ticketdesk/ticket-tags.js",
                    "~/Scripts/select2.js"
                    ));

            bundles.Add(new ScriptBundle("~/bundles/markdown").Include(
                    "~/Scripts/pagedown/Markdown.Converter.js",
                    "~/Scripts/pagedown/Markdown.Sanitizer.js",
                    "~/Scripts/pagedown/Markdown.Editor.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/jquery.unobtrusive-ajax.js",
                    "~/Scripts/jquery.validate*",
                    "~/Scripts/bootstrap.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"));




            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
#if (DEBUG)
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif

        }
    }
}
