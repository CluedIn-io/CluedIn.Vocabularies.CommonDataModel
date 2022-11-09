using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CAMImportedStatisticalMeasureEntityVocabulary : SimpleVocabulary
    {
        public CAMImportedStatisticalMeasureEntityVocabulary()
        {
            VocabularyName = "Common Data Model CAMImportedStatisticalMeasureEntity";
            KeyPrefix = "commonDataModel.camimportedstatisticalmeasureentity";
            KeySeparator = ".";
            Grouping = "/CAMImportedStatisticalMeasureEntity";

            AddGroup("Common Data Model CAMImportedStatisticalMeasureEntity Details", group =>
            {
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionMemberNames = group.Add(new VocabularyKey(nameof(DimensionMemberNames), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Magnitude = group.Add(new VocabularyKey(nameof(Magnitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceIdentifier = group.Add(new VocabularyKey(nameof(SourceIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountingDate { get; private set; }
public VocabularyKey DimensionMemberNames { get; private set; }
public VocabularyKey Magnitude { get; private set; }
public VocabularyKey SourceIdentifier { get; private set; }


    }
}