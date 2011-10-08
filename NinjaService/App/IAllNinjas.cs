using System.Collections.Generic;
using NinjaService.Models;

namespace NinjaService.App
{
    public interface IAllNinjas
    {
        IEnumerable<Ninja> GetAll();

        Ninja Edit(Ninja ninja);
    }
}