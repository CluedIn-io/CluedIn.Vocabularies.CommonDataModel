using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitMeasurement
{
    public class DeliveryFrameworkVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkVocabulary()
        {
            VocabularyName = "Delivery Framework";
            KeyPrefix = "commonDataModel.deliveryframework.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = "/DeliveryFramework";

            AddGroup("DeliveryFramework Details for NonProfitMeasurement", group =>
            {
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    LogframeStatus = group.Add(new VocabularyKey(nameof(LogframeStatus), "Logframe Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Country { get; private set; }
        public VocabularyKey LogframeStatus { get; private set; }
        public VocabularyKey Region { get; private set; }
    }
}