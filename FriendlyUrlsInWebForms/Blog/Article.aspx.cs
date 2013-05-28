using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls;

namespace FriendlyUrlsInWebForms.Blog
{
    public partial class Article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Request.QueryString["id"] != null ? int.Parse(Request.QueryString["id"]) : -1;

            if (id < 0)
            {
                IList<string> segments = Request.GetFriendlyUrlSegments();
                if (segments.Count > 0)
                {
                    int.TryParse(segments[0], out id);
                }
            }
            if (id > 0)
            {
                Model.Blog post = GetBlog(id);

                if (post != null)
                {
                    title.Text = post.Title;
                    postDetails.Text = post.Post;
                    author.Text = post.Author;
                }
            }
        }

        private static Model.Blog GetBlog(int id)
        {
            Model.Blog post = new Model.Blog
            {
                Id = id,
                Author = "Author " + id.ToString(),
                Post = "Lotsa Lorem Ipsum. " + id.ToString(),
                Title = "Lorem Ipsum Title. " + id.ToString()
            };
            return post;
        }
    }
}