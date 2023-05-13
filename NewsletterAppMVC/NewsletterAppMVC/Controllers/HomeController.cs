using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;


namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller

    {
        private readonly string  connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int NewsletterSignUp { get; private set; }

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]  //Any time you are doing a post method you should mark it as post
        public ActionResult Signup(string firstName, string lastName, string emailAddress)  //MVC is smart enough to map the attibutes to the form
        {
            if(string.IsNullOrEmpty(firstName)|| string.IsNullOrEmpty(lastName) ||string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //1 you need to make a connection string
                //the best way to get the string is to connect to the database from inside visual studio
                //rt clickon the database and go to properties
                //string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Newsletter;Integrated Security=True;Connect //Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //2 Create our query string and pass in some parameters doing it this way prevents sql injection
                string queryString = @"INSERT INTO Signups (FirstName, LastName, EmailAddress) VALUES (@FirstName,@LastName,@EmailAddress)";
                //Passing in the connection string any time you open a connection you want to wrap in a connection to prevent memory leaks
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command= new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                   

                    //give the paramters values
                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                   

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();                       
                }



                return View("Success");
            }
        }
        public ActionResult Admin()
        {   //We want to grab all of the signups
           
            //Create the query string
            string queryString = @"SELECT Id,FirstName,LastName,EmailAddress,SocialSecurityNumber from Signups";
            
            //Create a list of our model 
            List<NewsletterSignup> signups = new List<NewsletterSignup>();
            
            //Open a connection an wrap in a using stmt  Pass in the connection string
            using (SqlConnection connection =new SqlConnection(connectionString))
            {
                //Generate our command -Pass in the query string and connection
                SqlCommand command = new SqlCommand(queryString, connection);

                //Open the connection
                connection.Open();
              
                SqlDataReader reader = command.ExecuteReader();
                // Read the information
                while (reader.Read())
                {
                    var signup = new NewsletterSignup();
                    signup.Id = Convert.ToInt32(reader["Id"]);
                    signup.FirstName = reader["FirstName"].ToString();
                    signup.LastName = reader["LastName"].ToString();
                    signup.EmailAddress = reader["EmailAddress"].ToString();
                    signup.SocialSecurityNumber=reader["SocialSecurityNumber"].ToString();//we do not want to display the ssn so we are going to create a view model to strip is down

                    //Add the data to our model
                    signups.Add(signup);
                }                
            }
                //Map our database objet to a veiw model
               var signupVms = new List<SignupVm>();
              foreach(var signup in signups)
            {
                var signupVm = new SignupVm();
                signupVm.FirstName = signup.FirstName;
                signupVm.LastName = signup.LastName;
                signupVm.EmailAddress = signup.EmailAddress;

                //Add to the list
                signupVms.Add(signupVm);
                  

            }
            //We are passing the list to the view 
            return View(signupVms);
        }
    }
       
}