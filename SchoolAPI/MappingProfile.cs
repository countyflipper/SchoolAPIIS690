﻿using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //-----------------------------------------------------------------
            CreateMap<User, UserDto>();

            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>();

            //-----------------------------------------------------------------
            CreateMap<CourseManagement, CourseManageDTO>()
                .ForMember(c => c.AssignmentTitle,
                    opt => opt.MapFrom(x => string.Join(' ', x.AssigmentID, x.AssignmentTitle)));

            CreateMap<CourseManageForCreationDto, CourseManagement>();
            CreateMap<CourseManageForUpdateDto, CourseManagement>();
            //-----------------------------------------------------------------

            CreateMap<Courses, CourseDto>()
                .ForMember(c => c.CourseName,
                 opt => opt.MapFrom(x => string.Join(' ', x.CourseName, x.Description)));

            CreateMap<CourseForCreationDto, Courses>();
            CreateMap<CourseForUpdateDto, Courses>().ReverseMap();
            //-----------------------------------------------------------------

            CreateMap<SectionAssign, SectionAssignDTO>()
                .ForMember(c => c.AssignID,
                 opt => opt.MapFrom(x => string.Join(' ', x.SubmissionText, x.Score)));

            CreateMap<SectionAssignForCreationDTO, SectionAssignDTO>();
            CreateMap<SectionAssignForUpdateDTO, SectionAssignDTO>();
            //-----------------------------------------------------------------

            CreateMap<CourseSection, CourseSectionDto>();

            CreateMap<CourseSectionForCreationDto, CourseSection>();
            CreateMap<CourseSectionUpdateForDto, CourseSection>().ReverseMap();

            //-----------------------------------------------------------------

            CreateMap<SectionEnrollManage, SectionEnrollmentManageDto>();

            CreateMap<SectionEnrollmentManageForCreationDto, SectionEnrollManage>();
            CreateMap<SectionEnrollmentManageForUpdateDto, SectionEnrollManage>().ReverseMap();

            //-----------------------------------------------------------------
            CreateMap<UserForRegistrationDto, Users>();
        }
    }
}