using Microsoft.AspNetCore.Mvc;
using SoundScheduleGen.Domain.DL.Person;
using SoundScheduleGen.Application.BL.DTO;
using AutoMapper;
using System.Runtime.InteropServices;

namespace SoundScheduleGen.Controllers
{
    public class PersonHermanoController : Controller
    {
        #region private readonly properties
        private readonly IMapper _mapper;
        private readonly PersonHermanoController objPersonHermano;
        private readonly ILogger<PersonHermanoController> _logger;
        #endregion

        #region constructor and config
        public PersonHermanoController(IMapper mapper, ILogger<PersonHermanoController> logger)
        {
            _mapper = mapper;
            _logger = logger;
        }
        #endregion

        #region Actions
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hermanos()
        {
            return View();
        }
        public IActionResult CrearHermano(PersonHermanoDTO newPersonHermanoDTO)
        {
            return View();
        }
        #endregion
    }
}
