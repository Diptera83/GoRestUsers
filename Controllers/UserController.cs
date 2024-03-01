using GoRestUsers.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GoRestUsers.Controllers
{
   
    public class UserController:Controller
    {
        public async Task<IActionResult> Index()
        {
            List<UserInfo> UserList = new List<UserInfo>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://gorest.co.in/public/v2/users"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    UserList = JsonConvert.DeserializeObject<List<UserInfo>>(apiResponse);
                }
            }
            return View(UserList);
        }
    }
}
