using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCodeValueEntityVocabulary : SimpleVocabulary
    {
        public TaxCodeValueEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxCodeValueEntity";
            KeyPrefix = "commonDataModel.taxcodevalueentity";
            KeySeparator = ".";
            Grouping = "/TaxCodeValueEntity";

            AddGroup("Common Data Model TaxCodeValueEntity Details", group =>
            {
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumLimit = group.Add(new VocabularyKey(nameof(MaximumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumLimit = group.Add(new VocabularyKey(nameof(MinimumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NonDeductiblePercentage = group.Add(new VocabularyKey(nameof(NonDeductiblePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReductionPercentage = group.Add(new VocabularyKey(nameof(ReductionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubstitutionMarkupPercentage = group.Add(new VocabularyKey(nameof(SubstitutionMarkupPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Duty = group.Add(new VocabularyKey(nameof(Duty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey FromDate { get; private set; }
public VocabularyKey MaximumLimit { get; private set; }
public VocabularyKey MinimumLimit { get; private set; }
public VocabularyKey ToDate { get; private set; }
public VocabularyKey Value { get; private set; }
public VocabularyKey NonDeductiblePercentage { get; private set; }
public VocabularyKey ReductionPercentage { get; private set; }
public VocabularyKey SubstitutionMarkupPercentage { get; private set; }
public VocabularyKey Duty { get; private set; }


    }
}