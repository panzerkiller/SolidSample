using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }

        //add a logger instance
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();

        //add a policy source instance
        public FilePolicySource FilePolicy = new FilePolicySource();
        
        //add a policy serializer instance
        public PolicySerializer PolicySerializer = new PolicySerializer();

        public void Rate()
        {
            Logger.Log("Starting rate.");

            Logger.Log("Loading policy.");

            // load policy - open file policy.json
            string policyJson = FilePolicy.GetPolicyFromSource();

            // convert policy JSON into a Policy object - use PolicySerializer
            var policy = PolicySerializer.GetPolicyFromJsonString(policyJson);

            // create rater factory
            var factory = new RaterFactory();

            // create an instance of a rater - use the factory
            var rater = factory.Create(policy, this);
            rater.Rate(policy);


            Logger.Log("Rating completed.");
        }
    }
}
