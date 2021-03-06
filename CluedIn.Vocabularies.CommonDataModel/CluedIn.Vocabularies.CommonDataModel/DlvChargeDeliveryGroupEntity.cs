using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DlvChargeDeliveryGroupEntityVocabulary : SimpleVocabulary
    {
        public DlvChargeDeliveryGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model DlvChargeDeliveryGroupEntity";
            KeyPrefix = "commonDataModel.dlvchargedeliverygroupentity";
            KeySeparator = ".";
            Grouping = "/DlvChargeDeliveryGroupEntity";

            AddGroup("Common Data Model DlvChargeDeliveryGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey GroupDescription { get; private set; }


    }
}