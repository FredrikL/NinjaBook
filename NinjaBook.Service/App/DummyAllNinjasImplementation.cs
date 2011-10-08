namespace NinjaBook.Service.App
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Models;

    internal class DummyAllNinjasImplementation : IAllNinjas
    {
        public IEnumerable<Ninja> GetAll()
        {
          return new[]
                   {
                     GetByNickName(""),
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson", Phone="123456"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson1", Phone="1234561"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson2", Phone="1234562"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson3", Phone="1234563"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson4", Phone="1234564"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson5", Phone="1234565"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson6", Phone="1234566"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson7", Phone="1234567"},
                     new Ninja(){Nickname = "nickname", Name = "Ninja Ninjasson8", Phone="1234568"},
                   };
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