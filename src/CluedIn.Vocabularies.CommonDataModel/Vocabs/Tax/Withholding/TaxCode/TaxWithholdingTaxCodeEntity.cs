using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdingTaxCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdingTaxCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdingTaxCodeEntity";
            KeyPrefix = "commonDataModel.taxwithholdingtaxcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdingTaxCodeEntity";

            AddGroup("Common Data Model TaxWithholdingTaxCodeEntity Details", group =>
            {
                CurrencyCodeID = group.Add(new VocabularyKey(nameof(CurrencyCodeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxBase = group.Add(new VocabularyKey(nameof(WithholdingTaxBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingCode = group.Add(new VocabularyKey(nameof(WithholdingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxName = group.Add(new VocabularyKey(nameof(WithholdingTaxName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxRoundOff = group.Add(new VocabularyKey(nameof(WithholdingTaxRoundOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxRoundOffType = group.Add(new VocabularyKey(nameof(WithholdingTaxRoundOffType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdLedgerAccountGroupRecId = group.Add(new VocabularyKey(nameof(TaxWithholdLedgerAccountGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdPeriodHeadRecId = group.Add(new VocabularyKey(nameof(TaxWithholdPeriodHeadRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdAccountGroup = group.Add(new VocabularyKey(nameof(TaxWithholdAccountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdPeriod = group.Add(new VocabularyKey(nameof(TaxWithholdPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxReceivable = group.Add(new VocabularyKey(nameof(WithholdingTaxReceivable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrazilianTaxWithholdPeriod = group.Add(new VocabularyKey(nameof(BrazilianTaxWithholdPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrazilianTaxWithholdType = group.Add(new VocabularyKey(nameof(BrazilianTaxWithholdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementAccount = group.Add(new VocabularyKey(nameof(SettlementAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxReceivableDisplayValue = group.Add(new VocabularyKey(nameof(WithholdingTaxReceivableDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementAccountDisplayValue = group.Add(new VocabularyKey(nameof(SettlementAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApplyThreshold = group.Add(new VocabularyKey(nameof(ApplyThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdComponent = group.Add(new VocabularyKey(nameof(TaxWithholdComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivableAccount = group.Add(new VocabularyKey(nameof(ReceivableAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivableAccountDisplayValue = group.Add(new VocabularyKey(nameof(ReceivableAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingTaxComponent = group.Add(new VocabularyKey(nameof(WithholdingTaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WithholdingComponentGroup = group.Add(new VocabularyKey(nameof(WithholdingComponentGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CurrencyCodeID { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey WithholdingTaxBase { get; private set; }
public VocabularyKey WithholdingCode { get; private set; }
public VocabularyKey WithholdingTaxName { get; private set; }
public VocabularyKey WithholdingTaxRoundOff { get; private set; }
public VocabularyKey WithholdingTaxRoundOffType { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxWithholdLedgerAccountGroupRecId { get; private set; }
public VocabularyKey TaxWithholdPeriodHeadRecId { get; private set; }
public VocabularyKey TaxWithholdAccountGroup { get; private set; }
public VocabularyKey TaxWithholdPeriod { get; private set; }
public VocabularyKey WithholdingTaxReceivable { get; private set; }
public VocabularyKey BrazilianTaxWithholdPeriod { get; private set; }
public VocabularyKey BrazilianTaxWithholdType { get; private set; }
public VocabularyKey SettlementAccount { get; private set; }
public VocabularyKey WithholdingTaxReceivableDisplayValue { get; private set; }
public VocabularyKey SettlementAccountDisplayValue { get; private set; }
public VocabularyKey ApplyThreshold { get; private set; }
public VocabularyKey TaxType { get; private set; }
public VocabularyKey TaxWithholdComponent { get; private set; }
public VocabularyKey ReceivableAccount { get; private set; }
public VocabularyKey ReceivableAccountDisplayValue { get; private set; }
public VocabularyKey WithholdingTaxComponent { get; private set; }
public VocabularyKey WithholdingComponentGroup { get; private set; }
public VocabularyKey SettlementPeriod { get; private set; }


    }
}