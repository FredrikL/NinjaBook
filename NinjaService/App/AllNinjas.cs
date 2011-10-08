using System.Collections.Generic;
using System.Linq;
using NinjaService.Models;

namespace NinjaService.App
{
    class AllNinjas : IAllNinjas
    {
        public IEnumerable<Ninja> GetAll()
        {
            return Enumerable.Empty<Ninja>();
        }

        public Ninja Edit(Ninja ninja)
        {
            throw new System.NotImplementedException();
        }

        public Ninja GetByNickName(string nickname)
        {
            return new Ninja();
            throw new System.NotImplementedException();
        }
    }
}