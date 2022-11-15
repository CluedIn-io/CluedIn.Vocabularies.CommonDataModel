using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierServiceGroupEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierServiceGroupEntityVocabulary()
        {
            VocabularyName = "TMS Shipping Carrier Service Group Entity";
            KeyPrefix = "commonDataModel.tmsshippingcarrierservicegroupentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierServiceGroupEntity";

            AddGroup("TMSShippingCarrierServiceGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
    }
}