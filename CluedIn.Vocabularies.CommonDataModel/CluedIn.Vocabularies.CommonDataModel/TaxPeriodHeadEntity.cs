using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPeriodHeadEntityVocabulary : SimpleVocabulary
    {
        public TaxPeriodHeadEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxPeriodHeadEntity";
            KeyPrefix = "commonDataModel.taxperiodheadentity";
            KeySeparator = ".";
            Grouping = "/TaxPeriodHeadEntity";

            AddGroup("Common Data Model TaxPeriodHeadEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTerms = group.Add(new VocabularyKey(nameof(PaymentTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DurationUnit = group.Add(new VocabularyKey(nameof(DurationUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Duration = group.Add(new VocabularyKey(nameof(Duration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxAuthority = group.Add(new VocabularyKey(nameof(TaxAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPeriodId = group.Add(new VocabularyKey(nameof(TaxPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey PaymentTerms { get; private set; }
public VocabularyKey DurationUnit { get; private set; }
public VocabularyKey Duration { get; private set; }
public VocabularyKey TaxAuthority { get; private set; }
public VocabularyKey TaxPeriodId { get; private set; }


    }
}