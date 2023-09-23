using System;
using System.Security.Cryptography.X509Certificates;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    return new AutoPolicyRater(engine, engine.Logger);
                case PolicyType.Land:
                    return new LandPolicyRater(engine, engine.Logger);
                case PolicyType.Life:
                    return new LifePolicyRater(engine, engine.Logger);
                case PolicyType.Flood:
                    return new FloodPolicyRater(engine, engine.Logger);
                default:
                    return new UnknownPolicyRater(engine, engine.Logger);
            }
            
            //try
            //{
            //    return (Rater)Activator.CreateInstance(
            //        Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"), new object[] { engine, engine.Logger });
            //}
            //catch
            //{
            //    return new UnknownPolicyRater(engine, engine.Logger);
            //}

        }
    }
}