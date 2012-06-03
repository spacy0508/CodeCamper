﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeCamper.Model;

namespace CodeCamper.Web.Controllers
{
    public class FavoritesController : ApiControllerBase
    {
        public FavoritesController(ICodeCamperUow uow)
        {
            Uow = uow;
        }

        // GET: api/favorites/{personId}
        [Queryable]
        public IQueryable<Attendance> GetByPersonId(int id)
        {
            return Uow.Attendance.GetByPersonId(id).OrderBy(ps => ps.Session.Title);
        }
    }
}