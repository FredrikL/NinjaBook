using System.Collections.Generic;
using System.Linq;
using NinjaService.Models;

namespace NinjaService.App
{
    internal class DummyAllNinjasImplementation : IAllNinjas
    {
        public IEnumerable<Ninja> GetAll()
        {
            return Enumerable.Empty<Ninja>();
        }

        public Ninja Edit(Ninja ninja)
        {
            return ninja;
        }

        public Ninja GetByNickName(string nickname)
        {
            return new Ninja(){Nickname = nickname, Name = "Ninja Ninjasson", Phone="123456"};
        }
    }
}