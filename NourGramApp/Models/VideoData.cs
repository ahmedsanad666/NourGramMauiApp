using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourGramApp.Models
{
    //public class Contributor
    //{
    //    public string ArName { get; set; }
    //    public string Biography { get; set; }
    //    public int ContributorStatus { get; set; }
    //    public int CountryId { get; set; }
    //    public string EnName { get; set; }
    //    public int Id { get; set; }
    //    public string ProfileImage { get; set; }
    //    public string Website { get; set; }
    //}
     public class Contributor
    {
        public int id { get; set; }
        public string arName { get; set; }
        public string enName { get; set; }
        public int contributorStatus { get; set; }
        public string biography { get; set; }
        public string profileImage { get; set; }
        public string website { get; set; }
        public int countryId { get; set; }
        public object applicationUserId { get; set; }
        public object applicationUser { get; set; }
        public object approvedByUserId { get; set; }
        public object approvedByUser { get; set; }
    }

    //public class Video
    //{
    //    public string ApplicationUserId { get; set; }
    //    public string ArDescription { get; set; }
    //    public string ArTitle { get; set; }
    //    public Contributor Contributor { get; set; }
    //    public int ContributorId { get; set; }
    //    public string EnDescription { get; set; }
    //    public string EnTitle { get; set; }
    //    public int Id { get; set; }
    //    public bool IsFeatured { get; set; }
    //    public bool IsPinned { get; set; }
    //    public int Likes { get; set; }
    //    public string Link { get; set; }
    //    public DateTime RecordDate { get; set; }
    //    public int Shared { get; set; }
    //    public string Tags { get; set; }
    //    public string Thumbnail { get; set; }
    //    public int VideoCatId { get; set; }
    //    public int VideoStatus { get; set; }
    //    public int Views { get; set; }
    //}    

    public class Video
    {
        public int id { get; set; }
        public string arTitle { get; set; }
        public string enTitle { get; set; }
        public string arDescription { get; set; }
        public string enDescription { get; set; }
        public string thumbnail { get; set; }
        public object embedImage { get; set; }
        public string link { get; set; }
        public string embedLink { get; set; }
        public int views { get; set; }
        public int likes { get; set; }
        public int shared { get; set; }
        public bool isFeatured { get; set; }
        public bool isPinned { get; set; }
        public string tags { get; set; }
        public DateTime recordDate { get; set; }
        public int videoStatus { get; set; }
        public string applicationUserId { get; set; }
        public object applicationUser { get; set; }
        public int contributorId { get; set; }
        public Contributor contributor { get; set; }
        public int videoCatId { get; set; }
        public object videoCat { get; set; }
    }
}
