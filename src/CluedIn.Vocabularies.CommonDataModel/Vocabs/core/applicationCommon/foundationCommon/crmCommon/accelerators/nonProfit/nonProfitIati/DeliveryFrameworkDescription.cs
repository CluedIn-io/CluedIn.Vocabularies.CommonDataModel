using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DeliveryFrameworkDescriptionVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkDescriptionVocabulary()
        {
            VocabularyName = "Delivery Framework Description";
            KeyPrefix = "commonDataModel.deliveryframeworkdescription.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DeliveryFrameworkDescription";

            AddGroup("DeliveryFrameworkDescription Details for NonProfitIati", group =>
            {
			    DeliveryFrameworkDescriptionId = group.Add(new VocabularyKey(nameof(DeliveryFrameworkDescriptionId), "Delivery Framework Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeliveryFrameworkDescriptionId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}