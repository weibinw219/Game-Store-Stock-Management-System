using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team_WASD_GSSMSClient.Models;

namespace Team_WASD_GSSMSClient.Controllers
{
    /*
     * Author: Elizaveta Liashova
     */
    /// <summary>
    /// The home controller contains the entry pages and user login servce.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Main page of this application.
        /// </summary>
        /// <returns>An index page view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// A method to render aefault page that is not part of this application
        /// </summary>
        /// <returns>About page view</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// A method to render default page that is not part of this application.
        /// </summary>
        /// <returns>Contact page view.</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// A method to display the login page.
        /// </summary>
        /// <returns>Login page view.</returns>
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// A post method to send the login information, check the database to see if any of them are matched.
        /// </summary>
        /// <param name="objUser">An user object information that is entered by the user</param>
        /// <returns>User datshboard view or current view, depends on user entered information.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserProfile objUser)
        {
            // Declare an User object from User model.
            User loginUser = new User();
            // Check if it passes validation check.
            if (ModelState.IsValid)
            {
                // Retrieve information from database.
                using (UserDBEntities db = new UserDBEntities())
                {
                    // Declare a variable to stored if the entered user infomation is matched to the user object from the database. 
                    var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    var name = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName)).FirstOrDefault();
                    var pass = db.UserProfiles.Where(a => a.Password.Equals(objUser.Password)).FirstOrDefault();

                    if (name is null)
                    {
                        ModelState.AddModelError("UserName", "This user does not exist");
                        return View(loginUser);
                    }
                    if (pass is null)
                    {
                        ModelState.AddModelError("Password", "Wrong password");
                        return View(loginUser);
                    }
                    // Check if the user existed in the database.
                    if (obj != null)
                    {
                        // Assign the values of user object to User model object so that the validation can be processed.
                        loginUser.UserId = obj.UserId;
                        loginUser.UserName = obj.UserName;
                        loginUser.Password = obj.Password;
                        // Assign the values to session.
                        Session["UserID"] = loginUser.UserId.ToString();
                        Session["UserName"] = loginUser.UserName.ToString();
                        // Redirect to UserDashBoard if user entered a valid user infomation.
                        return RedirectToAction("UserDashBoard");
                    }
                    
                }
            }
            // Return to current page if user entered invalid login infomation including wrong password or username.
            return View(loginUser);
        }

        /// <summary>
        /// A method to show the user dash board view
        /// </summary>
        /// <returns>User dash board view.</returns>
        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {

                return RedirectToAction("Login");
            }
        }

        /// <summary>
        /// A method to show the logout page when user successfully loged out.
        /// </summary>
        /// <returns>Logout page</returns>
        public ActionResult Logout()
        {
            // set the user session to null to prevent unauthorized acess.
            Session["UserID"] = null;
            Session["UserName"] = null;
            return View();
        }
    }
}