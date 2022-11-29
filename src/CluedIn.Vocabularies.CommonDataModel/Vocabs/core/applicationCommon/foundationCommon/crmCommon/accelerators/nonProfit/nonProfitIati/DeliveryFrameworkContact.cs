using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DeliveryFrameworkContactVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkContactVocabulary()
        {
            VocabularyName = "Delivery Framework Contact";
            KeyPrefix = "commonDataModel.deliveryframeworkcontact.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DeliveryFrameworkContact";

            AddGroup("DeliveryFrameworkContact Details for NonProfitIati", group =>
            {
			    DeliveryFrameworkContactId = group.Add(new VocabularyKey(nameof(DeliveryFrameworkContactId), "Delivery Framework Contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeliveryFrameworkContactId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}