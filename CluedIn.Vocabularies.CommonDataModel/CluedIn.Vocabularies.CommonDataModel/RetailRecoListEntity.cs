using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailRecoListEntityVocabulary : SimpleVocabulary
    {
        public RetailRecoListEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailRecoListEntity";
            KeyPrefix = "commonDataModel.retailrecolistentity";
            KeySeparator = ".";
            Grouping = "/RetailRecoListEntity";

            AddGroup("Common Data Model RetailRecoListEntity Details", group =>
            {
                ListId = group.Add(new VocabularyKey(nameof(ListId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ListType = group.Add(new VocabularyKey(nameof(ListType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ListTitle = group.Add(new VocabularyKey(nameof(ListTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastModifiedDateTime = group.Add(new VocabularyKey(nameof(LastModifiedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ListId { get; private set; }
public VocabularyKey ListType { get; private set; }
public VocabularyKey ListTitle { get; private set; }
public VocabularyKey LastModifiedDateTime { get; private set; }


    }
}