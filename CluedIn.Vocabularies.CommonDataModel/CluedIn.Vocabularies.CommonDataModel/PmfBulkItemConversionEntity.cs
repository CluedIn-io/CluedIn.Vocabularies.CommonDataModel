using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfBulkItemConversionEntityVocabulary : SimpleVocabulary
    {
        public PmfBulkItemConversionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PmfBulkItemConversionEntity";
            KeyPrefix = "commonDataModel.pmfbulkitemconversionentity";
            KeySeparator = ".";
            Grouping = "/PmfBulkItemConversionEntity";

            AddGroup("Common Data Model PmfBulkItemConversionEntity Details", group =>
            {
                PackedItemNumber = group.Add(new VocabularyKey(nameof(PackedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BulkItemNumber = group.Add(new VocabularyKey(nameof(BulkItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConversionFactor = group.Add(new VocabularyKey(nameof(ConversionFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConversionNumerator = group.Add(new VocabularyKey(nameof(ConversionNumerator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConversionDenominator = group.Add(new VocabularyKey(nameof(ConversionDenominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingMethod = group.Add(new VocabularyKey(nameof(RoundingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PackedItemNumber { get; private set; }
public VocabularyKey BulkItemNumber { get; private set; }
public VocabularyKey ConversionFactor { get; private set; }
public VocabularyKey ConversionNumerator { get; private set; }
public VocabularyKey ConversionDenominator { get; private set; }
public VocabularyKey RoundingMethod { get; private set; }


    }
}