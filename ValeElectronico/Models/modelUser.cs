using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValeElectronico.Models
{
    public class modelUser
    {
        #region Properties

        [AllowHtml]
        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "UserName_Display")]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [AllowHtml]
        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password_Display")]
        public string Password { get; set; }

        #endregion Properties
    }
}