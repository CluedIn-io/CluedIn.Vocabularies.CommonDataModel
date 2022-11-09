using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPostingGroupEntityV2Vocabulary : SimpleVocabulary
    {
        public TaxPostingGroupEntityV2Vocabulary()
        {
            VocabularyName = "Common Data Model TaxPostingGroupEntityV2";
            KeyPrefix = "commonDataModel.taxpostinggroupentityv2";
            KeySeparator = ".";
            Grouping = "/TaxPostingGroupEntityV2";

            AddGroup("Common Data Model TaxPostingGroupEntityV2 Details", group =>
            {
                TaxPostingGroupCode = group.Add(new VocabularyKey(nameof(TaxPostingGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxFromCustomerCashDiscountMainAccountId = group.Add(new VocabularyKey(nameof(TaxFromCustomerCashDiscountMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxFromCustomerCashDiscountMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxFromCustomerCashDiscountMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxFromVendorCashDiscountMainAccountId = group.Add(new VocabularyKey(nameof(TaxFromVendorCashDiscountMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxFromVendorCashDiscountMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxFromVendorCashDiscountMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPayableMainAccountId = group.Add(new VocabularyKey(nameof(TaxPayableMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPayableMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxPayableMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseTaxPayableMainAccountId = group.Add(new VocabularyKey(nameof(UseTaxPayableMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseTaxPayableMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(UseTaxPayableMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxReceivableMainAccountId = group.Add(new VocabularyKey(nameof(TaxReceivableMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxReceivableMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxReceivableMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxSettlementMainAccountId = group.Add(new VocabularyKey(nameof(TaxSettlementMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxSettlementMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxSettlementMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseTaxMainAccountId = group.Add(new VocabularyKey(nameof(UseTaxMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseTaxMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(UseTaxMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxReceivableLongTermMainAccountId = group.Add(new VocabularyKey(nameof(TaxReceivableLongTermMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxReceivableLongTermMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxReceivableLongTermMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxReceivableShortTermMainAccountId = group.Add(new VocabularyKey(nameof(TaxReceivableShortTermMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxReceivableShortTermMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxReceivableShortTermMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxSalesExpenseMainAccountId = group.Add(new VocabularyKey(nameof(TaxSalesExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxSalesExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxSalesExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxUnrealizedPayablesMainAccountId = group.Add(new VocabularyKey(nameof(TaxUnrealizedPayablesMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxUnrealizedPayablesMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxUnrealizedPayablesMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxUnrealizedReceivablesMainAccountId = group.Add(new VocabularyKey(nameof(TaxUnrealizedReceivablesMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxUnrealizedReceivablesMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxUnrealizedReceivablesMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIncomingDifferenceMainAccountId = group.Add(new VocabularyKey(nameof(TaxIncomingDifferenceMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIncomingDifferenceMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxIncomingDifferenceMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIncomingDiffOffsetMainAccountId = group.Add(new VocabularyKey(nameof(TaxIncomingDiffOffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIncomingDiffOffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxIncomingDiffOffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOutgoingDifferenceMainAccountId = group.Add(new VocabularyKey(nameof(TaxOutgoingDifferenceMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOutgoingDifferenceMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxOutgoingDifferenceMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOutgoingDiffOffsetMainAccountId = group.Add(new VocabularyKey(nameof(TaxOutgoingDiffOffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOutgoingDiffOffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxOutgoingDiffOffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOutgoingOffsetLedgerMainAccountId = group.Add(new VocabularyKey(nameof(TaxOutgoingOffsetLedgerMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxOutgoingOffsetLedgerMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(TaxOutgoingOffsetLedgerMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxPostingGroupCode { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey TaxFromCustomerCashDiscountMainAccountId { get; private set; }
public VocabularyKey TaxFromCustomerCashDiscountMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxFromVendorCashDiscountMainAccountId { get; private set; }
public VocabularyKey TaxFromVendorCashDiscountMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxPayableMainAccountId { get; private set; }
public VocabularyKey TaxPayableMainAccountIdDisplayValue { get; private set; }
public VocabularyKey UseTaxPayableMainAccountId { get; private set; }
public VocabularyKey UseTaxPayableMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxReceivableMainAccountId { get; private set; }
public VocabularyKey TaxReceivableMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxSettlementMainAccountId { get; private set; }
public VocabularyKey TaxSettlementMainAccountIdDisplayValue { get; private set; }
public VocabularyKey UseTaxMainAccountId { get; private set; }
public VocabularyKey UseTaxMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxReceivableLongTermMainAccountId { get; private set; }
public VocabularyKey TaxReceivableLongTermMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxReceivableShortTermMainAccountId { get; private set; }
public VocabularyKey TaxReceivableShortTermMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxSalesExpenseMainAccountId { get; private set; }
public VocabularyKey TaxSalesExpenseMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxUnrealizedPayablesMainAccountId { get; private set; }
public VocabularyKey TaxUnrealizedPayablesMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxUnrealizedReceivablesMainAccountId { get; private set; }
public VocabularyKey TaxUnrealizedReceivablesMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxIncomingDifferenceMainAccountId { get; private set; }
public VocabularyKey TaxIncomingDifferenceMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxIncomingDiffOffsetMainAccountId { get; private set; }
public VocabularyKey TaxIncomingDiffOffsetMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxOutgoingDifferenceMainAccountId { get; private set; }
public VocabularyKey TaxOutgoingDifferenceMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxOutgoingDiffOffsetMainAccountId { get; private set; }
public VocabularyKey TaxOutgoingDiffOffsetMainAccountIdDisplayValue { get; private set; }
public VocabularyKey TaxOutgoingOffsetLedgerMainAccountId { get; private set; }
public VocabularyKey TaxOutgoingOffsetLedgerMainAccountIdDisplayValue { get; private set; }


    }
}