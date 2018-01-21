using Newtonsoft.Json.Linq;
using System;

namespace Planets
{
    public interface PlanetsComponent
    {
        JToken GetAllPlanets();
        JToken GetPlanetById(int id);
    }
}
