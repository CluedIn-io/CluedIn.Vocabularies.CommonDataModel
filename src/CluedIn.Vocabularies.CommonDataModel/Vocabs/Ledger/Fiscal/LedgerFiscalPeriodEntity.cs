using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFiscalPeriodEntityVocabulary : SimpleVocabulary
    {
        public LedgerFiscalPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerFiscalPeriodEntity";
            KeyPrefix = "commonDataModel.ledgerfiscalperiodentity";
            KeySeparator = ".";
            Grouping = "/LedgerFiscalPeriodEntity";

            AddGroup("Common Data Model LedgerFiscalPeriodEntity Details", group =>
            {
                FiscalCalendarPeriodRecId = group.Add(new VocabularyKey(nameof(FiscalCalendarPeriodRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodStatus = group.Add(new VocabularyKey(nameof(PeriodStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarYearRecId = group.Add(new VocabularyKey(nameof(FiscalCalendarYearRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarRecId = group.Add(new VocabularyKey(nameof(FiscalCalendarRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
YearName = group.Add(new VocabularyKey(nameof(YearName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerName = group.Add(new VocabularyKey(nameof(LedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerFiscalCalendarPeriodRecId = group.Add(new VocabularyKey(nameof(LedgerFiscalCalendarPeriodRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerAccessLevel = group.Add(new VocabularyKey(nameof(LedgerAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerUserGroupInfo = group.Add(new VocabularyKey(nameof(LedgerUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxAccessLevel = group.Add(new VocabularyKey(nameof(TaxAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxUserGroupInfo = group.Add(new VocabularyKey(nameof(TaxUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankAccessLevel = group.Add(new VocabularyKey(nameof(BankAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BankUserGroupInfo = group.Add(new VocabularyKey(nameof(BankUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustAccessLevel = group.Add(new VocabularyKey(nameof(CustAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustUserGroupInfo = group.Add(new VocabularyKey(nameof(CustUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendAccessLevel = group.Add(new VocabularyKey(nameof(VendAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendUserGroupInfo = group.Add(new VocabularyKey(nameof(VendUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesAccessLevel = group.Add(new VocabularyKey(nameof(SalesAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesUserGroupInfo = group.Add(new VocabularyKey(nameof(SalesUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchAccessLevel = group.Add(new VocabularyKey(nameof(PurchAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchUserGroupInfo = group.Add(new VocabularyKey(nameof(PurchUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventAccessLevel = group.Add(new VocabularyKey(nameof(InventAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventUserGroupInfo = group.Add(new VocabularyKey(nameof(InventUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProdAccessLevel = group.Add(new VocabularyKey(nameof(ProdAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProdUserGroupInfo = group.Add(new VocabularyKey(nameof(ProdUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectAccessLevel = group.Add(new VocabularyKey(nameof(ProjectAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectUserGroupInfo = group.Add(new VocabularyKey(nameof(ProjectUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssetsAccessLevel = group.Add(new VocabularyKey(nameof(FixedAssetsAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssetsUserGroupInfo = group.Add(new VocabularyKey(nameof(FixedAssetsUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayrollAccessLevel = group.Add(new VocabularyKey(nameof(PayrollAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayrollUserGroupInfo = group.Add(new VocabularyKey(nameof(PayrollUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseAccessLevel = group.Add(new VocabularyKey(nameof(ExpenseAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseUserGroupInfo = group.Add(new VocabularyKey(nameof(ExpenseUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssets_RUAccessLevel = group.Add(new VocabularyKey(nameof(FixedAssets_RUAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssets_RUUserGroupInfo = group.Add(new VocabularyKey(nameof(FixedAssets_RUUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailAccessLevel = group.Add(new VocabularyKey(nameof(RetailAccessLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailUserGroupInfo = group.Add(new VocabularyKey(nameof(RetailUserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FiscalCalendarPeriodRecId { get; private set; }
public VocabularyKey LedgerRecId { get; private set; }
public VocabularyKey PeriodStatus { get; private set; }
public VocabularyKey FiscalCalendarYearRecId { get; private set; }
public VocabularyKey PeriodName { get; private set; }
public VocabularyKey FiscalCalendarRecId { get; private set; }
public VocabularyKey YearName { get; private set; }
public VocabularyKey Calendar { get; private set; }
public VocabularyKey LedgerName { get; private set; }
public VocabularyKey LedgerFiscalCalendarPeriodRecId { get; private set; }
public VocabularyKey LedgerAccessLevel { get; private set; }
public VocabularyKey LedgerUserGroupInfo { get; private set; }
public VocabularyKey TaxAccessLevel { get; private set; }
public VocabularyKey TaxUserGroupInfo { get; private set; }
public VocabularyKey BankAccessLevel { get; private set; }
public VocabularyKey BankUserGroupInfo { get; private set; }
public VocabularyKey CustAccessLevel { get; private set; }
public VocabularyKey CustUserGroupInfo { get; private set; }
public VocabularyKey VendAccessLevel { get; private set; }
public VocabularyKey VendUserGroupInfo { get; private set; }
public VocabularyKey SalesAccessLevel { get; private set; }
public VocabularyKey SalesUserGroupInfo { get; private set; }
public VocabularyKey PurchAccessLevel { get; private set; }
public VocabularyKey PurchUserGroupInfo { get; private set; }
public VocabularyKey InventAccessLevel { get; private set; }
public VocabularyKey InventUserGroupInfo { get; private set; }
public VocabularyKey ProdAccessLevel { get; private set; }
public VocabularyKey ProdUserGroupInfo { get; private set; }
public VocabularyKey ProjectAccessLevel { get; private set; }
public VocabularyKey ProjectUserGroupInfo { get; private set; }
public VocabularyKey FixedAssetsAccessLevel { get; private set; }
public VocabularyKey FixedAssetsUserGroupInfo { get; private set; }
public VocabularyKey PayrollAccessLevel { get; private set; }
public VocabularyKey PayrollUserGroupInfo { get; private set; }
public VocabularyKey ExpenseAccessLevel { get; private set; }
public VocabularyKey ExpenseUserGroupInfo { get; private set; }
public VocabularyKey FixedAssets_RUAccessLevel { get; private set; }
public VocabularyKey FixedAssets_RUUserGroupInfo { get; private set; }
public VocabularyKey RetailAccessLevel { get; private set; }
public VocabularyKey RetailUserGroupInfo { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }


    }
}