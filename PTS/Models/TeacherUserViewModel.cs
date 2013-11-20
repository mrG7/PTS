﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Domains;

namespace PTS.Models
{
    public class TeacherUserViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal ClassRate { get; set; }

        public TeacherUserViewModel()
        {

        }

    }
}