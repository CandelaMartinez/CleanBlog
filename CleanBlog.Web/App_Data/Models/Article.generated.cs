//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.16.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Article</summary>
	[PublishedModel("article")]
	public partial class Article : PublishedContentModel, IArticleControls, IContentControls, IHeaderControls, IMainImageControls, ISEocontrols, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const string ModelTypeAlias = "article";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Article, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Article(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// ArticleDateP: Aqui escribe la fecha del articulo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("articleDateP")]
		public virtual global::System.DateTime ArticleDateP => global::Umbraco.Web.PublishedModels.ArticleControls.GetArticleDateP(this);

		///<summary>
		/// AuthorNameP: Aqui escribe el nombre del autor
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("authorNameP")]
		public virtual string AuthorNameP => global::Umbraco.Web.PublishedModels.ArticleControls.GetAuthorNameP(this);

		///<summary>
		/// ContentP
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("contentP")]
		public virtual global::Newtonsoft.Json.Linq.JToken ContentP => global::Umbraco.Web.PublishedModels.ContentControls.GetContentP(this);

		///<summary>
		/// SubtitleP: Aqui va el subtitulo de la pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("subtitleP")]
		public virtual string SubtitleP => global::Umbraco.Web.PublishedModels.HeaderControls.GetSubtitleP(this);

		///<summary>
		/// TitleP: Aqui va el titulo de de la pagina. Si no hay titulo, el nombre de la pagina sera el que aparezca como titulo.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("titleP")]
		public virtual string TitleP => global::Umbraco.Web.PublishedModels.HeaderControls.GetTitleP(this);

		///<summary>
		/// MainImageP: Aqui va la imagen principal de la pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("mainImageP")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops MainImageP => global::Umbraco.Web.PublishedModels.MainImageControls.GetMainImageP(this);

		///<summary>
		/// MetaDescriptionP: Aqui va la meta description para esta pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("metaDescriptionP")]
		public virtual string MetaDescriptionP => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaDescriptionP(this);

		///<summary>
		/// MetaKeysP: Aqui van las meta keys para esta pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("metaKeysP")]
		public virtual global::System.Collections.Generic.IEnumerable<string> MetaKeysP => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaKeysP(this);

		///<summary>
		/// MetaNameP: Aqui va el meta name para esta pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("metaNameP")]
		public virtual string MetaNameP => global::Umbraco.Web.PublishedModels.SEocontrols.GetMetaNameP(this);

		///<summary>
		/// HideFromXMLSitemapP: Checked si queres esconder esta pagina de XML sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("hideFromXMLSitemapP")]
		public virtual bool HideFromXmlsitemapP => global::Umbraco.Web.PublishedModels.VisibilityControls.GetHideFromXmlsitemapP(this);

		///<summary>
		/// UmbracoNaviHideP: Checked si queres esconder esta pagina en el navegador y el search
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("umbracoNaviHideP")]
		public virtual bool UmbracoNaviHideP => global::Umbraco.Web.PublishedModels.VisibilityControls.GetUmbracoNaviHideP(this);
	}
}
