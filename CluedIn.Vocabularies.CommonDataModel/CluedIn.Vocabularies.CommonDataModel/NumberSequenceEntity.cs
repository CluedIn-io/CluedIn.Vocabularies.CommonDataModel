using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NumberSequenceEntityVocabulary : SimpleVocabulary
    {
        public NumberSequenceEntityVocabulary()
        {
            VocabularyName = "Common Data Model NumberSequenceEntity";
            KeyPrefix = "commonDataModel.numbersequenceentity";
            KeySeparator = ".";
            Grouping = "/NumberSequenceEntity";

            AddGroup("Common Data Model NumberSequenceEntity Details", group =>
            {
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey NumberSequenceCode { get; private set; }
public VocabularyKey CompanyId { get; private set; }
public VocabularyKey NumberSequenceScope { get; private set; }


    }
}