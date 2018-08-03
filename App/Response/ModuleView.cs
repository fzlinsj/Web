using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;
using Repository.Domain;

namespace App.Response
{
    public class ModuleView
    {
        ///// <summary>
        ///// ID
        ///// </summary>
        ///// <returns></returns>
        //public string Id { get; set; }

        ///// <summary>
        ///// 节点语义ID
        ///// </summary>
        //public string CascadeId { get; set; }

        ///// <summary>
        ///// 名称
        ///// </summary>
        ///// <returns></returns>
        //public string Name { get; set; }

        ///// <summary>
        ///// 主页面URL
        ///// </summary>
        ///// <returns></returns>
        //public string Url { get; set; }

        ///// <summary>
        ///// 父节点流水号
        ///// </summary>
        ///// <returns></returns>
        //public string ParentId { get; set; }

        ///// <summary>
        ///// 父节点流水号
        ///// </summary>
        ///// <returns></returns>
        //public string ParentName { get; set; }

        ///// <summary>
        ///// 节点图标文件名称
        ///// </summary>
        ///// <returns></returns>
        //public string IconName { get; set; }


        //public bool Checked { get; set; }

        ///// <summary>
        ///// 排序号
        ///// </summary>
        //public int SortNo { get; set; }

        //public string Code { get; set; }

        ///// <summary>
        ///// 模块中的元素
        ///// </summary>
        //public List<ModuleElement> Elements { get; set; }

        //public static implicit operator ModuleView(Module module)
        //{
        //    return module.MapTo<ModuleView>();
        //}

        //public static implicit operator Module(ModuleView view)
        //{
        //    return view.MapTo<Module>();
        //}

        /// <summary>
        /// 模块ID
        /// </summary>
        public string ModuleID { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// 模块类型
        /// </summary>
        public string ModuleType { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        public string ParentID { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public string PropertyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PropertyValue { get; set; }


        public string ImgPath { get; set; }

        public string DefaultPage { get; set; }

        ///// <summary>
        ///// 主页面URL
        ///// </summary>
        ///// <returns></returns>
        public string Url { get; set; }


    }
}
