using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInfocodeGroupEntity";
            KeyPrefix = "commonDataModel.retailinfocodegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeGroupEntity";

            AddGroup("Common Data Model RetailInfocodeGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}