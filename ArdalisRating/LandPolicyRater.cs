using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class LandPolicyRater : Rater
    {
        
        //Constructor
        public LandPolicyRater(RatingEngine engine, ConsoleLogger logger) : base(engine, logger)
        {

        }
        //Method to rate the policy
        public override void Rate(Policy policy)
        {
            _logger.Log("Rating LAND policy...");
            _logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Address))
            {
                _logger.Log("Land policy must specify Address");
                return;
            }
            if (policy.Address == "1234 Smith Rd")
            {
                _engine.Rating = 1000m;
            }
            _engine.Rating = 500m;
        }
    }
}
