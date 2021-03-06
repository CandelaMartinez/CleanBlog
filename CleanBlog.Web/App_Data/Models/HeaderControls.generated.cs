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
	// Mixin Content Type with alias "headerControls"
	/// <summary>Header Controls</summary>
	public partial interface IHeaderControls : IPublishedContent
	{
		/// <summary>SubtitleP</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		string SubtitleP { get; }

		/// <summary>TitleP</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		string TitleP { get; }
	}

	/// <summary>Header Controls</summary>
	[PublishedModel("headerControls")]
	public partial class HeaderControls : PublishedContentModel, IHeaderControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const string ModelTypeAlias = "headerControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeaderControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HeaderControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// SubtitleP: Aqui va el subtitulo de la pagina.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("subtitleP")]
		public virtual string SubtitleP => GetSubtitleP(this);

		/// <summary>Static getter for SubtitleP</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static string GetSubtitleP(IHeaderControls that) => that.Value<string>("subtitleP");

		///<summary>
		/// TitleP: Aqui va el titulo de de la pagina. Si no hay titulo, el nombre de la pagina sera el que aparezca como titulo.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		[ImplementPropertyType("titleP")]
		public virtual string TitleP => GetTitleP(this);

		/// <summary>Static getter for TitleP</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.16.0")]
		public static string GetTitleP(IHeaderControls that) => that.Value<string>("titleP");
	}
}
