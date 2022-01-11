using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdLedgerAccountGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdLedgerAccountGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdLedgerAccountGroupEntity";
            KeyPrefix = "commonDataModel.taxwithholdledgeraccountgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdLedgerAccountGroupEntity";

            AddGroup("Common Data Model TaxWithholdLedgerAccountGroupEntity Details", group =>
            {
                ExpenseLedgerDimension = group.Add(new VocabularyKey(nameof(ExpenseLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithhodlSettlementLedgerDimension = group.Add(new VocabularyKey(nameof(TaxWithhodlSettlementLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdAccountGroup = group.Add(new VocabularyKey(nameof(TaxWithholdAccountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdLedgerDimension = group.Add(new VocabularyKey(nameof(TaxWithholdLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdOffsetLedgerDimension = group.Add(new VocabularyKey(nameof(TaxWithholdOffsetLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ExpenseLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithhodlSettlementLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TaxWithhodlSettlementLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TaxWithholdLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdOffsetLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TaxWithholdOffsetLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExpenseLedgerDimension { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey TaxWithhodlSettlementLedgerDimension { get; private set; }
public VocabularyKey TaxWithholdAccountGroup { get; private set; }
public VocabularyKey TaxWithholdLedgerDimension { get; private set; }
public VocabularyKey TaxWithholdOffsetLedgerDimension { get; private set; }
public VocabularyKey ExpenseLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey TaxWithhodlSettlementLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey TaxWithholdLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey TaxWithholdOffsetLedgerDimensionDisplayValue { get; private set; }


    }
}