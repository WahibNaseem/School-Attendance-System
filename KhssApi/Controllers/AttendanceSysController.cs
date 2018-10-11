﻿using Khss.ServiceContracts;
using KhssData.DomainModels.Attendance;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace KhssApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceSysController:ControllerBase
    {
        #region Cycle of the Application
        private readonly IAttendanceSystemService _attendanceService;
        public AttendanceSysController(IAttendanceSystemService attendanceService) => this._attendanceService = attendanceService;

        #endregion


        //GET: api/values
        [HttpGet]
        public IEnumerable<Class> Get()
        {
           var attendance =  _attendanceService.GetAllClasses() as IEnumerable<Class>;
            return attendance;
        }
    }
}
