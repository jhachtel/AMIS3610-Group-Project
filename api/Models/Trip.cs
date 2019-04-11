using System;

namespace AMIS3610.GroupProject.Api.Models
{
    public class Trip
    {
        public int Id{get; set;}

        public string name{get; set;}

        public Place place{get; set;}

        public Gear gear{get; set;}

        public People people{get; set;}

        public string blog{get; set;}
    }
}