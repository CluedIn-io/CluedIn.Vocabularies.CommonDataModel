using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationBillingGroupEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationBillingGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationBillingGroupEntity";
            KeyPrefix = "commonDataModel.tmstransportationbillinggroupentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationBillingGroupEntity";

            AddGroup("Common Data Model TMSTransportationBillingGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}