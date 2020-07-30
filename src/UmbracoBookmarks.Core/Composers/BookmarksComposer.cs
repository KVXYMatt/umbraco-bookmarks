using Umbraco.Core.Composing;
using Umbraco.Web;
using UmbracoBookmarks.Core.ContentApps;

namespace UmbracoBookmarks.Core.Composers
{
    public class BookmarksComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.ContentApps().Append<BookmarkApp>();
        }
    }
}
