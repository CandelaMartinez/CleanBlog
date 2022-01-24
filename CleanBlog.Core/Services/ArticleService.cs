using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace CleanBlog.Core.Services
{
    public class ArticleService : IArticleService
    {
        public IPublishedContent GetArticleListPage(IPublishedContent siteRoot)
        {
            //accedo a la pagina blog del tipo article list con un query:
            //accede a root, obten los descendientes donde el contentType es articleList, solo devuelve un resultado
            var articleList = siteRoot.Descendants().Where(x =>x.ContentType.Alias=="articleList").FirstOrDefault();
            return articleList;
        }

        public IEnumerable<IPublishedContent> GetLatestArticles(IPublishedContent siteRoot)
        {
            //obtengo el articleList pasandole el siteRoot
            var articleList = GetArticleListPage(siteRoot);

            //article: busca los descendientes de articleList donde el contentType sea article, y sea visible, ordenado por la propiedad fecha
            var articles = articleList.Descendants().Where(x => x.ContentType.Alias == "article" && x.IsVisible())
                .OrderByDescending(y => y.Value<DateTime>("articleDateP"));

            return articles;
        }
    }
}
