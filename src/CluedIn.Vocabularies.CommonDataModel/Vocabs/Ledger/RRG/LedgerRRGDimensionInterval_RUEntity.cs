using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGDimensionInterval_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGDimensionInterval_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerRRGDimensionInterval_RUEntity";
            KeyPrefix = "commonDataModel.ledgerrrgdimensioninterval_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGDimensionInterval_RUEntity";

            AddGroup("Common Data Model LedgerRRGDimensionInterval_RUEntity Details", group =>
            {
                DimensionAttributeName = group.Add(new VocabularyKey(nameof(DimensionAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionFromValue = group.Add(new VocabularyKey(nameof(DimensionFromValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionToValue = group.Add(new VocabularyKey(nameof(DimensionToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimRecID = group.Add(new VocabularyKey(nameof(DimRecID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimTableID = group.Add(new VocabularyKey(nameof(DimTableID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefLineId = group.Add(new VocabularyKey(nameof(RefLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefTableName = group.Add(new VocabularyKey(nameof(RefTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DimensionAttributeName { get; private set; }
public VocabularyKey DimensionFromValue { get; private set; }
public VocabularyKey DimensionToValue { get; private set; }
public VocabularyKey DimRecID { get; private set; }
public VocabularyKey DimTableID { get; private set; }
public VocabularyKey RefLineId { get; private set; }
public VocabularyKey RefTableName { get; private set; }


    }
}