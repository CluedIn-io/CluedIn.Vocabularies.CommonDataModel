using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGReportTable_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGReportTable_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerRRGReportTable_RUEntity";
            KeyPrefix = "commonDataModel.ledgerrrgreporttable_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGReportTable_RUEntity";

            AddGroup("Common Data Model LedgerRRGReportTable_RUEntity Details", group =>
            {
                CurrencyForCalc = group.Add(new VocabularyKey(nameof(CurrencyForCalc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerPeriodCode = group.Add(new VocabularyKey(nameof(LedgerPeriodCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModelNum = group.Add(new VocabularyKey(nameof(ModelNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PointSignNum = group.Add(new VocabularyKey(nameof(PointSignNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RepCode = group.Add(new VocabularyKey(nameof(RepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportType = group.Add(new VocabularyKey(nameof(ReportType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Scale = group.Add(new VocabularyKey(nameof(Scale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Template = group.Add(new VocabularyKey(nameof(Template), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeByCorrect = group.Add(new VocabularyKey(nameof(TypeByCorrect), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerRRGETemplateId = group.Add(new VocabularyKey(nameof(LedgerRRGETemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionHierarchyHashKey = group.Add(new VocabularyKey(nameof(DimensionHierarchyHashKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CurrencyForCalc { get; private set; }
public VocabularyKey DataType { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey LedgerPeriodCode { get; private set; }
public VocabularyKey ModelNum { get; private set; }
public VocabularyKey PointSignNum { get; private set; }
public VocabularyKey RepCode { get; private set; }
public VocabularyKey ReportType { get; private set; }
public VocabularyKey Scale { get; private set; }
public VocabularyKey Template { get; private set; }
public VocabularyKey TypeByCorrect { get; private set; }
public VocabularyKey LedgerRRGETemplateId { get; private set; }
public VocabularyKey DimensionHierarchyHashKey { get; private set; }


    }
}