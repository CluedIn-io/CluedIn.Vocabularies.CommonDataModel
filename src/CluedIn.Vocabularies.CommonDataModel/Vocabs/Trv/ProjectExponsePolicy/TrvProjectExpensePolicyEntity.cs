using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvProjectExpensePolicyEntityVocabulary : SimpleVocabulary
    {
        public TrvProjectExpensePolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvProjectExpensePolicyEntity";
            KeyPrefix = "commonDataModel.trvprojectexpensepolicyentity";
            KeySeparator = ".";
            Grouping = "/TrvProjectExpensePolicyEntity";

            AddGroup("Common Data Model TrvProjectExpensePolicyEntity Details", group =>
            {
                AllowableAmount = group.Add(new VocabularyKey(nameof(AllowableAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PerUnit = group.Add(new VocabularyKey(nameof(PerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumAmount = group.Add(new VocabularyKey(nameof(MaximumAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumPercent = group.Add(new VocabularyKey(nameof(MaximumPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectExpensePolicyWorkerGroup = group.Add(new VocabularyKey(nameof(ProjectExpensePolicyWorkerGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptMinimum = group.Add(new VocabularyKey(nameof(ReceiptMinimum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptRequired = group.Add(new VocabularyKey(nameof(ReceiptRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AllowableAmount { get; private set; }
public VocabularyKey City { get; private set; }
public VocabularyKey ExpenseCategory { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey PerUnit { get; private set; }
public VocabularyKey MaximumAmount { get; private set; }
public VocabularyKey MaximumPercent { get; private set; }
public VocabularyKey ProjectExpensePolicyWorkerGroup { get; private set; }
public VocabularyKey PolicyType { get; private set; }
public VocabularyKey ProjectID { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey ReceiptMinimum { get; private set; }
public VocabularyKey ReceiptRequired { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }


    }
}