﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;
using Solid.Core.Repositories;
using Solid.Core.Services;


namespace Solid.Service
{
    public class OfficialService : IOfficialsServices
    {
        private readonly IOfficialsRepositories _officialRepositor;
        public OfficialService(IOfficialsRepositories bookRepositor)
        {
            _officialRepositor = bookRepositor;
        }

        public Official AddOfficial(Official official)
        {
           return _officialRepositor.AddOfficial(official);
        }

        public void DeleteOfficial(int id)
        {
            _officialRepositor.DeleteOfficial(id);
        }

        public List<Official> GetOfficials()
        {
            return _officialRepositor.GetOfficials();
        }

        public Official GetById(int id)
        {
            return _officialRepositor.GetById(id);
        }

        public Official UpdateOfficial(int id, Official official)
        {
          return  _officialRepositor.UpdateOfficial(id, official);
        }
    }
}
