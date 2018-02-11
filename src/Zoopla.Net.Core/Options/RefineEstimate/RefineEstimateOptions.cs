using Zoopla.Net.Core.Options.Enums;

namespace Zoopla.Net.Core.Options.RefineEstimate
{
    public class RefineEstimateOptions : OptionsBase
    {
        public string SessionId
        {
            set => UrlValues["session_id"] = value;
        }

        public string PropertyId
        {
            set => UrlValues["property_id"] = value;
        }

        public EstimatePropertyType PropertyType
        {
            set => UrlValues["property_type"] = value.ToString()?.ToLower();
        }

        public Tenure Tenure
        {
            set => UrlValues["tenure"] = value.ToString()?.ToLower();
        }

        public string NumberOfBedrooms
        {
            set => UrlValues["num_bedrooms"] = value;
        }

        public string NumberOfBathrooms
        {
            set => UrlValues["num_bathrooms"] = value;
        }

        public string NumberOfReceptionRooms
        {
            set => UrlValues["num_receptions"] = value;
        }
    }
}
