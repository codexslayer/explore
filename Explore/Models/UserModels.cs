using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Explore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastPasswordAt { get; set; }
        public DateTime InActiveDate { get; set; }
        public bool NeedPasswordChange { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
    }
    public class LoggedInUser
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }
        public bool NeedPasswordChange { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
    public class LoginModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
    public class Designation
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}