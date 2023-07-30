using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using SoundScheduleGen.Controllers;
using SoundScheduleGen.Models;
using SoundScheduleGen.Application.BL;
using SoundScheduleGen.Domain.DL;
using SoundScheduleGen.Infrastucture.DL;
using SoundScheduleGen.Domain.DL.Person;
using SoundScheduleGen.Application.BL.DTO;

namespace SoundScheduleGen
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            #region Class2DTO
            //********************
            // From Class to DTO
            //********************

            CreateMap<PersonHermano, PersonHermanoDTO>();
            #endregion

            #region DTO2Class
            //********************
            // From DTO to Class
            //********************

            CreateMap<PersonHermanoDTO, PersonHermano>();
            #endregion

        }

    }
}
