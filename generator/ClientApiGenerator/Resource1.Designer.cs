﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApiGenerator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ClientApiGenerator.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///#if PORTABLE
        ///using System.Threading.Tasks;
        ///#endif
        ///
        ///namespace Avalara.AvaTax.RestClient
        ///{
        ///    public partial class AvaTaxClient
        ///    {
        ///#region Methods
        ///@foreach(var m in SwaggerModel.Methods) {
        ///
        ///    WriteLine(&quot;        /// &lt;summary&gt;&quot;);
        ///    WriteLine(&quot;        /// &quot; + CSharpComment(m.Comment));
        ///    WriteLine(&quot;        /// &lt;/summary&gt;&quot;);
        ///
        ///    foreach (var p in m.Params) {
        ///        WriteLine(&quot;        /// &lt;param name=\&quot;&quot; + p.CleanParamName + &quot;\&quot;&gt;&quot; + p.Comment + &quot;&lt;/param&gt;&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string csharp_api_class {
            get {
                return ResourceManager.GetString("csharp_api_class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///namespace Avalara.AvaTax.RestClient
        ///{
        ///    /// &lt;summary&gt;
        ///    /// @EnumModel.EnumDataType
        ///    /// &lt;/summary&gt;
        ///    public enum @EnumModel.EnumDataType
        ///    {
        ///@foreach(var v in EnumModel.Items) {
        ///WriteLine(&quot;        /// &lt;summary&gt;&quot;);
        ///WriteLine(&quot;        /// &quot; + CSharpComment(v.Comment));
        ///WriteLine(&quot;        /// &lt;/summary&gt;&quot;);
        ///WriteLine(&quot;        {0},&quot;, v.Value);
        ///WriteLine(&quot;&quot;);
        ///}
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string csharp_enum_class {
            get {
                return ResourceManager.GetString("csharp_enum_class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using Newtonsoft.Json;
        ///
        ///namespace Avalara.AvaTax.RestClient
        ///{
        ///    /// &lt;summary&gt;
        ///    /// @CSharpComment(ClassModel.Comment)
        ///    /// &lt;/summary&gt;
        ///    public class @ClassModel.SchemaName
        ///    {
        ///@foreach(var p in ClassModel.Properties) {
        ///    WriteLine(&quot;        /// &lt;summary&gt;&quot;);
        ///    WriteLine(&quot;        /// &quot; + CSharpComment(p.Comment));
        ///    WriteLine(&quot;        /// &lt;/summary&gt;&quot;);
        ///    WriteLine(&quot;        public &quot; + p.TypeName + &quot; &quot; + p.CleanParamName + &quot; { get; set; }&quot;);
        ///    W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string csharp_model_class {
            get {
                return ResourceManager.GetString("csharp_model_class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?php
        ////*
        /// * AvaTax API Client Library
        /// *
        /// * (c) 2004-2016 Avalara, Inc.
        /// *
        /// * For the full copyright and license information, please view the LICENSE
        /// * file that was distributed with this source code.
        /// */
        ///namespace Avalara.AvaTax;
        ///
        ////**
        /// * @@author Ted Spence &lt;ted.spence@@avalara.com&gt;
        /// * @@author Bob Maidens &lt;bob.maidens@@avalara.com&gt;
        /// */
        ///final class AvaTaxApi extends AvaTaxApiBase
        ///{
        ///    /**
        ///     * @@param string x
        ///     */
        ///    public function MethodName(x)
        ///    {
        ///        this-&gt;funcvalue [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string php_api_class {
            get {
                return ResourceManager.GetString("php_api_class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?php
        ////*
        /// * AvaTax Enum Class
        /// *
        /// * (c) 2004-2016 Avalara, Inc.
        /// *
        /// * For the full copyright and license information, please view the LICENSE
        /// * file that was distributed with this source code.
        /// */
        ///namespace Avalara.AvaTax;
        ///
        ////**
        /// * @@author Ted Spence &lt;ted.spence@@avalara.com&gt;
        /// * @@author Bob Maidens &lt;bob.maidens@@avalara.com&gt;
        /// */class @EnumModel.EnumDataType extends AvaTaxEnum 
        ///{
        ///
        ///@foreach(var i in EnumModel.Items) {
        ///    Write(&quot;    const &quot; + i.Value + &quot; = \&quot;&quot; + i.Value + &quot;\&quot;;\r\n&quot;);
        ///}
        ///} [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string php_enum_class {
            get {
                return ResourceManager.GetString("php_enum_class", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?php
        ////*
        /// * AvaTax Entity Model Class
        /// *
        /// * (c) 2004-2016 Avalara, Inc.
        /// *
        /// * For the full copyright and license information, please view the LICENSE
        /// * file that was distributed with this source code.
        /// */
        ///namespace Avalara.AvaTax;
        ///
        ////**
        /// * @@author Ted Spence &lt;ted.spence@@avalara.com&gt;
        /// * @@author Bob Maidens &lt;bob.maidens@@avalara.com&gt;
        /// */
        ///final class @ClassModel.SchemaName extends AbstractEntity
        ///{
        ///@foreach(var p in ClassModel.Properties) {
        ///WriteLine(&quot;    /**&quot;);
        ///WriteLine(&quot;     * @var &quot; +  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string php_model_class {
            get {
                return ResourceManager.GetString("php_model_class", resourceCulture);
            }
        }
    }
}
