using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Team_WASD_GSSMSClient.Models
{
    /*
     * Author: Elizaveta Liashova
    */
    /// <summary>
    /// User model that consists of user id, user name, and user password. 
    /// </summary>
    public class User
    {
        // User id get set method
        public int UserId { get; set; }

        // Validation and user name get set method.
        [Required(ErrorMessage = "please enter your username!")]
        public string UserName { get; set; }

        // Validation and user password get set method.
        [Required(ErrorMessage = "please enter your password!!")]
        public string Password { get; set; }
    }
}