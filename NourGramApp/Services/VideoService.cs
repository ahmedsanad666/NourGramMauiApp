using NourGramApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NourGramApp.Services
{
    public class VideoService
    {
        HttpClient HttpClient;
        public VideoService()
        {
            HttpClient = new HttpClient();
        }
        List<Video> VideoList = new List<Video>();


        // ger all videos data form nour gram 
        public async Task<List<Video>> GetAll()
        {

            if (VideoList.Count > 0)
                return VideoList;


            //var url = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:44354/NourAdmin/Videos/GetUserData" : "https://localhost:7110/NourAdmin/Videos/GetUserData";
            var url = "https://8de4-85-103-184-144.ngrok-free.app/NourAdmin/Videos/GetUserData";    
     

            var response = await HttpClient.GetAsync(url);
           
            if (response.IsSuccessStatusCode)
            {
                VideoList = await response.Content.ReadFromJsonAsync<List<Video>>();
       
            }
            else
            {
                Console.WriteLine("fail");
            }

            return VideoList;
        }
    }
}
