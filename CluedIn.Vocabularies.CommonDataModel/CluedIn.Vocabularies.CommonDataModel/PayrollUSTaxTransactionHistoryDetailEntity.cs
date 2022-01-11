using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollUSTaxTransactionHistoryDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollUSTaxTransactionHistoryDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollUSTaxTransactionHistoryDetailEntity";
            KeyPrefix = "commonDataModel.payrollustaxtransactionhistorydetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollUSTaxTransactionHistoryDetailEntity";

            AddGroup("Common Data Model PayrollUSTaxTransactionHistoryDetailEntity Details", group =>
            {
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GrossWages = group.Add(new VocabularyKey(nameof(GrossWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GrossSubjectWages = group.Add(new VocabularyKey(nameof(GrossSubjectWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubjectWages = group.Add(new VocabularyKey(nameof(SubjectWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Hours = group.Add(new VocabularyKey(nameof(Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExcessWages = group.Add(new VocabularyKey(nameof(ExcessWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriorState = group.Add(new VocabularyKey(nameof(PriorState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriorStateWageAmount = group.Add(new VocabularyKey(nameof(PriorStateWageAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WageBase = group.Add(new VocabularyKey(nameof(WageBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalculatedTaxAmount = group.Add(new VocabularyKey(nameof(CalculatedTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Worker { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey TransDate { get; private set; }
public VocabularyKey PayStatementNumber { get; private set; }
public VocabularyKey Code { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey GrossWages { get; private set; }
public VocabularyKey GrossSubjectWages { get; private set; }
public VocabularyKey SubjectWages { get; private set; }
public VocabularyKey Hours { get; private set; }
public VocabularyKey Rate { get; private set; }
public VocabularyKey ExcessWages { get; private set; }
public VocabularyKey PriorState { get; private set; }
public VocabularyKey PriorStateWageAmount { get; private set; }
public VocabularyKey WageBase { get; private set; }
public VocabularyKey CalculatedTaxAmount { get; private set; }
public VocabularyKey Invoice { get; private set; }


    }
}