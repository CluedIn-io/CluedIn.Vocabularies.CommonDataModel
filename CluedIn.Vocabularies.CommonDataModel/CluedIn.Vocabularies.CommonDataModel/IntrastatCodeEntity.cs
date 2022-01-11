using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntrastatCodeEntityVocabulary : SimpleVocabulary
    {
        public IntrastatCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntrastatCodeEntity";
            KeyPrefix = "commonDataModel.intrastatcodeentity";
            KeySeparator = ".";
            Grouping = "/IntrastatCodeEntity";

            AddGroup("Common Data Model IntrastatCodeEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatCode = group.Add(new VocabularyKey(nameof(IntrastatCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey IntrastatCode { get; private set; }
public VocabularyKey StateId { get; private set; }


    }
}