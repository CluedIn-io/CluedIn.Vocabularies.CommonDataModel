using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CommissionProductGroupEntityVocabulary : SimpleVocabulary
    {
        public CommissionProductGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model CommissionProductGroupEntity";
            KeyPrefix = "commonDataModel.commissionproductgroupentity";
            KeySeparator = ".";
            Grouping = "/CommissionProductGroupEntity";

            AddGroup("Common Data Model CommissionProductGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}