﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickRun.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuickRun.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;QuickRunSetting&gt;
        ///  &lt;Item Name=&quot;快速访问&quot;&gt;
        ///    &lt;Item Name=&quot;Temp&quot; Uri=&quot;C:\Users\zaevi\Temp&quot; /&gt;
        ///    &lt;Item Name=&quot;zaevi&quot; Uri=&quot;C:\Users\zaevi\&quot; /&gt;
        ///    &lt;Item Name=&quot;ithome&quot; Uri=&quot;shell:AppsFolder\CEF5787D.IT_tjw031c2n34qp!App&quot; /&gt;
        ///    &lt;Item Name=&quot;Back&quot; Type=&quot;BackButton&quot; /&gt;
        ///  &lt;/Item&gt;
        ///  &lt;Item Name=&quot;QuickRun选项&quot;&gt;
        ///    &lt;Item Name=&quot;打开配置目录&quot; Uri=&quot;%APPDATA%\QuickRun\&quot; /&gt;
        ///    &lt;Item Name=&quot;打开Github&quot; Uri=&quot;https://github.com/Zaeworks/QuickRun&quot; /&gt;
        ///    &lt;Item Name=&quot;Back&quot; Type=&quot;BackButton&quot; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string design {
            get {
                return ResourceManager.GetString("design", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Icon icon {
            get {
                object obj = ResourceManager.GetObject("icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Icon icon_notify {
            get {
                object obj = ResourceManager.GetObject("icon_notify", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;ResourceDictionary xmlns=&quot;http://schemas.microsoft.com/winfx/2006/xaml/presentation&quot;&gt;
        ///    &lt;Style TargetType=&quot;Button&quot; &gt;
        ///        &lt;Setter Property=&quot;Padding&quot; Value=&quot;5&quot;/&gt;
        ///        &lt;Setter Property=&quot;Background&quot; Value=&quot;White&quot;/&gt;
        ///        &lt;Setter Property=&quot;BorderThickness&quot; Value=&quot;0&quot;/&gt;
        ///    &lt;/Style&gt;
        ///&lt;/ResourceDictionary&gt; 的本地化字符串。
        /// </summary>
        public static string styles {
            get {
                return ResourceManager.GetString("styles", resourceCulture);
            }
        }
    }
}
