﻿using System;

//EFX Code Generation Template 1.0
//author:Tibos
//blog:www.cnblogs.com/Tibos
//Entity Code Generation Template
namespace Tibos.Domain
{
	 //RoleNavDict
	public class RoleNavDict:BaseEntity
	{
      	/// <summary>
		/// 编号
        /// </summary>
        public virtual string Id
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 角色编号
        /// </summary>
        public virtual string RId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 菜单编号
        /// </summary>
        public virtual string NId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 字典编号
        /// </summary>
        public virtual string DId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// 状态
        /// </summary>
        public virtual int? Status
        {
            get; 
            set; 
        }        
		   
	}
}