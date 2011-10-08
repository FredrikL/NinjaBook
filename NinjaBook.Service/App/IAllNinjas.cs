namespace NinjaBook.Service.App
{
    using System.Collections.Generic;
    using Models;

    public interface IAllNinjas
    {
        IEnumerable<Ninja> GetAll();

        Ninja Edit(Ninja ninja);
        Ninja GetByNickName(string nickname);
    }
}