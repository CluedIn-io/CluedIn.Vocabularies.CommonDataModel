using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesRebateCustomerGroupEntity";
            KeyPrefix = "commonDataModel.salesrebatecustomergroupentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateCustomerGroupEntity";

            AddGroup("Common Data Model SalesRebateCustomerGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupDescription { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}