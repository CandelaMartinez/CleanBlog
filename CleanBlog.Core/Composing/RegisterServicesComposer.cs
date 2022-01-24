using CleanBlog.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace CleanBlog.Core.Composing
{
   public class RegisterServicesComposer:IUserComposer
    {

        public void Compose(Composition composition)
        {
            //ismtService
            composition.Register<ISmtpService, SmtpService>(Lifetime.Singleton);
            //registro servicio para latestArticles
            composition.Register<IArticleService, ArticleService>(Lifetime.Singleton);
        }
    }
}
