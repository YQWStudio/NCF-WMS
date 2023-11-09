using Senparc.Ncf.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YQWStudio.Xncf.OrganizationUnit
{
    [Table(Register.DATABASE_PREFIX + nameof(OrganizationUnit))]
    [Serializable]
    public class OrganizationUnit : EntityBase<long>
    {
        [Required]
        /// <summary>
        /// 组织架构节点名称
        /// 一版为简称
        /// </summary>
        public string OuName { get; private set; }

        /// <summary>
        /// 组织结构节点的上一级节点
        /// </summary>
        public int ParentId { get; private set; }

        /// <summary>
        /// 组织结构节点长名称
        /// </summary>
        public string OuLongName { get; private set; }

        /// <summary>
        /// 组织结构节点是否为根节点
        /// </summary>
        public bool IsRoot { get; private set; }

        /// <summary>
        /// 组织机构节点详情，一般用于备注信息
        /// </summary>
        public string OuDetail { get; private set; }

        public OrganizationUnit()
        {
        }
    }
}
