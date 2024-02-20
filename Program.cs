using Blog;
using Blog.Screens.MenuScreen;
using Blog.Screens.TagScreens;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.Extensibility;
using Microsoft.IdentityModel.Tokens;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=BlogWEF;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True";

Database.Connection = new SqlConnection(CONNECTION_STRING);
Database.Connection.Open();

MainMenuScreen.MainLoad();

Console.ReadKey();
Database.Connection.Close();


