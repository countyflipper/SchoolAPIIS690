﻿using Contracts;
using Entities.DataTransferObjects;
using Entities.LinkModels;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolAPI.Utility
{
    public class UserLinks
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IDataShaper<UserDto> _dataShaper;

        public UserLinks(LinkGenerator linkGenerator, IDataShaper<UserDto> dataShaper)
        {
            _linkGenerator = linkGenerator;
            _dataShaper = dataShaper;
        }

        //public LinkResponse TryGenerateLinks(IEnumerable<UserDto> employeesDto, string fields, Guid companyId, HttpContext httpContext)
        //{
        //    var shapedEmployees = ShapeData(employeesDto, fields);

        //    if (ShouldGenerateLinks(httpContext))
        //        return ReturnLinkdedUsers(employeesDto, fields, companyId, httpContext, shapedEmployees);

        //    return ReturnShapedUsers(shapedEmployees);
        //}

        //private List<Entity> ShapeData(IEnumerable<UserDto> employeesDto, string fields) =>
        //    _dataShaper.ShapeData(employeesDto, fields)
        //        .Select(e => e.)
        //        .ToList();

        private bool ShouldGenerateLinks(HttpContext httpContext)
        {
            var mediaType = (MediaTypeHeaderValue)httpContext.Items["AcceptHeaderMediaType"];

            return mediaType.SubTypeWithoutSuffix.EndsWith("hateoas", StringComparison.InvariantCultureIgnoreCase);
        }

        private LinkResponse ReturnShapedUsers(List<Entity> shapedEmployees) => new LinkResponse { ShapedEntities = shapedEmployees };

        private LinkResponse ReturnLinkdedUsers(IEnumerable<UserDto> employeesDto, string fields, Guid companyId, HttpContext httpContext, List<Entity> shapedEmployees)
        {
            var UserDtoList = employeesDto.ToList();

            for (var index = 0; index < UserDtoList.Count(); index++)
            {
                var employeeLinks = CreateLinksForEmployee(httpContext, companyId, UserDtoList[index].id, fields);
                shapedEmployees[index].Add("Links", employeeLinks);
            }

            var employeeCollection = new LinkCollectionWrapper<Entity>(shapedEmployees);
            var linkedEmployees = CreateLinksForEmployees(httpContext, employeeCollection);

            return new LinkResponse { HasLinks = true, LinkedEntities = linkedEmployees };
        }

        private List<Link> CreateLinksForEmployee(HttpContext httpContext, Guid companyId, Guid id, string fields = "")
        {
            var links = new List<Link>
            {
                new Link(_linkGenerator.GetUriByAction(httpContext, "GetUsersAll", values: new { companyId, id, fields }),
                "self",
                "GET"),
                new Link(_linkGenerator.GetUriByAction(httpContext, "DeleteUser", values: new { companyId, id }),
                "delete_employee",
                "DELETE"),
                new Link(_linkGenerator.GetUriByAction(httpContext, "UpdateUser", values: new { companyId, id }),
                "update_employee",
                "PUT"),
                new Link(_linkGenerator.GetUriByAction(httpContext, "PartiallyUpdateEmployeeForCompany", values: new { companyId, id }),
                "partially_update_employee",
                "PATCH")
            };

            return links;
        }

        private LinkCollectionWrapper<Entity> CreateLinksForEmployees(HttpContext httpContext, LinkCollectionWrapper<Entity> employeesWrapper)
        {
            employeesWrapper.Links.Add(new Link(_linkGenerator.GetUriByAction(httpContext, "GetEmployeesForCompany", values: new { }),
                    "self",
                    "GET"));

            return employeesWrapper;
        }
    }
}
