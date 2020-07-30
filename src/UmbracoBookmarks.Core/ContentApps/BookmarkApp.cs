using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Core.Models.ContentEditing;
using Umbraco.Core.Models.Membership;

namespace UmbracoBookmarks.Core.ContentApps
{
    public class BookmarkApp : IContentAppFactory
    {
        public ContentApp GetContentAppFor(object source, IEnumerable<IReadOnlyUserGroup> userGroups)
        {
            if (source is IContent || source is IMedia)
            {
                return new ContentApp
                {
                    Alias = "bookmarks",
                    Name = "Bookmarks",
                    Icon = "icon-flag-alt",
                    View = "/App_Plugins/Bookmarks/bookmarks.contentapp.html",
                    Weight = 0,
                    Badge = new ContentAppBadge
                    {
                        Count = 1,
                        Type = ContentAppBadgeType.Default
                    }
                };
            }

            return null;
        }
    }
}
