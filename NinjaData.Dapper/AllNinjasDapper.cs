namespace NinjaService.App
{
    using System;
    using System.Collections.Generic;
    using NinjaBook.Service.App;
    using NinjaBook.Service.Models;

    public class AllNinjasDapper : IAllNinjas
    {
        public IEnumerable<Ninja> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Ninja Edit(Ninja ninja)
        {
            throw new System.NotImplementedException();
        }

        public Ninja GetByNickName(string nickname)
        {
            throw new NotImplementedException();
        }
    }
}