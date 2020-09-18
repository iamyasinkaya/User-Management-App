using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagementApplication.Application.Models;
using UserManagementApplication.Core.Entities;

namespace UserManagementApplication.Application.Mapper
{
    public class MappingProfile
    {
        public static IMapper Mapper
        {
            get
            {
                return AutoMapper.Mapper.Instance;
            }
        }
        static MappingProfile()
        {
            CreateMap();
        }

        private static void CreateMap()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserModel>().ReverseMap();
            });
        }
    }
}
