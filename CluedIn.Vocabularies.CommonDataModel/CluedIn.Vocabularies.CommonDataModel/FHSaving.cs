using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHSavingVocabulary : SimpleVocabulary
    {
        public FHSavingVocabulary()
        {
            VocabularyName = "Common Data Model FHSaving";
            KeyPrefix = "commonDataModel.fhsaving";
            KeySeparator = ".";
            Grouping = "/FHSaving";

            AddGroup("Common Data Model FHSaving Details", group =>
            {
                FH_SavingId = group.Add(new VocabularyKey(nameof(FH_SavingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accountingClassification = group.Add(new VocabularyKey(nameof(accountingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accruedInterest = group.Add(new VocabularyKey(nameof(accruedInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accruedinterest_Base = group.Add(new VocabularyKey(nameof(accruedinterest_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accruedInterest_default = group.Add(new VocabularyKey(nameof(accruedInterest_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balance = group.Add(new VocabularyKey(nameof(balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balance_Base = group.Add(new VocabularyKey(nameof(balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceatMaturity = group.Add(new VocabularyKey(nameof(balanceatMaturity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceatmaturity_Base = group.Add(new VocabularyKey(nameof(balanceatmaturity_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceatMaturity_default = group.Add(new VocabularyKey(nameof(balanceatMaturity_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceDefault = group.Add(new VocabularyKey(nameof(balanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceExchangerate = group.Add(new VocabularyKey(nameof(balanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
blockedAmount = group.Add(new VocabularyKey(nameof(blockedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
blockedamount_Base = group.Add(new VocabularyKey(nameof(blockedamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
blockedAmount_default = group.Add(new VocabularyKey(nameof(blockedAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialHoldingCategory = group.Add(new VocabularyKey(nameof(financialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialHoldingType = group.Add(new VocabularyKey(nameof(financialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
initialSource = group.Add(new VocabularyKey(nameof(initialSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
interestrate = group.Add(new VocabularyKey(nameof(interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maturitydate = group.Add(new VocabularyKey(nameof(maturitydate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
maturityInstructionsDetails = group.Add(new VocabularyKey(nameof(maturityInstructionsDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
projectedInterestAmount = group.Add(new VocabularyKey(nameof(projectedInterestAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
projectedinterestamount_Base = group.Add(new VocabularyKey(nameof(projectedinterestamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
projectedInterestAmount_default = group.Add(new VocabularyKey(nameof(projectedInterestAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
term = group.Add(new VocabularyKey(nameof(term), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(balanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balanceDisplayValue = group.Add(new VocabularyKey(nameof(balanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FH_SavingId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey accountingClassification { get; private set; }
public VocabularyKey accruedInterest { get; private set; }
public VocabularyKey accruedinterest_Base { get; private set; }
public VocabularyKey accruedInterest_default { get; private set; }
public VocabularyKey balance { get; private set; }
public VocabularyKey balance_Base { get; private set; }
public VocabularyKey balanceatMaturity { get; private set; }
public VocabularyKey balanceatmaturity_Base { get; private set; }
public VocabularyKey balanceatMaturity_default { get; private set; }
public VocabularyKey balanceDefault { get; private set; }
public VocabularyKey balanceExchangerate { get; private set; }
public VocabularyKey blockedAmount { get; private set; }
public VocabularyKey blockedamount_Base { get; private set; }
public VocabularyKey blockedAmount_default { get; private set; }
public VocabularyKey financialHoldingCategory { get; private set; }
public VocabularyKey financialHoldingType { get; private set; }
public VocabularyKey initialSource { get; private set; }
public VocabularyKey integrationKey { get; private set; }
public VocabularyKey interestrate { get; private set; }
public VocabularyKey maturitydate { get; private set; }
public VocabularyKey maturityInstructionsDetails { get; private set; }
public VocabularyKey projectedInterestAmount { get; private set; }
public VocabularyKey projectedinterestamount_Base { get; private set; }
public VocabularyKey projectedInterestAmount_default { get; private set; }
public VocabularyKey term { get; private set; }
public VocabularyKey balanceDefaultDisplayValue { get; private set; }
public VocabularyKey balanceDisplayValue { get; private set; }
public VocabularyKey balancedisplayvalue_Base { get; private set; }


    }
}