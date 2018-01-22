using Newtonsoft.Json.Linq;
using System;

namespace Planets
{
    internal class PlanetsComponentImpl : PlanetsComponent
    {
        public PlanetsComponentImpl(IDynamoDbService dynamoDbService)
        {

        }
        public JToken GetAllPlanets()
        {
            throw new NotImplementedException();
        }

        public JToken GetPlanetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
