namespace ArdalisRating
{
    internal class UnknownPolicyRater : Rater
    {
        public UnknownPolicyRater(RatingEngine engine, ConsoleLogger logger) : base(engine, logger)
        {
            
        }

        public override void Rate(Policy policy)
        {
            //throw new System.NotImplementedException();
            _logger.Log("Unknown policy type");
        }
    }
}