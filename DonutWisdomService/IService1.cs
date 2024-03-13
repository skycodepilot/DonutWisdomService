using System.ServiceModel;

namespace DonutWisdomService
{
    /// <summary>
    /// Represents a service for dispensing delicious and insightful donut wisdom.
    /// </summary>
    [ServiceContract(Name = "DonutWisdomService")]
    public interface IService1
    {
        /// <summary>
        /// Retrieves a randomly selected nugget of donut-related wisdom.
        /// </summary>
        /// <returns>A string containing a wise saying about donuts.</returns>
        [OperationContract]
        string GetWordsOfWisdom();
    }
}
