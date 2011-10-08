namespace NinjaService.App
{
    using System;
    using System.Collections.Generic;
    using NinjaBook.Data;
    using NinjaBook.Data.Models;

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