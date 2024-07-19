using UnityTalk.Models;

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnityTalk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;


    public partial class GroupTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupTable()
        {
            this.AnnouncementTables = new HashSet<AnnouncementTable>();
            this.FileTables = new HashSet<FileTable>();
            this.GroupMemberTables = new HashSet<GroupMemberTable>();
            this.MeetingTables = new HashSet<MeetingTable>();
            this.MessageTables = new HashSet<MessageTable>();
        }

        public int GrpId { get; set; }

        [StringLength(maximumLength: 45, MinimumLength = 2, ErrorMessage = ": Group Name Must Be Max 45 & Min 2")]
        [Required(ErrorMessage = "Enter the Group Name")]
        [Display(Name = "Group Name")]
        public string GrpName { get; set; }

        [StringLength(maximumLength: 500, MinimumLength = 5, ErrorMessage = ": Description Must Be Max 500 & Min 5")]
        [Display(Name = "Group Description")]
        public string GrpDescp { get; set; }
        public int GrpAdminId { get; set; }
        public int GrpImgId { get; set; }
        public bool GrpMode { get; set; }
        public string GrpCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnnouncementTable> AnnouncementTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileTable> FileTables { get; set; }
        public virtual GroupImgTable GroupImgTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupMemberTable> GroupMemberTables { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeetingTable> MeetingTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageTable> MessageTables { get; set; }
    }
}