using Ant.Application.ViewModels;
using Ant.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Application.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
