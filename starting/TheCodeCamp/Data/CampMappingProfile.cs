﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheCodeCamp.Models;
using AutoMapper;
using System.Threading.Tasks;

namespace TheCodeCamp.Data
{
    public class CampMappingProfile : Profile
    {
        public CampMappingProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, opt => opt.MapFrom(m => m.Location.VenueName));
        }
    }
}