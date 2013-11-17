﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Core.Domains
{
    public class User : BaseEntity
    {

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual int SSN { get; set; }
        public virtual string Email { get; set; }
        
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public virtual string PassWord { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        //public virtual string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password salt.
        /// </summary>
        /// <value>
        /// The password salt.
        /// </value>
        //public virtual string PasswordSalt { get; set; }
    }

    public class StudentUser : BaseEntity
    {
        public virtual string Major { get; set; }
        public virtual string Education { get; set; }

        #region navigation properties

        //private ICollection<Class> _classes;
        //public virtual ICollection<Class> Classes
        //{
        //    get {return _classes ?? (_classes = new List<Class>());}
        //    protected set {_classes = value;}
        //}

        #endregion

    }

    public class TeacherUser : BaseEntity
    {
        public virtual decimal HourlyRate { get; set; }
        public virtual decimal ClassRate { get; set; }
    }

    public class Qualifications : BaseEntity
    {
        public virtual int TeacherUserId { get; set; }
        public virtual string Type { get; set; }
        public virtual string Description { get; set; }
    }
}
