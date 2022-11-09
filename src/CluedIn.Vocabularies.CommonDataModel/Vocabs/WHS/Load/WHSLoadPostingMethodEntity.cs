using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLoadPostingMethodEntityVocabulary : SimpleVocabulary
    {
        public WHSLoadPostingMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLoadPostingMethodEntity";
            KeyPrefix = "commonDataModel.whsloadpostingmethodentity";
            KeySeparator = ".";
            Grouping = "/WHSLoadPostingMethodEntity";

            AddGroup("Common Data Model WHSLoadPostingMethodEntity Details", group =>
            {
                MethodName = group.Add(new VocabularyKey(nameof(MethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodPosition = group.Add(new VocabularyKey(nameof(MethodPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MethodName { get; private set; }
public VocabularyKey MethodPosition { get; private set; }


    }
}