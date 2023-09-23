using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    //add a abstract class Rater as the base of all the raters
    public abstract class Rater
    {
        public RatingEngine _engine;
        public ConsoleLogger _logger;

        //Constructor
        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }

        //Method to rate the policy
        public abstract void Rate(Policy policy);
    }
}
