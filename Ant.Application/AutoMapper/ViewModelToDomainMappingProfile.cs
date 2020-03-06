using Ant.Application.ViewModels;
using Ant.Domain.Commands;
using Ant.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ant.Application.AutoMapper
{
  public  class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UserViewModel, RegisterNewUserCommand>()
                          .ConstructUsing(c => new RegisterNewUserCommand(c.Name, c.Email));
            //CreateMap<CustomerViewModel, UpdateCustomerCommand>()
            //    .ConstructUsing(c => new UpdateCustomerCommand(c.Id, c.Name, c.Email, c.BirthDate));
        }


    }
}
